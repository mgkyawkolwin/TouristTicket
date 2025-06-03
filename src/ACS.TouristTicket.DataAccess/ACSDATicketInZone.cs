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
    public class ACSDATicketInZone
    {
        public int Insert_TicketInZone(string ticketID,string zoneID,Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        { 
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                ObjectParameter PKID = new ObjectParameter("PKID", typeof(int));
                ObjectParameter errorCode = new ObjectParameter("ErrorCode", typeof(string));
                ObjectParameter errorMsg = new ObjectParameter("ErrorCode", typeof(string));
                int returnValue = db.InsertTicketInZone(PKID, ticketID, zoneID, createdBy, createdDate, modifiedBy, modifiedDate, errorCode, errorMsg).FirstOrDefault() ?? 0;
                if (errorCode.Value.ToString() != "0")
                    throw new Exception("ErrorCode = " + errorCode.Value.ToString() + "; ErrorMsg = " + errorMsg.Value.ToString());
                return returnValue;
            }
        }
        public List<TicketInZone> Select_TicketInZone()
        {
            using (TouristTicketContainer db = new TouristTicketContainer())
            {
                db.ContextOptions.LazyLoadingEnabled = false;
                db.ContextOptions.ProxyCreationEnabled = false;
                return db.SelectTicketInZone().ToList<TicketInZone>();
            }
        }
    }
}
