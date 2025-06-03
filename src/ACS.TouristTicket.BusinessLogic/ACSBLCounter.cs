using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.BusinessLogic;
using ACS.TouristTicket.DataAccess;
using ACS.TouristTicket.Model;
namespace ACS.TouristTicket.BusinessLogic
{
    public class ACSBLCounter
    {
        public List<Counter> Select_Counter()
        {
            return new ACSDACounter().Select_Counter();
        }

        public List<CounterAndZone> Select_CounterDetail()
        {
            return new ACSDACounter().Select_CounterDetail();
        }

        public int Insert_Counter(int counterID, int zoneID, Nullable<int> createdBy, Nullable<System.DateTime> createdDate)
        {
            return new ACSDACounter().Insert_Counter(counterID, zoneID, createdBy, createdDate);
        }

        public int Update_Counter(int PKID, int counterID, int zoneID)
        {
            return new ACSDACounter().Update_Counter(PKID, counterID, zoneID);
        }

        public int Delete_Counter(int CounterID)
        {
            return new ACSDACounter().Delete_Counter(CounterID);
        }

        public int SelectNewCounterID()
        {
            return new ACSDACounter().SelectNewCounterID();
        }
    }
}
