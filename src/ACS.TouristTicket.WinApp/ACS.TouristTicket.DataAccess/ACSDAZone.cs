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
        public List<Zone> Select_ZoneList()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                return db.SelectZone().ToList<Zone>();
            }
        }

        public int Insert_NewZone(string zoneID, string zoneName, Nullable<int> createdBy, Nullable<System.DateTime> createdDate, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
                ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(int));
                db.InsertZone(PKID, zoneID, zoneName, 1, DateTime.Now, 1, DateTime.Now, ErrorCode);
            }
            return 0;
        }
    }
}
