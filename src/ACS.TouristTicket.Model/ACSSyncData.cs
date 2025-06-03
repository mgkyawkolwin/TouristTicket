using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace ACS.TouristTicket.Model
{
    [DataContract()]
    public class ACSSyncData
    {
        [DataMember()]
        public int TotalRecords { get; set; }
        [DataMember()]
        public List<int> ZoneGroupPKID { get; set; }
        [DataMember()]
        public List<tbZoneGroup> ZoneGroupTable { get; set; }
        [DataMember()]
        public List<int> ZoneAndZoneGroupPKID { get; set; }
        [DataMember()]
        public List<tbZoneAndZoneGroup> ZoneAndZoneGroupTable { get; set; }
        [DataMember()]
        public List<int> ZonePKID { get; set; }
        [DataMember()]
        public List<tbZone> ZoneTable { get; set; }
        [DataMember()]
        public List<int> TicketInZonePKID { get; set; }
        [DataMember()]
        public List<tbTicketInZone> TicketInZoneTable { get; set; }
        [DataMember()]
        public List<int> TicketPKID { get; set; }
        [DataMember()]
        public List<tbTicket> TicketTable { get; set; }
        [DataMember()]
        public List<int> TicketUsageLogPKID { get; set; }
        [DataMember()]
        public List<tbTicketUsageLog> TicketUsageLogTable { get; set; }
    }
}
