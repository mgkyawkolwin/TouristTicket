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
    public class ACSFCTicketUsage
    {
        public int Insert_TicketUsage(int TicketID, int ZoneID, Nullable<System.DateTime> DateUsed)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Insert_TicketUsage", DateTime.Now
                    , "[TicketID=" + TicketID + "][ZoneID=" + ZoneID + "][DateUsed=" + DateUsed + "]");

                return new ACSBLTicketUsage().Insert_TicketUsage(TicketID, ZoneID, DateUsed);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        public List<TicketUsage> Select_TicketUsage()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Select_TicketUsage", DateTime.Now, "No Params");
                return new ACSBLTicketUsage().Select_TicketUsage();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return null;
        }
    }
}
