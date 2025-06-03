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
               db.ContextOptions.LazyLoadingEnabled = false;
               db.ContextOptions.ProxyCreationEnabled = false;
               ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
               ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
               ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

               db.InsertTransactionLog(PKID, transactionType, transactionDate, data, errorCode,errorMsg);
           }
       }
    }
}
