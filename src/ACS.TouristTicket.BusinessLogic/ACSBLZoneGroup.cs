using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.Model;
using ACS.TouristTicket.DataAccess;

namespace ACS.TouristTicket.BusinessLogic
{
    public class ACSBLZoneGroup
    {
        public List<ZoneGroup> Select_ZoneGroup()
        {
            return new ACSDAZoneGroup().Select_ZoneGroup();
        }

        public List<DistinctZoneGroupName> Select_DistinctZoneGroupName()
        {
            return new ACSDAZoneGroup().Select_DistinctZoneGroupName();
        }

        public int Insert_ZoneGroup(string ZoneGroupID, string ZoneGroupName, int daysAllowed, int entriesAllowed, decimal price, Nullable<System.DateTime> CreatedDate, Nullable<int> Createdby, Nullable<System.DateTime> ModifiedDate, Nullable<int> ModifiedBy)
        {
            return new ACSDAZoneGroup().Insert_ZoneGroup(ZoneGroupID, ZoneGroupName, daysAllowed, entriesAllowed, price, CreatedDate, Createdby, ModifiedDate, ModifiedBy);
        }
        #region "Update"

        public int Update_ZoneGroup(int PKID, string ZoneGroupID, string ZoneGroupName, int DaysAllowed, int EntriesAllowed, decimal Price, Nullable<int> ModifiedBy, Nullable<System.DateTime> ModifiedDate)
        {
            return new ACSDAZoneGroup().Update_ZoneGroup(PKID,ZoneGroupID, ZoneGroupName, DaysAllowed, EntriesAllowed, Price, ModifiedBy, ModifiedDate);
        }
        #endregion
        #region "DELETE"

        public int Delete_ZoneGroup(string ZoneGroupID)
        {
            return new ACSDAZoneGroup().Delete_ZoneGroup(ZoneGroupID);
        }
        #endregion
    }
}
