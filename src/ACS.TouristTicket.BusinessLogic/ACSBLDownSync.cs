using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.TouristTicket.Model;
using ACS.TouristTicket.DataAccess;

namespace ACS.TouristTicket.BusinessLogic
{
    public class ACSBLDownSync
    {
        public ACSSyncData GetDownSyncData()
        {
            return new ACSDADownSync().GetDownSyncData();
        }

        public void UpdateLastDownSyncDate(ACSSyncData syncData)
        {
            new ACSDADownSync().UpdateLastDownSyncDate(syncData);
        }
    }
}
