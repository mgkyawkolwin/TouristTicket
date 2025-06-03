using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ACS.TouristTicket.Model
{
    public class ACSDownSyncUpdateDateRequest
    {
        public DateTime LastDownSyncDate { get; set; }
        public List<tbZoneGroup> ZoneGroupTable { get; set; }

        public List<int> ZoneGroupUpdatedRows { get; set; }
    }
}
