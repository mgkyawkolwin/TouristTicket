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
    public class ACSFCZone
    {
        public List<Zone> Select_ZoneList()
        {
            return new ACSBLZone().Select_ZoneList();
        }

        public int Insert_NewZone(string ZoneID, string ZoneName, Nullable<int> createdBy, Nullable<System.DateTime> createdDate, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        {
            return new ACSBLZone().Insert_NewZone(ZoneID, ZoneName, createdBy, createdDate, modifiedBy, modifiedDate);
        }
    }
}
