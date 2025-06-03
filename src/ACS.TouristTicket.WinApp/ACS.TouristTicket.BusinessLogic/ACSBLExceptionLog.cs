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
   public  class ACSBLExceptionLog
   {
       #region "INSERT"

       public int Insert_ExceptionLog(string errorMessage, string stackTrace, Nullable<System.DateTime> createdDate)
       {
           return new ACSDAExceptionLog().Insert_ExceptionLog(errorMessage, stackTrace, createdDate);
       }

       #endregion
   }
}
