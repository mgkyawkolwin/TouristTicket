using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.TouristTicket.Model;
using ACS.TouristTicket.BusinessLogic;

namespace ACS.TouristTicket.Facade
{
    public class ACSFCSync
    {
        public ACSSyncData SyncData(ACSSyncData syncData)
        {
            return new ACSBLSync().SyncData(syncData);
        }
    }
}
