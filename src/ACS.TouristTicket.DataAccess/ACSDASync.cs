using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;

using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.DataAccess
{
    public class ACSDASync
    {

        public ACSSyncData SyncData(ACSSyncData syncData)
        {
            ACSSyncData updatedRecords = new ACSSyncData();
            updatedRecords.ZoneGroupPKID = new List<int>();
            updatedRecords.ZonePKID = new List<int>();
            updatedRecords.ZoneAndZoneGroupPKID = new List<int>();
            updatedRecords.TicketPKID = new List<int>();
            updatedRecords.TicketUsageLogPKID = new List<int>();
            updatedRecords.TicketInZonePKID = new List<int>();
            using (TouristTicketEntities db = new TouristTicketEntities())
            {
                db.Connection.Open();
                //zone group
                if (syncData.ZoneGroupTable != null && syncData.ZoneGroupTable.Count > 0)
                {
                    foreach (tbZoneGroup r in syncData.ZoneGroupTable)
                    {
                        var result = (from row in db.tbZoneGroups
                                      where row.PKID == r.PKID
                                      select row).FirstOrDefault();
                        if (result == null)
                        {
                            //to avoid extra one up/down sync
                            r.LastDownloadedDate = r.ModifiedDate;
                            r.LastUploadedDate = r.ModifiedDate;
                            db.ExecuteStoreCommand("SET IDENTITY_INSERT [tbZoneGroup] ON", null);
                            db.tbZoneGroups.AddObject(r);
                            db.SaveChanges();
                            db.ExecuteStoreCommand("SET IDENTITY_INSERT [tbZoneGroup] OFF", null);
                        }
                        else
                        {
                            //to avoid extra one up/down sync
                            if (result.ModifiedDate == null)
                            {
                                result.LastDownloadedDate = DateTime.Now;
                                result.LastUploadedDate = DateTime.Now;
                            }
                            result.DaysAllowed = r.DaysAllowed;
                            result.EntriesAllowed = r.EntriesAllowed;
                            result.Price = r.Price;
                            result.ZoneGroupID = r.ZoneGroupID;
                            result.ZoneGroupName = r.ZoneGroupName;
                            db.SaveChanges();
                        }
                    }
                    updatedRecords.ZoneGroupPKID = (from r in syncData.ZoneGroupTable select r.PKID).ToList<int>();
                }
                //zone
                if (syncData.ZoneTable != null && syncData.ZoneTable.Count > 0)
                {
                    foreach (tbZone r in syncData.ZoneTable)
                    {
                        var result = (from row in db.tbZones
                                      where row.PKID == r.PKID
                                      select row).FirstOrDefault();
                        if (result == null)
                        {
                            //to avoid extra one up/down sync
                            r.LastDownloadedDate = r.ModifiedDate;
                            r.LastUploadedDate = r.ModifiedDate;
                            db.ExecuteStoreCommand("SET IDENTITY_INSERT tbZone ON", null);
                            db.tbZones.AddObject(r);
                            db.SaveChanges();
                            db.ExecuteStoreCommand("SET IDENTITY_INSERT tbZone OFF", null);
                        }
                        else
                        {
                            //to avoid extra one up/down sync
                            if (result.ModifiedDate == null)
                            {
                                result.LastDownloadedDate = DateTime.Now;
                                result.LastUploadedDate = DateTime.Now;
                            }
                            result.ZoneName = r.ZoneName;
                            db.SaveChanges();
                        }
                    }
                    updatedRecords.ZonePKID = (from r in syncData.ZoneTable select r.PKID).ToList<int>();
                }
                //zone and zone group
                if (syncData.ZoneAndZoneGroupTable != null && syncData.ZoneAndZoneGroupTable.Count > 0)
                {
                    foreach (tbZoneAndZoneGroup r in syncData.ZoneAndZoneGroupTable)
                    {
                        var result = (from row in db.tbZoneAndZoneGroups
                                      where row.PKID == r.PKID
                                      select row).FirstOrDefault();
                        if (result == null)
                        {
                            //to avoid extra one up/down sync
                            r.LastDownloadedDate = r.ModifiedDate;
                            r.LastUploadedDate = r.ModifiedDate;
                            db.ExecuteStoreCommand("SET IDENTITY_INSERT tbZoneAndZoneGroup ON", null);
                            db.tbZoneAndZoneGroups.AddObject(r);
                            db.SaveChanges();
                            db.ExecuteStoreCommand("SET IDENTITY_INSERT tbZoneAndZoneGroup OFF", null);
                        }
                        else
                        {
                            //to avoid extra one up/down sync
                            if (result.ModifiedDate == null)
                            {
                                result.LastDownloadedDate = DateTime.Now;
                                result.LastUploadedDate = DateTime.Now;
                            }
                            result.ZoneGroupID = r.ZoneGroupID;
                            result.ZoneID = r.ZoneID;
                            db.SaveChanges();
                        }
                    }
                    updatedRecords.ZoneAndZoneGroupPKID = (from r in syncData.ZoneAndZoneGroupTable select r.PKID).ToList<int>();
                }
                //ticket
                if (syncData.TicketTable != null && syncData.TicketTable.Count > 0)
                {
                    foreach (tbTicket r in syncData.TicketTable)
                    {
                        var result = (from row in db.tbTickets
                                      where row.PKID == r.PKID
                                      select row).FirstOrDefault();
                        if (result == null)
                        {
                            //to avoid extra one up/down sync
                            r.LastDownloadedDate = r.ModifiedDate;
                            r.LastUploadedDate = r.ModifiedDate;
                            db.ExecuteStoreCommand("SET IDENTITY_INSERT [tbTicket] ON", null);
                            db.tbTickets.AddObject(r);
                            db.SaveChanges();
                            db.ExecuteStoreCommand("SET IDENTITY_INSERT [tbTicket] OFF", null);
                            //insert ticket log for the counter machine to use to sync ticket
                            var ticketLog = (from log in db.tbTicketLogs
                                             where log.TicketID == r.PKID
                                             select log).FirstOrDefault();
                            if (ticketLog == null)
                            {
                                tbTicketLog log = new tbTicketLog();
                                log.PKID = 0;
                                log.CounterID = 0;
                                log.CreatedDate = DateTime.Today;
                                log.TicketID = r.PKID;
                                log.TransactionID = Guid.NewGuid();
                                db.tbTicketLogs.AddObject(log);
                                db.SaveChanges();
                            }
                        }
                        else
                        {
                            //to avoid extra one up/down sync
                            if (result.ModifiedDate == null)
                            {
                                result.LastDownloadedDate = DateTime.Now;
                                result.LastUploadedDate = DateTime.Now;
                            }
                            result.ActivatedBy = r.ActivatedBy;
                            result.ActivatedDate = r.ActivatedDate;
                            result.AllowedDays = r.AllowedDays;
                            result.AllowedUsage = r.AllowedUsage;
                            result.AlreadyUsed = r.AlreadyUsed;
                            result.ExpiryDate = r.ExpiryDate;
                            result.IsActivated = r.IsActivated;
                            result.ModifiedBy = r.ModifiedBy;
                            result.ModifiedDate = r.ModifiedDate;
                            result.Price = r.Price;
                            result.TicketStatus = r.TicketStatus;
                            db.SaveChanges();
                        }
                    }
                    updatedRecords.TicketPKID = (from r in syncData.TicketTable select r.PKID).ToList<int>();
                }
                //ticket usage
                if (syncData.TicketUsageLogTable != null && syncData.TicketUsageLogTable.Count > 0)
                {
                    foreach (tbTicketUsageLog r in syncData.TicketUsageLogTable)
                    {
                        var result = (from row in db.tbTicketUsageLogs
                                      where row.PKID == r.PKID
                                      select row).FirstOrDefault();
                        if (result == null)
                        {
                            db.ExecuteStoreCommand("SET IDENTITY_INSERT tbTicketUsageLog ON", null);
                            db.tbTicketUsageLogs.AddObject(r);
                            db.SaveChanges();
                            db.ExecuteStoreCommand("SET IDENTITY_INSERT tbTicketUsageLog OFF", null);
                        }
                        else
                        {
                            //no need to modify usage, usage is creation only
                        }
                    }
                    updatedRecords.TicketUsageLogPKID = (from r in syncData.TicketUsageLogTable select r.PKID).ToList<int>();
                }
                //ticket in zone
                if (syncData.TicketInZoneTable != null && syncData.TicketInZoneTable.Count > 0)
                {
                    foreach (tbTicketInZone r in syncData.TicketInZoneTable)
                    {
                        var result = (from row in db.tbTicketInZones
                                      where row.PKID == r.PKID
                                      select row).FirstOrDefault();
                        if (result == null)
                        {
                            db.ExecuteStoreCommand("SET IDENTITY_INSERT tbTicketInZone ON", null);
                            db.tbTicketInZones.AddObject(r);
                            db.SaveChanges();
                            db.ExecuteStoreCommand("SET IDENTITY_INSERT tbTicketInZone OFF", null);
                        }
                        else
                        {
                            //no need to modify existing ticket in zone, insert only
                        }
                    }
                    updatedRecords.TicketInZonePKID = (from r in syncData.TicketInZoneTable select r.PKID).ToList<int>();
                }
            }

            return updatedRecords;
        }
    }
}