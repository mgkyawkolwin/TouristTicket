using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.DataAccess
{
    public class ACSDAUpSync
    {
        public ACSSyncData GetUpSyncData()
        {
            ACSSyncData syncData = new ACSSyncData();
            using (TouristTicketEntities db = new TouristTicketEntities())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                //zone group
                syncData.ZoneGroupTable = (from tb in db.tbZoneGroups
                                           where tb.LastUploadedDate == null || tb.LastUploadedDate < tb.ModifiedDate
                                           select tb).Take(10).ToList<tbZoneGroup>();
                //zone and zone group
                syncData.ZoneAndZoneGroupTable = (from r in db.tbZoneAndZoneGroups
                                                  where r.LastUploadedDate == null || r.LastUploadedDate < r.ModifiedDate
                                                  select r).Take(10).ToList<tbZoneAndZoneGroup>();
                //zone
                syncData.ZoneTable = (from r in db.tbZones
                                      where r.LastUploadedDate == null || r.LastUploadedDate < r.ModifiedDate
                                      select r).Take(10).ToList<tbZone>();
                //ticket
                syncData.TicketTable = (from r in db.tbTickets
                                        where r.LastUploadedDate == null || r.LastUploadedDate < r.ModifiedDate
                                        select r).Take(10).ToList<tbTicket>();
                //ticket usage
                //syncData.TicketUsageLogTable = (from r in db.tbTicketUsageLogs
                //                        where r.LastUploadedDate == null
                //                                select r).Take(10).ToList<tbTicketUsageLog>();
                //ticket in zone
                syncData.TicketInZoneTable = (from r in db.tbTicketInZones
                                              where r.LastUploadedDate == null
                                              select r).Take(10).ToList<tbTicketInZone>();

                //total records
                syncData.TotalRecords = syncData.ZoneGroupTable.Count + syncData.ZoneAndZoneGroupTable.Count + syncData.ZoneTable.Count + syncData.TicketTable.Count + syncData.TicketInZoneTable.Count;

                return syncData;
            }
        }

        public void UpdateLastUpSyncDate(ACSSyncData syncData)
        {
            using (TouristTicketEntities db = new TouristTicketEntities())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;

                //zone group
                if (syncData.ZoneGroupPKID.Count > 0)
                {
                    var zoneGroups = (from r in db.tbZoneGroups
                                      where syncData.ZoneGroupPKID.Contains(r.PKID)
                                      select r);
                    foreach (tbZoneGroup r in zoneGroups)
                    {
                        r.LastUploadedDate = DateTime.Now;
                    }
                    db.SaveChanges();
                }
                //zone and zone group
                if (syncData.ZoneAndZoneGroupPKID.Count > 0)
                {
                    var records = (from r in db.tbZoneAndZoneGroups
                                   where syncData.ZoneAndZoneGroupPKID.Contains(r.PKID)
                                   select r);
                    foreach (tbZoneAndZoneGroup r in records)
                    {
                        r.LastUploadedDate = DateTime.Now;
                    }
                    db.SaveChanges();
                }
                //zone
                if (syncData.ZonePKID.Count > 0)
                {
                    var records = (from r in db.tbZones
                                   where syncData.ZonePKID.Contains(r.PKID)
                                   select r);
                    foreach (tbZone r in records)
                    {
                        r.LastUploadedDate = DateTime.Now;
                    }
                    db.SaveChanges();
                }
                //ticket
                if (syncData.TicketPKID.Count > 0)
                {
                    var records = (from r in db.tbTickets
                                   where syncData.TicketPKID.Contains(r.PKID)
                                   select r);
                    foreach (tbTicket r in records)
                    {
                        r.LastUploadedDate = DateTime.Now;
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
                        r.LastUploadedDate = DateTime.Now;
                    }
                    db.SaveChanges();
                }
            }
        }
    }
}
