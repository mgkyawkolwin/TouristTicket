using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.Model;
using ACS.TouristTicket.BusinessLogic;

namespace ACS.TouristTicket.Facade
{
    public class ACSFCCounter
    {
        public List<Counter> Select_Counter()
        {
            return new ACSBLCounter().Select_Counter();
        }

        public List<CounterAndZone> Select_CounterDetail()
        {
            return new ACSBLCounter().Select_CounterDetail();
        }

        public int Insert_Counter(int counterID, int zoneID, Nullable<int> createdBy, Nullable<System.DateTime> createdDate)
        {
            return new ACSBLCounter().Insert_Counter(counterID, zoneID, createdBy, createdDate);
        }

        public int Update_Counter(int PKID, int counterID, int zoneID)
        {
            return new ACSBLCounter().Update_Counter(PKID, counterID, zoneID);
        }

        public int Delete_Counter(int CounterID)
        {
            return new ACSBLCounter().Delete_Counter(CounterID);
        }

        public int SelectNewCounterID()
        {
            return new ACSBLCounter().SelectNewCounterID();
        }
    }
}
