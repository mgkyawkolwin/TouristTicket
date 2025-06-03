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
        public int Insert_Table_In_Zone(int ticketID, int zoneID, Nullable<System.DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<System.DateTime> ModifiedDate, Nullable<int> ModifiedBy)
        {
            return new ACSBLTicketInZone().Insert_Ticket_in_Zone(ticketID, zoneID, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy);
        }
        public List<TicketInZone> Select_TicketInZone()
        {
            return new ACSBLTicketInZone().Select_TicketInZone();
        }
    }
}
