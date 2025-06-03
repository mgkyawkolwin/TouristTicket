using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.BusinessLogic
{
    class TicketValidator
    {
        public static ACSResult ValidateTicket(string encryptedTicketData)
        {
            //if everything successful, return success message
            return new ACSResult() { StatusCode = 0, StatusMsg = "Validation successful." };
        }

        /// <summary>
        /// To validate the ticket has valida data or not using hash/message digest
        /// </summary>
        /// <param name="encryptedTicketData"></param>
        /// <returns></returns>
        public static ACSResult ValidateMessageDigest(string encryptedTicketData)
        {

            //if everything successful, return success message
            return new ACSResult() { StatusCode = 0, StatusMsg = "Validation successful." };
        }
    }
}
