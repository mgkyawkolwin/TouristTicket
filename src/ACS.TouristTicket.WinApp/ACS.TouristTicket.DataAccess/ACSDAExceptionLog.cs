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
               ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
               ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(int));
               db.InsertExceptionLog(PKID, errorMessage, stackTrace, (DateTime)createdDate, ErrorCode);
           }
           return 0;
       }
    }
}
