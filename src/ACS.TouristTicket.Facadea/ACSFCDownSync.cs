using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.TouristTicket.Model;
using ACS.TouristTicket.BusinessLogic;

namespace ACS.TouristTicket.Facade
{
    public class ACSFCDownSync
    {
        public ACSSyncData GetDownSyncData()
        {
            return new ACSBLDownSync().GetDownSyncData();
        }

        public void UpdateLastDownSyncDate(ACSSyncData syncData)
        {
            new ACSBLDownSync().UpdateLastDownSyncDate(syncData);
        }
    }
}
