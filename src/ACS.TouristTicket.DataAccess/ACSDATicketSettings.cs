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
    public class ACSDATicketSettings
    {
        public List<TicketSetting> SelectTicketSetting()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                return db.SelectTicketSetting().ToList<TicketSetting>();
            }
        }

        public int InsertTicketSettings(string TicketZoneID, int DaysAllowed, int EntryAllowed, decimal Price, Nullable<int> CreatedBy, Nullable<DateTime> CreatedDate, Nullable<int> modifiedBy, Nullable<DateTime> ModifiedDate)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
                ObjectParameter Errorcode = new ObjectParameter("ErrorCode", typeof(int));
                db.InsertTicketSetting(PKID, TicketZoneID, DaysAllowed, EntryAllowed, Price, CreatedDate, CreatedBy, ModifiedDate, modifiedBy, Errorcode);
            }
            return 0;
        }

        public int UpdaTeticketSettings(string TicketZoneID, int DaysAllowed, int EntryAllowed, decimal Price, Nullable<int> ModifiedBy, Nullable<DateTime> ModifiedDate)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(int));
                db.UpdateTicketSetting(TicketZoneID, DaysAllowed, EntryAllowed, Price, ModifiedDate, ModifiedBy, ErrorCode);
            }
            return 0;
        }

        public int DeleteTicketSettings(string TicketZoneID)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter ErrorCode = new ObjectParameter("ErrorCode", typeof(int));
                db.DeleteTicketSettings(TicketZoneID, ErrorCode);
            }
            return 0;
        }
    }
}
