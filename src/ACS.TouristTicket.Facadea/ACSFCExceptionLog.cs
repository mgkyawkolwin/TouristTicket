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
   public  class ACSFCExceptionLog
    {
       #region "INSERT"

       public int Insert_ExceptionLog(string errorMessage, string stackTrace, Nullable<System.DateTime> createdDate)
       {
           return new ACSBLExceptionLog().Insert_ExceptionLog(errorMessage, stackTrace, createdDate);
       }

       #endregion
    }
}
