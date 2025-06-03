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
    public class ACSBLTicketInZone
    {
        public int Insert_TicketInZone(string ticketID, string zoneID, Nullable<System.DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<System.DateTime> ModifiedDate, Nullable<int> ModifiedBy)
        {
            return new ACSDATicketInZone().Insert_TicketInZone(ticketID, zoneID, CreatedDate, CreatedBy, ModifiedDate, ModifiedBy);
        }
        public List<TicketInZone> Select_TicketInZone()
        {
            return new ACSDATicketInZone().Select_TicketInZone();
        }
    }
}
