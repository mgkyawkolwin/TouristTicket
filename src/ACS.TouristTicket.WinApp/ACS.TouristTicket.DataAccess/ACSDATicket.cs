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
        public int InsertTicket(decimal Price, string TicketStatus, int AllowedUsage, int AlreadyUsed, int AllowedDays, Nullable<System.DateTime> ExpiryDate, string TicketData, Nullable<System.DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
                ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(int));
                db.InsertNewTicket(PKID, Price, TicketStatus, AllowedUsage, AlreadyUsed, AllowedDays, ExpiryDate, TicketData, CreatedDate, CreatedBy, modifiedDate, modifiedBy,ErrorCode);
            }
            return 0;
        }
      
        public List<Ticket> Select_Ticket()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                return db.SelectTicket().ToList<Ticket>();
            }
        }

        public int UpdateTicket(decimal Price, string TicketStatus, int AllowedUsage, int AlreadyUsed, int AllowedDays, Nullable<System.DateTime> ExpiryDate, string TicketData, Nullable<System.DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
                ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(int));
                db.UpdateTicket(PKID, Price, TicketStatus, AllowedUsage, AlreadyUsed, AllowedDays, ExpiryDate, modifiedDate, modifiedBy, CreatedDate, CreatedBy, ErrorCode);
            }
            return 0;
        }

        public int Select_MaxPKIDAsTicketSerialNo()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                return 1;
            }
        }
    }
}
