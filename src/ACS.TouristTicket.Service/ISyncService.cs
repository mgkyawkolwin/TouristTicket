using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using ACS.TouristTicket.Model;
using ACS.TouristTicket.Facade;

namespace ACS.TouristTicket.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISyncService" in both code and config file together.
    [ServiceContract]
    public interface ISyncService
    {
        [OperationContract()]
        ACSSyncData GetUpSyncData();

        [OperationContract()]
        void UpdateLastUpSyncDate(ACSSyncData syncData);

        [OperationContract()]
        ACSSyncData GetDownSyncData();

        [OperationContract()]
        void UpdateLastDownSyncDate(ACSSyncData syncData);

        [OperationContract()]
        ACSSyncData SyncData(ACSSyncData syncData);
    }
}
