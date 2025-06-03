using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.TouristTicket.BusinessLogic;

namespace ACS.TouristTicket.Facade
{
    public class ACSFCLogEncryptDecrypt
    {
        public static string EncryptLog(string plainLog)
        {
            return ACSBLogEncryptDecrypt.EncryptLog(plainLog);
        }

        public static string DecryptLog(string encryptedLog)
        {
            return ACSBLogEncryptDecrypt.DecryptLog(encryptedLog);
        }
    }
}
