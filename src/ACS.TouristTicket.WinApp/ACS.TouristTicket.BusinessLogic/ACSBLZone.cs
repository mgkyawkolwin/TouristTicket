using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.BusinessLogic;
using ACS.TouristTicket.DataAccess;
using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.BusinessLogic
{
    public class ACSBLZone
    {
        public List<Zone> Select_ZoneList()
        {
            return new ACSDAZone().Select_ZoneList();
        }

        public int Insert_NewZone(string ZoneID, string ZoneName, Nullable<int> createdBy, Nullable<System.DateTime> createdDate, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        {
            return new ACSDAZone().Insert_NewZone(ZoneID, ZoneName, createdBy, createdDate, modifiedBy, modifiedDate);
        }
    }
}
