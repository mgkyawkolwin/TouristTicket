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
    public class ACSDACounter
    {
        public List<Counter> Select_Counter()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                return db.SelectCounter().ToList<Counter>();
            }
        }

        public List<CounterAndZone> Select_CounterDetail()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                return db.SelectCounterDetail().ToList<CounterAndZone>();
            }
        }

        public int Insert_Counter(int counterID, int zoneID, Nullable<int> createdBy, Nullable<System.DateTime> createdDate)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
                ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

                db.InsertCounter(PKID, counterID, zoneID, 1, DateTime.Now, errorCode, errorMsg);
            }
            return 0;
        }

        public int Update_Counter(int PKID, int counterID, int zoneID)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;

                ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

                db.UpdateCounter(PKID, counterID, zoneID, errorCode, errorMsg);
            }
            return 0;
        }

        public int Delete_Counter(int CounterID)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;

                ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter errorMsg = new ObjectParameter("ErrorMsg", typeof(string));

                db.DeleteCounter(CounterID, errorCode, errorMsg);
            }
            return 0;
        }

        public int SelectNewCounterID()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                return db.SelectNewCounterID().FirstOrDefault() ?? 100;
            }
        }
    }
}
