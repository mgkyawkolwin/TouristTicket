using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.DataAccess
{
   public  class ACSDATransactionLog
    {
       public void Insert_TransactionLog(string transactionType, Nullable<System.DateTime> transactionDate, string data)
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
               ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(int));
               db.InsertTransactionLog(PKID, transactionType, transactionDate, data, ErrorCode);
           }
       }
    }
}
