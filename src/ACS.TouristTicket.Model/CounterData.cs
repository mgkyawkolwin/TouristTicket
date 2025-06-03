using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACS.TouristTicket.Model
{
    public class CounterData
    {
        public List<TicketActivationLog> ActivationLogs { get; set; }
        public List<TicketUsageLog> UsageLogs { get; set; }
        public List<Ticket> TicketsToExport { get; set; }
    }
}
