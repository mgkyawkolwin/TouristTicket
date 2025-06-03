using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.BusinessLogic;
using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.Facade
{
    public class ACSFCSupport
    {
        public string EncDec(string plainText)
        {
            return new TicketEncryptDecrypt().EncryptTicketData(plainText);
        }

        public string Decrypt(string encryptedText)
        {
            return new TicketEncryptDecrypt().DecryptTicketData(encryptedText);
        }
    }
}
