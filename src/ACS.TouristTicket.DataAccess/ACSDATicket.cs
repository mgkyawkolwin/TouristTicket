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
    public class ACSDATicket
    {
        public int InsertPrintingCode(string printingCode)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));
                db.InsertPrintingCode(printingCode, errorCode, errorMsg);

                //if (errorCode.Value.ToString() != "0")
                //    throw new Exception("ErrorCode = " + errorCode.Value.ToString() + "; ErrorMsg = " + errorMsg.Value.ToString());
                
            }
            return 0;
        }

        public int InsertTicket(int ticketSerial,string ZoneGroupID, decimal Price, string TicketStatus, int AllowedUsage, int AlreadyUsed, int AllowedDays, Nullable<System.DateTime> ExpiryDate, string TicketData, Nullable<System.DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));
                int returnValues = db.InsertNewTicket(ticketSerial, ZoneGroupID, Price, TicketStatus, AllowedUsage, AlreadyUsed, AllowedDays, ExpiryDate, TicketData , CreatedDate, CreatedBy, modifiedDate, modifiedBy,errorCode,errorMsg).FirstOrDefault() ?? 0;
                if (errorCode.Value.ToString() != "0")
                    throw new Exception("ErrorCode = " + errorCode.Value.ToString() + "; ErrorMsg = " + errorMsg.Value.ToString());
                return returnValues;
            }
        }
      
        public List<Ticket> Select_Ticket()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                return db.SelectTicket().ToList<Ticket>();
            }
        }

        public List<PrintingApproved> Select_PrintingCode()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                return db.SelectPrintingApproved().ToList<PrintingApproved>();
            }
        }

        public int UpdateTicket(decimal Price, string TicketStatus, int AllowedUsage, int AlreadyUsed, int AllowedDays, Nullable<System.DateTime> ExpiryDate, string TicketData, Nullable<System.DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
                ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

               db.UpdateTicket(PKID, Price, TicketStatus, AllowedUsage, AlreadyUsed, AllowedDays, ExpiryDate, modifiedDate, modifiedBy, CreatedDate, CreatedBy, errorCode, errorMsg);
            }
            return 0;
        }

        public int UpdateTicketStatus(int TicketID, string ticketStatus, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
                ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));
               db.UpdateTicketStatus(TicketID, ticketStatus, modifiedBy, modifiedDate, errorCode, errorMsg);
            }
            return 0;
        }

        public int Delete_Code()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;

                db.DeletePrintingCode();
            }
            return 0;
        }

        public List<TicketDetail> SelectTicketDetail()
        {
            try
            {
                using (TouristTicketContainer db = new TouristTicketContainer())
                {
                    db.ContextOptions.LazyLoadingEnabled = false;
                    db.ContextOptions.ProxyCreationEnabled = false;
                    return db.SelectTicketDetails().ToList<TicketDetail>();
                }
            }
            catch ( Exception ex)
            {

            }
            return null;
        }

        public List<TicketDetail> SelectTicketCollectionsUsingFilters(int? ticketSerialFrom, int? ticketSerialTo, string ticketStatus, string zoneGroupName, DateTime? createdDateFrom, DateTime? createdDateTo)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                return db.SelectTicketCollectionsUsingFilters(ticketSerialFrom, ticketSerialTo, ticketStatus, zoneGroupName, createdDateFrom, createdDateTo).ToList<TicketDetail>();
            }
        }

        public int Select_MaxPKIDAsTicketSerialNo()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                return 1;
            }
        }

        public int SelectNewTicketID()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                return db.SelectNewTicketID().FirstOrDefault() ?? 0;
            }
        }
    }
}
