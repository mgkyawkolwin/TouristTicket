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
   public  class ACSDAExceptionLog
    {
       public int Insert_ExceptionLog(string errorMessage, string stackTrace, Nullable<System.DateTime> createdDate)
       {
           using (TouristTicketContainer db = new TouristTicketContainer())
           {
               db.ContextOptions.LazyLoadingEnabled = false;
               db.ContextOptions.ProxyCreationEnabled = false;
               ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
               ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
               ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

              db.InsertExceptionLog(PKID, errorMessage, stackTrace, (DateTime)createdDate, errorCode, errorMsg);

               //if (errorCode.Value.ToString() != "0")
               //    throw new Exception("ErrorCode = " + errorCode.Value.ToString() + "; ErrorMsg = " + errorMsg.Value.ToString());
               //return returnValue;
           }
           return 0;
       }
    }
}
