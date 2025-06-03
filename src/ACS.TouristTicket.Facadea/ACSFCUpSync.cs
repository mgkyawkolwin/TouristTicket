using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.TouristTicket.Model;
using ACS.TouristTicket.BusinessLogic;

namespace ACS.TouristTicket.Facade
{
    public class ACSFCUpSync
    {
        public ACSSyncData GetUpSyncData()
        {
            return new ACSBLUpSync().GetUpSyncData();
        }

        public void UpdateLastUpSyncDate(ACSSyncData syncData)
        {
            new ACSBLUpSync().UpdateLastUpSyncDate(syncData);
        }
    }
}
