using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.Model;
using ACS.TouristTicket.BusinessLogic;

namespace ACS.TouristTicket.Facade
{
   public class ACSFCTransactionLog
    {
       public void Insert_TransactionLog(string transactionType, Nullable<System.DateTime> transactionDate, string data)
       {
           new ACSBLTransactionLog().Insert_TransactionLog(transactionType, transactionDate, data);
       }
    }
}
