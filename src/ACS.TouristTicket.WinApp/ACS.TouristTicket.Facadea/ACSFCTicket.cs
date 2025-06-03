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
        public int Insert_Ticket(decimal Price, string TicketStatus, int AllowedUsage, int AlreadyUsed, int AllowedDays, Nullable<System.DateTime> ExpiryDate, string TicketData, Nullable<System.DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSBLTicket().Insert_Ticket(Price, TicketStatus, AllowedUsage, AlreadyUsed, AllowedDays, ExpiryDate, TicketData, CreatedDate, CreatedBy, modifiedDate, modifiedBy);
        }
        public List<Ticket> Select_Ticket()
        {
            return new ACSBLTicket().Select_Ticket();
        }

        public int Update_Ticket(decimal Price, string TicketStatus, int AllowedUsage, int AlreadyUsed, int AllowedDays, Nullable<System.DateTime> ExpiryDate, string TicketData, Nullable<System.DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSBLTicket().Update_Ticket(Price, TicketStatus, AllowedUsage, AlreadyUsed, AllowedDays, ExpiryDate, TicketData, CreatedDate, CreatedBy, modifiedDate, modifiedBy);
        }

        public int Select_MaxPKIDAsTicketSerialNo()
        {
            return new ACSBLTicket().Select_MaxPKIDAsTicketSerialNo();
        }
    }
}
