using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.DataAccess;
using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.BusinessLogic
{
   public  class ACSBLTransactionLog
    {
       public void Insert_TransactionLog(string transactionType, Nullable<System.DateTime> transactionDate, string data)
       {
           new ACSDATransactionLog().Insert_TransactionLog(transactionType, transactionDate, data);
       }
    }
}
