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
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
                ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

                db.InsertTicketUsage(PKID, TicketID, ZoneID, DateUsed, errorCode, errorMsg);
            }
            return 0;
        }
        public List<TicketUsage> Select_TicketUsage()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                return db.SelectTicketUsage().ToList<TicketUsage>();
            }
        }
    }
}
