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
    public class ACSFCTicketSettings
    {
        public List<TicketSetting> SelectTicketSetting()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("SelectTicketSetting", DateTime.Now
                    , "No Params");

                return new ACSBLTicketSettings().SelectTicketSetting();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return null;
        }

        public int InsertTicketSetting(string TicketZoneID, int DaysAllowed, int EntryAllowed, decimal Price, Nullable<DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<DateTime> ModifiedDate, Nullable<int> ModifiedBy)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("InsertTicketSetting", DateTime.Now
                    , "[TicketZoneID=" + TicketZoneID + "][DaysAllowed=" + DaysAllowed.ToString() + "][EntryAllowed=" + EntryAllowed.ToString() + "][Price=" + Price
                    + "][CreatedDate=" + CreatedDate + "][CreatedBy=" + CreatedBy + "][ModifiedDate=" + ModifiedDate + "][ModifiedBy=" + ModifiedBy + "]");

                return new ACSBLTicketSettings().InsertTicketSetting(TicketZoneID, DaysAllowed, EntryAllowed, Price, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy);
            }
            catch(Exception ex)
            {
                return new ACSBLExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
        }

        public int UpdateTicketSettings(string TicketZoneID, int DaysAllowed, int EntryAllowed, decimal Price, Nullable<int> Modifiedby, Nullable<DateTime> ModifiedDate)
        {
            try
            {                
                new ACSFCTransactionLog().Insert_TransactionLog("UpdateTicketSettings", DateTime.Now
                    , "[TicketZoneID=" + TicketZoneID + "][DaysAllowed=" + DaysAllowed.ToString() + "][EntryAllowed=" + EntryAllowed.ToString() + "][Price=" + Price
                    + "][ModifiedBy=" + Modifiedby + "][ModifiedDate=" + ModifiedDate + "]");

                return new ACSBLTicketSettings().UpdateTicketSettings(TicketZoneID, DaysAllowed, EntryAllowed, Price, Modifiedby, ModifiedDate);
            }
            catch (Exception ex)
            {
                new ACSBLExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        public int DeleteTicketSettings(string TicketZoneID)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("DeleteTicketSettings", DateTime.Now
                    , "[TicketZoneID=" + TicketZoneID + "]");

                return new ACSBLTicketSettings().DeleteTicketSettings(TicketZoneID);
            }
            catch (Exception ex)
            {
                new ACSBLExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }
    }
}
