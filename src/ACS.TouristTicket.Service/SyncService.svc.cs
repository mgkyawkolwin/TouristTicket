using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using ACS.TouristTicket.Facade;
using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SyncService" in code, svc and config file together.
    public class SyncService : ISyncService
    {
        public ACSSyncData GetUpSyncData()
        {
            return new ACSFCUpSync().GetUpSyncData();
        }

        public void UpdateLastUpSyncDate(ACSSyncData syncData)
        {
            new ACSFCUpSync().UpdateLastUpSyncDate(syncData);
        }

        public ACSSyncData GetDownSyncData()
        {
            return new ACSFCDownSync().GetDownSyncData();
        }

        public void UpdateLastDownSyncDate(ACSSyncData syncData)
        {
            new ACSFCDownSync().UpdateLastDownSyncDate(syncData);
        }

        public ACSSyncData SyncData(ACSSyncData syncData)
        {
            return new ACSFCSync().SyncData(syncData);
        }
    }
}
