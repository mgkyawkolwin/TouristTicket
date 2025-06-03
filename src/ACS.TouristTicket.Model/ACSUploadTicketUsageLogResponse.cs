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
    public class ACSUploadTicketUsageLogResponse : IACSResponse
    {
        [DataMember()]
        public int NumberOfRecordsUpdated { get; set; }
        [DataMember()]
        public ACSResult Result { get; set; }
    }
}
