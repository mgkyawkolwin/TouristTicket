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
    public class ACSFCTicketInZone
    {
        public int Insert_TicketInZone(string ticketID, string zoneID, Nullable<System.DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<System.DateTime> ModifiedDate, Nullable<int> ModifiedBy)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Insert_TicketInZone", DateTime.Now,
                    "[ticketID=" + ticketID + "][zoneID=" + zoneID + "][CreatedDate=" + CreatedDate
                    + "][CreatedBy=" + CreatedBy + "][ModifiedDate=" + ModifiedDate + "][ModifiedBy=" + ModifiedBy + "]");

                return new ACSBLTicketInZone().Insert_TicketInZone(ticketID, zoneID, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        public List<TicketInZone> Select_TicketInZone()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Select_TicketInZone", DateTime.Now
                    , "No Params");

                return new ACSBLTicketInZone().Select_TicketInZone();
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
