using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using System.Security.Cryptography;

namespace ACS.TouristTicket.BusinessLogic
{
    public static class ACSBLogEncryptDecrypt
    {
        public static string EncryptLog(string plainLog)
        {
            string encryptedTicketData = "";
            string encryptedData = "";
            string desKey = "";
            string desIV = "";
            // (1) : encrypt the ticket data using randomly generated Key, IV
            using (TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider())
            {
                tripleDes.KeySize = 128;
                tripleDes.GenerateIV();
                tripleDes.GenerateKey();
                desKey = Convert.ToBase64String(tripleDes.Key);
                desIV = Convert.ToBase64String(tripleDes.IV);
                ICryptoTransform encryptor = tripleDes.CreateEncryptor(Convert.FromBase64String(desKey), Convert.FromBase64String(desIV));
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream encryptedStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
                //prepare data
                byte[] data = UTF8Encoding.UTF8.GetBytes(plainLog);
                //write encrypted data into memory stream
                encryptedStream.Write(data,0,data.Length);
                encryptedStream.FlushFinalBlock();
                encryptedData = Convert.ToBase64String(memoryStream.ToArray());
            }

            // (2) : Create a encrypted log data
            encryptedTicketData = desKey + desIV + encryptedData;

            return encryptedTicketData;
        }

        public static string DecryptLog(string encryptedLog)
        {
            int keyLength = 24;
            int IVLength = 12;

            string encryptedData = "";
            string desKey = "";
            string desIV = "";


            // (1) : Extract Key, IV and Data
            desKey = encryptedLog.Substring(0, keyLength);
            desIV = encryptedLog.Substring(keyLength, IVLength);
            encryptedData = encryptedLog.Substring(keyLength + IVLength);

            // (4) : Decrypt
            using (TripleDESCryptoServiceProvider tripleDes = new TripleDESCryptoServiceProvider())
            {
                tripleDes.Key = Convert.FromBase64String(desKey);
                tripleDes.IV = Convert.FromBase64String(desIV);
                ICryptoTransform decryptor = tripleDes.CreateDecryptor(Convert.FromBase64String(desKey), Convert.FromBase64String(desIV));
                MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(encryptedData));
                CryptoStream decryptedStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                //prepare data
                byte[] data = new byte[memoryStream.Length];
                //write encrypted data into memory stream
                decryptedStream.Read(data, 0, data.Length);
                return UTF8Encoding.UTF8.GetString(data);
            }
        }
    }
}
