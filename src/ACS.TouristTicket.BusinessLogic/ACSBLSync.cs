using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.TouristTicket.DataAccess;
using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.BusinessLogic
{
    public class ACSBLSync
    {
        public ACSSyncData SyncData(ACSSyncData syncData)
        {
            return new ACSDASync().SyncData(syncData);
        }
    }
}
