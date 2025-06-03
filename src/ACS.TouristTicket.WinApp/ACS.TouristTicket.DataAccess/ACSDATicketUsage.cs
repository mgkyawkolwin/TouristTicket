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
    public class ACSDATicketUsage
    {
        public int Insert_TicketUsage(int TicketID, int ZoneID, Nullable<System.DateTime> DateUsed)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
                ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(int));
                db.InsertTicketUsage(PKID, TicketID, ZoneID, DateUsed, ErrorCode);
            }
            return 0;
        }
        public List<TicketUsage> Select_TicketUsage()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                return db.SelectTicketUsage().ToList<TicketUsage>();
            }
        }
    }
}
