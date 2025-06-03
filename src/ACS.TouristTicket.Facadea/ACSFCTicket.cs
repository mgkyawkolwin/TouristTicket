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
    public class ACSFCTicket
    {
        public int InsertPrintingCode(string printingCode)
        {
            return new ACSBLTicket().InsertPrintingCode(printingCode);
        }

        public List<PrintingApproved> SelectPrintingCode()
        {
            return new ACSBLTicket().SelectPrintingCode();
        }

        public int DeletePrintingCode()
        {
            return new ACSBLTicket().DeletePrintingCode();
        }

        public int Insert_Ticket(int ticketSerial,string ZoneGroupID, decimal Price, string TicketStatus, int AllowedUsage, int AlreadyUsed, int AllowedDays, Nullable<System.DateTime> ExpiryDate, string TicketData, Nullable<System.DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Insert_Ticket", DateTime.Now,
                    "[ZoneGroupID=" + ZoneGroupID + "][Price=" + Price + "][TicketStatus=" + TicketStatus
                    + "][AllowedUsage=" + AllowedUsage.ToString() + "][AlreadyUsed=" + AlreadyUsed.ToString()
                    + "][AllowedDays=" + AllowedDays + "][ExpiryDate=" + ExpiryDate + "][TicketData=" + TicketData
                    + "][CreateDate=" + CreatedDate + "][CreatedBy=" + CreatedBy + "][ModifiedDate=" + modifiedDate + "][ModifiedBy=" + modifiedBy);

                return new ACSBLTicket().Insert_Ticket(ticketSerial,ZoneGroupID, Price, TicketStatus, AllowedUsage, AlreadyUsed, AllowedDays, ExpiryDate, TicketData, CreatedDate, CreatedBy, modifiedDate, modifiedBy);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        public List<Ticket> Select_Ticket()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Select_Ticket", DateTime.Now, "No Params");

                return new ACSBLTicket().Select_Ticket();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return null;
        }

        public int Update_Ticket(decimal Price, string TicketStatus, int AllowedUsage, int AlreadyUsed, int AllowedDays, Nullable<System.DateTime> ExpiryDate, string TicketData, Nullable<System.DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Update_Ticket", DateTime.Now,
                   "[Price=" + Price + "][TicketStatus=" + TicketStatus
                   + "][AllowedUsage=" + AllowedUsage.ToString() + "][AlreadyUsed=" + AlreadyUsed.ToString()
                   + "][AllowedDays=" + AllowedDays + "][ExpiryDate=" + ExpiryDate + "][TicketData=" + TicketData
                   + "][CreateDate=" + CreatedDate + "][CreatedBy=" + CreatedBy + "][ModifiedDate=" + modifiedDate + "][ModifiedBy=" + modifiedBy);

                return new ACSBLTicket().Update_Ticket(Price, TicketStatus, AllowedUsage, AlreadyUsed, AllowedDays, ExpiryDate, TicketData, CreatedDate, CreatedBy, modifiedDate, modifiedBy);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        public int Update_TicketStatus(int TicketID, string ticketStatus, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Update_TicketStatus", DateTime.Now,
                    "[TicketID=" + TicketID + "][ticketStatus=" + ticketStatus
                    + "][modifiedBy=" + modifiedBy + "][modifiedDate=" + modifiedDate + "]");

                return new ACSBLTicket().Update_TicketStatus(TicketID, ticketStatus, modifiedBy, modifiedDate);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        public List<TicketDetail> Select_TicketDetail()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Select_TicketDetail", DateTime.Now
                    , "No Params");

                return new ACSBLTicket().Select_TicketDetail();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return null;
        }

        public List<TicketDetail> SelectTicketCollectionsUsingFilters(int? ticketSerialFrom, int? ticketSerialTo, string ticketStatus, string zoneGroupName, DateTime? createdDateFrom, DateTime? createdDateTo)
        {
            return new ACSBLTicket().SelectTicketCollectionsUsingFilters(ticketSerialFrom, ticketSerialTo, ticketStatus, zoneGroupName, createdDateFrom, createdDateTo);
        }

        public int Select_MaxPKIDAsTicketSerialNo()
        {
            try
            {
                new ACSFCTransactionLog().Insert_TransactionLog("Select_MaxPKIDAsTicketSerialNo", DateTime.Now
                    , "No Params");

                return new ACSBLTicket().Select_MaxPKIDAsTicketSerialNo();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                //throw generic exception to UI
                throw new Exception(ACSCConstant.Message.GenericServiceError);
            }
            return 0;
        }

        public int SelectNewTicketID()
        {
            return new ACSBLTicket().SelectNewTicketID();
        }
        
    }
}
