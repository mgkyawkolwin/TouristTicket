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
    public class ACSDATicketUnused
    {
        public int Insert_TicketUnused(string serialNo, string description, Nullable<int> createdBy, Nullable<System.DateTime> createdDate, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
                ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));
                db.InsertTicketUnused(PKID, serialNo, description, createdBy, createdDate, modifiedBy, modifiedDate, errorCode, errorMsg);
            }
            return 0;
        }

        public int Update_TicketUnused(string serialNo, string description, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
                ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

                db.UpdateTicketUnused(PKID, serialNo, description, modifiedBy, modifiedDate, errorCode, errorMsg);
            }
            return 0;
        }

        public int Delete_TicketDamages(string SerialNo)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;

                db.DeleteTicketDamages(SerialNo);
            }
            return 0;
        }

        public List<TicketUnused> Select_TicketUnused()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;

                return db.SelectTicketUnused().ToList<TicketUnused>();
            }
        }
    }
}
