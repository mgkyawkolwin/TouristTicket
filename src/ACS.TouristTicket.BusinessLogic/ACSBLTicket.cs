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
    public class ACSBLTicket
    {
        public int InsertPrintingCode(string printingCode)
        {
            return new ACSDATicket().InsertPrintingCode(printingCode);
        }

        public List<PrintingApproved> SelectPrintingCode()
        {
            return new ACSDATicket().Select_PrintingCode();
        }

        public int DeletePrintingCode()
        {
            return new ACSDATicket().Delete_Code();
        }

        public int Insert_Ticket(int ticketSerial,string ZoneGroupID, decimal Price, string TicketStatus, int AllowedUsage, int AlreadyUsed, int AllowedDays, Nullable<System.DateTime> ExpiryDate, string TicketData, Nullable<System.DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSDATicket().InsertTicket(ticketSerial,ZoneGroupID, Price, TicketStatus, AllowedUsage, AlreadyUsed, AllowedDays, ExpiryDate, TicketData, CreatedDate, CreatedBy, modifiedDate, modifiedBy);
        }
        public List<Ticket> Select_Ticket()
        {
            return new ACSDATicket().Select_Ticket();
        }

        public int Update_Ticket(decimal Price, string TicketStatus, int AllowedUsage, int AlreadyUsed, int AllowedDays, Nullable<System.DateTime> ExpiryDate, string TicketData, Nullable<System.DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSDATicket().UpdateTicket(Price, TicketStatus, AllowedUsage, AlreadyUsed, AllowedDays, ExpiryDate, TicketData, CreatedDate, CreatedBy, modifiedDate, modifiedBy);
        }

        public int Update_TicketStatus(int TicketID, string ticketStatus, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        {
            return new  ACSDATicket().UpdateTicketStatus(TicketID, ticketStatus, modifiedBy, modifiedDate);
        }

        public List<TicketDetail> Select_TicketDetail()
        {
            return new ACSDATicket().SelectTicketDetail();
        }

        public List<TicketDetail> SelectTicketCollectionsUsingFilters(int? ticketSerialFrom, int? ticketSerialTo, string ticketStatus, string zoneGroupName, DateTime? createdDateFrom, DateTime? createdDateTo)
        {
            return new ACSDATicket().SelectTicketCollectionsUsingFilters(ticketSerialFrom, ticketSerialTo, ticketStatus, zoneGroupName, createdDateFrom, createdDateTo );
        }

        public int Select_MaxPKIDAsTicketSerialNo()
        {
            return new ACSDATicket().Select_MaxPKIDAsTicketSerialNo();
        }

        public int SelectNewTicketID()
        {
            return new ACSDATicket().SelectNewTicketID();
        }
    }
}
