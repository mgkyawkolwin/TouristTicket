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
    public class ACSDATicketInZone
    {
        public int Insert_ticketInZone(int ticketID,int zoneID,Nullable<System.DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<System.DateTime> ModifiedDate, Nullable<int> ModifiedBy)
        { 
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                ObjectParameter PKID = new ObjectParameter("PKID",typeof(int));
                ObjectParameter ErrorCode = new ObjectParameter("ErrorCode",typeof(int));
                db.InsertTicketInZone(PKID,ticketID,zoneID,CreatedDate,CreatedBy,ModifiedDate,ModifiedBy,ErrorCode);
            }
            return 0;
        }
        public List<TicketInZone> Select_TicketInZone()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                return db.SelectTicketInZone().ToList<TicketInZone>();
            }
        }
    }
}
