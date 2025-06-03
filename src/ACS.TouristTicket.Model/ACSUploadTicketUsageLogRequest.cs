using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

using ACS.TouristTicket.Common;
using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.Model
{
    [DataContract()]
    public class ACSUploadTicketUsageLogRequest
    {
        [DataMember()]
        public IList<TicketUsageLog> TicketUsageLogs { get; set; }
    }
}
