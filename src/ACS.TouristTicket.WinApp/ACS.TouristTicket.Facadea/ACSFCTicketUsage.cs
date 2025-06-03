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
    public class ACSFCTicketUsage
    {
        public int Insert_TicketUsage(int TicketID, int ZoneID, Nullable<System.DateTime> DateUsed)
        {
            return new ACSBLTicketUsage().Insert_TicketUsage(TicketID,ZoneID,DateUsed);
        }
        public List<TicketUsage> Select_TicketUsage()
        {
            return new ACSBLTicketUsage().Select_TicketUsage();
        }
    }
}
