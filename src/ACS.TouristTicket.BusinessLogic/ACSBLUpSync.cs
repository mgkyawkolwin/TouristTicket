using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.TouristTicket.Model;
using ACS.TouristTicket.DataAccess;

namespace ACS.TouristTicket.BusinessLogic
{
    public class ACSBLUpSync
    {
        public ACSSyncData GetUpSyncData()
        {
            return new ACSDAUpSync().GetUpSyncData();
        }

        public void UpdateLastUpSyncDate(ACSSyncData syncData)
        {
            new ACSDAUpSync().UpdateLastUpSyncDate(syncData);
        }
    }
}
