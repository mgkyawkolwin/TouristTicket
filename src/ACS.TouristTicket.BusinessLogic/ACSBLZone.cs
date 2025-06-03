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
        public List<ZoneAndZoneGroup> Select_ZoneAndZoneGroup()
        {
            return new ACSDAZone().Select_ZoneAndZoneGroup();
        }

        public List<Zone> Select_ZoneList()
        {
            return new ACSDAZone().Select_ZoneList();
        }

        public int Insert_NewZone(string ZoneID, string zoneGroupID, string ZoneName, string Address, string Phone, string Incharge, Nullable<int> createdBy, Nullable<System.DateTime> createdDate, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        {
            return new ACSDAZone().Insert_NewZone(ZoneID, zoneGroupID, ZoneName, Address, Phone, Incharge, createdBy, createdDate, modifiedBy, modifiedDate);
        }

        public int Update_Zone(int PKID, int LinkID, string ZoneID, string zoneGroupID, string ZoneName, string Address, string Phone, string Incharge, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        {
            return new ACSDAZone().Update_Zone(PKID, LinkID, ZoneID, zoneGroupID, ZoneName, Address, Phone, Incharge, modifiedBy, modifiedDate);
        }

        //public int Insert_ZoneAndZoneGroup(string zoneID, string zoneGroupID, Nullable<int> createdBy, Nullable<System.DateTime> createdDate, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        //{
        //    return new ACSDAZone().Insert_ZoneAndZoneGroup(zoneID, zoneGroupID, createdBy, createdDate, modifiedBy, modifiedDate);
        //}

        #region Delete...

        public int DeleteZone(string ZoneID)
        {
            return new ACSDAZone().DeleteZone(ZoneID);
        }
        #endregion
    }
}
