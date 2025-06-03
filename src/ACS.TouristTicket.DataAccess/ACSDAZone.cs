using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.DataAccess;
using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.DataAccess
{
    public class ACSDAZone
    {
        public List<ZoneAndZoneGroup> Select_ZoneAndZoneGroup()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                return db.SelectZoneAndZoneGroup().ToList<ZoneAndZoneGroup>();
            }
        }

        public List<Zone> Select_ZoneList()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                return db.SelectZone().ToList<Zone>();
            }
        }

        public int Insert_NewZone(string zoneID, string zoneGroupID, string zoneName, string address, string phone, string incharge, Nullable<int> createdBy, Nullable<System.DateTime> createdDate, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
                ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

                db.InsertZone(PKID, zoneID, zoneGroupID, zoneName, address, phone, incharge, 1, DateTime.Now, 1, DateTime.Now, errorCode, errorMsg);
            }
            return 0;
        }

        //public int Insert_ZoneAndZoneGroup(string zoneID, string zoneGroupID, Nullable<int> createdBy, Nullable<System.DateTime> createdDate, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        //{
        //    using (TouristTicketContainer db = new TouristTicketContainer()) 
        //    {
        //        ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
        //        ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(int));
        //        db.InsertZoneAndZoneGroup(PKID, zoneID, zoneGroupID, createdBy, createdDate, modifiedBy, modifiedDate, ErrorCode);
        //    }
        //    return 0;
        //}

        #region "Update"

        public int Update_Zone(int PKID, int LinkID, string zoneID, string zoneGroupID, string zoneName,string address, string phone, string incharge, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;

                ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

                db.UpdateZone(PKID, LinkID, zoneID, zoneGroupID, zoneName, address, phone, incharge,1, DateTime.Now, errorCode,errorMsg);
            }
            return 0;
        }

        #endregion

        #region Delete...

        public int DeleteZone(string ZoneID)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
                ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

                db.DeleteZone(ZoneID, errorCode, errorMsg);
            }
            return 0;
        }
        #endregion

    }
}
