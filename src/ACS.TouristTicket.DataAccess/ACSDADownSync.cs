using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.DataAccess
{
    public class ACSDADownSync
    {
        public ACSSyncData GetDownSyncData()
        {
            ACSSyncData syncData = new ACSSyncData();
            using (TouristTicketEntities db = new TouristTicketEntities())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                
                //ticket
                syncData.TicketTable = (from r in db.tbTickets
                                        where r.LastDownloadedDate == null || r.LastDownloadedDate < r.ModifiedDate
                                        select r).Take(10).ToList<tbTicket>();
                //ticket usage
                syncData.TicketUsageLogTable = (from r in db.tbTicketUsageLogs
                                                where r.LastDownloadedDate == null
                                                select r).Take(10).ToList<tbTicketUsageLog>();

                //total records
                syncData.TotalRecords = syncData.TicketTable.Count + syncData.TicketUsageLogTable.Count;

                return syncData;
            }
        }

        public void UpdateLastDownSyncDate(ACSSyncData syncData)
        {
            using (TouristTicketEntities db = new TouristTicketEntities())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;

                //ticket
                if (syncData.TicketPKID.Count > 0)
                {
                    var records = (from r in db.tbTickets
                                   where syncData.TicketPKID.Contains(r.PKID)
                                   select r);
                    foreach (tbTicket r in records)
                    {
                        r.LastDownloadedDate = DateTime.Now;
                    }
                    db.SaveChanges();
                }
                //ticket usage log
                if (syncData.TicketUsageLogPKID.Count > 0)
                {
                    var records = (from r in db.tbTicketUsageLogs
                                   where syncData.TicketUsageLogPKID.Contains(r.PKID)
                                   select r);
                    foreach (tbTicketUsageLog r in records)
                    {
                        r.LastDownloadedDate = DateTime.Now;
                    }
                    db.SaveChanges();
                }
            }
        }
    }
}
