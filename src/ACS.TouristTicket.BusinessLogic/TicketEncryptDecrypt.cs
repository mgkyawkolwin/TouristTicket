using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Security.Cryptography;

namespace ACS.TouristTicket.BusinessLogic
{
    public class TicketEncryptDecrypt
    {
        public string EncryptTicketData(string plainTicketData)
        {
            string encryptedTicketData = "";
            string encryptedData = "";
            string desKey = "";
            string desIV = "";
            string digitalSignature = "";
            // (1) : encrypt the ticket data using randomly generated Key, IV
            using (TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider())
            {
                tripleDes.KeySize = 128;
                desKey = Convert.ToBase64String(tripleDes.Key);
                desIV = Convert.ToBase64String(tripleDes.IV);
                ICryptoTransform encryptor = tripleDes.CreateEncryptor(Convert.FromBase64String(desKey), Convert.FromBase64String(desIV));
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream encryptedStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
                //prepare data
                byte[] data = UTF8Encoding.Default.GetBytes(plainTicketData);
                //write encrypted data into memory stream
                encryptedStream.Write(data,0,data.Length);
                encryptedStream.FlushFinalBlock();
                encryptedData = Convert.ToBase64String(memoryStream.ToArray());
            }
            byte[] hash;
            // (2) : Create a message digest to create digital signature
            using (SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider())
            {
              //messageDigest = Convert.ToBase64String(sha.ComputeHash(UTF8Encoding.Default.GetBytes(desKey + encryptedData + desIV)));
                hash = sha.ComputeHash(UTF8Encoding.Default.GetBytes(desKey + encryptedData + desIV));
            }

            // (3) : create a digital signature of the message digest
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                //import key info from xml
                FileStream fs = new FileStream("Keys/pri.xml", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                rsa.FromXmlString(sr.ReadToEnd());
                fs.Close();
                digitalSignature = Convert.ToBase64String(rsa.SignHash(hash, "SHA1"));
            }

            // (4) : Create a encrypted ticket data
            encryptedTicketData = desKey + encryptedData + desIV + digitalSignature;

            return encryptedTicketData;
        }

        public string DecryptTicketData(string encryptedTicketData)
        {
            int keyLength = 24;
            int IVLength = 12;
            int dataLength = 58;
            int ticketDataLength = keyLength + IVLength + dataLength;
            int signatureLength = 172;

            string encryptedData = "";
            string desKey = "";
            string desIV = "";

            byte[] hash;
            // (1) : Compute the hash value of Key + Data + IV
            using (SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider())
            {
                //messageDigest = Convert.ToBase64String(sha.ComputeHash(UTF8Encoding.Default.GetBytes(desKey + encryptedData + desIV)));
                hash = sha.ComputeHash(UTF8Encoding.Default.GetBytes(encryptedTicketData.Substring(0, ticketDataLength)));
            }

            // (2) : Verify the encrypted data with digital signature
            if (VerifyHash(hash, Convert.FromBase64String(encryptedTicketData.Substring(ticketDataLength, signatureLength))))
            {
                // if cannot be verified by signature, return null
                return null;
            }

            // (3) : Extract Key, IV and Data
            desKey = encryptedTicketData.Substring(0, keyLength);
            desIV = encryptedTicketData.Substring(keyLength+dataLength, IVLength);
            encryptedData = encryptedTicketData.Substring(keyLength, dataLength);

            // (4) : Decrypt
            using (TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider())
            {
                tripleDes.Key = Convert.FromBase64String(desKey);
                tripleDes.IV = Convert.FromBase64String(desIV);
                ICryptoTransform decryptor = tripleDes.CreateDecryptor(Convert.FromBase64String(desKey), Convert.FromBase64String(desIV));
                MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(encryptedData));
                CryptoStream decryptedStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                //prepare data
                byte[] data = new byte[Convert.FromBase64String(encryptedData).Length];
                //write encrypted data into memory stream
                decryptedStream.Read(data, 0, data.Length);
                return UTF8Encoding.Default.GetString(data);
            }
            return null;
        }

        private bool VerifyHash(byte[] data, byte[] hash)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {
                //import key info from xml
                FileStream fs = new FileStream("Keys/pub.xml", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                rsa.FromXmlString(sr.ReadToEnd());
                fs.Close();
                return rsa.VerifyHash(data, "SHA1", hash);
            }
        }
    }
}
