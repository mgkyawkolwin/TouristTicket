using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.Model;
using ACS.TouristTicket.DataAccess;

namespace ACS.TouristTicket.BusinessLogic
{
    public class ACSBSample
    {
        public List<SampleObject> GetSampleData()
        {
            return new ACSDSample().GetSampleData();
        }

        public int InsertSampleData(string sampleData)
        {
            return new ACSDSample().InsertSampleData(sampleData);
        }

        public int UpdateSampleData(int pkid, string sampleData)
        {
            return new ACSDSample().UpdateSampleData(pkid, sampleData);
        }

        public int UpdateSampleData(List<SampleObject> sampleObjects)
        {
            ACSDSample sample = new ACSDSample();
            foreach (SampleObject obj in sampleObjects)
            {
                sample.UpdateSampleData(obj.PKID, obj.SampleColumn);
            }
            return 0;
        }
    }
}
