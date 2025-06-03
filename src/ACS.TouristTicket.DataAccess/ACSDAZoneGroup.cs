using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 
using System.Data.Objects;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.DataAccess
{
    public class ACSDAZoneGroup
    {
        public List<ZoneGroup> Select_ZoneGroup()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                return db.SelectZoneGroup().ToList<ZoneGroup>();
            }
        }

        public List<DistinctZoneGroupName> Select_DistinctZoneGroupName()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                return db.SelectDistinctZoneGroup().ToList<DistinctZoneGroupName>();
            }
        }

        public int Insert_ZoneGroup(string ZoneGroupID, string ZoneGroupName, int daysAllowed, int entriesAllowed, decimal price, Nullable<System.DateTime> CreatedDaate, Nullable<int> Createdby, Nullable<System.DateTime> ModifiedDate, Nullable<int> ModifiedBy)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
                ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));
                int returnValue = db.InsertZoneGroup(PKID, ZoneGroupID, ZoneGroupName, daysAllowed, entriesAllowed, price, Createdby, CreatedDaate, ModifiedBy, ModifiedDate, errorCode, errorMsg).FirstOrDefault() ?? 0;
                if (errorCode.Value.ToString() != "0")
                    throw new Exception("ErrorCode = " + errorCode.Value.ToString() + "; ErrorMsg = " + errorMsg.Value.ToString());
                return returnValue;
            }
        }
         
        #region "UPDATE"

        public int Update_ZoneGroup(int PKID, string ZoneGroupID, string ZoneGroupName, int DaysAllowed, int EntriesAllowed, decimal Price, Nullable<int> ModifiedBy, Nullable<System.DateTime> ModifiedDate)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;

                ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

                db.UpdateZoneGroup(PKID, ZoneGroupID, ZoneGroupName, DaysAllowed, EntriesAllowed, Price, ModifiedBy, ModifiedDate, errorCode,errorMsg);
                
            }
            return 0;
        }
        #endregion

        #region "DELETE"
        public int Delete_ZoneGroup(string ZoneGroupID)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
                ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

                db.DeleteZoneGroup(ZoneGroupID, errorCode, errorMsg);
            }
            return 0;
        }
        #endregion
    }
}
