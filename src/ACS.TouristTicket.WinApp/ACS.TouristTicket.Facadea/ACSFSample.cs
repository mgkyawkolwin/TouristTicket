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
    public class ACSFSample
    {
        public List<SampleObject> GetSampleData()
        {
            try
            {
                //log transaction to database
                return new ACSBSample().GetSampleData();
            }
            catch (Exception ex)
            {
                //log exception to database
                return null;
            }
            
        }

        public int InsertSampleData(string sampleData)
        {
            try
            {
                //log transaction to database
                return new ACSBSample().InsertSampleData(sampleData);
            }
            catch (Exception ex)
            {
                //log exception to database
                return 0;
            }

        }

        public int UpdateSampleData(int pkid, string sampleData)
        {
            return new ACSBSample().UpdateSampleData(pkid, sampleData);
        }

        public int UpdateSampleData(List<SampleObject> sampleObjects)
        {
            return new ACSBSample().UpdateSampleData(sampleObjects);
        }
    }
}
