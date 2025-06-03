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
    public class ACSFCTicketUnused
    {
        public int Insert_TicketUnused(string serialNo, string description, Nullable<int> createdBy, Nullable<System.DateTime> createdDate, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        {
            return new ACSBLTicketUnused().Insert_TicketUnused(serialNo, description, createdBy, createdDate, modifiedBy, modifiedDate);
        }

        public int Update_TicketUnused(string serialNo, string description, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        {
            return new ACSBLTicketUnused().Update_TicketUnused(serialNo, description, modifiedBy, modifiedDate);
        }

        public int Delete_TicketDamages(string SerialNo)
        {
            return new ACSBLTicketUnused().Delete_TicketDamages(SerialNo);
        }

        public List<TicketUnused> Select_TicketDamages()
        {
            return new ACSBLTicketUnused().Select_TicketUnused();
        }
    }
}
