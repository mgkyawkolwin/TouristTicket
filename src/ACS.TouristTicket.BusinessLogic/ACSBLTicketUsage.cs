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
    public class ACSBLTicketUsage
    {
        public int Insert_TicketUsage(int TicketID, int ZoneID, Nullable<System.DateTime> DateUsed)
        {
            return new ACSDATicketUsage().Insert_TicketUsage(TicketID, ZoneID, DateUsed);
        }
        public List<TicketUsage> Select_TicketUsage()
        {
            return new ACSDATicketUsage().Select_TicketUsage();
        }
    }
    
}
