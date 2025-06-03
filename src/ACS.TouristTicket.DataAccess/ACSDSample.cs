using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.DataAccess
{
    public class ACSDSample
    {
        public List<SampleObject> GetSampleData()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                return db.SelectSample().ToList<SampleObject>();
            }
        }

        
        public int InsertSampleData(string sampleData)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                ObjectParameter pPKID = new ObjectParameter("PKID", typeof(int));
                ObjectParameter pErrorCode = new ObjectParameter("ErrorCode", typeof(int));
                db.InsertSample(pPKID, sampleData, pErrorCode);          
                
            }
            return 0;
        }

        public int UpdateSampleData(int pkid, string sampleData)
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                ObjectParameter pErrorCode = new ObjectParameter("ErrorCode", typeof(int));
                db.UpdateSample(pkid, sampleData, pErrorCode);

            }
            return 0;
        }
    }
}
