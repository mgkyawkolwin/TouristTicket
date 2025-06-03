using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.DataAccess;
using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.BusinessLogic
{
    public class ACSBLTicketUnused
    {
         public int Insert_TicketUnused(string serialNo, string description, Nullable<int> createdBy, Nullable<System.DateTime> createdDate, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
        {
            return new ACSDATicketUnused().Insert_TicketUnused(serialNo, description, createdBy, createdDate, modifiedBy, modifiedDate);
        }

         public int Update_TicketUnused(string serialNo, string description, Nullable<int> modifiedBy, Nullable<System.DateTime> modifiedDate)
         {
             return new ACSDATicketUnused().Update_TicketUnused(serialNo, description, modifiedBy, modifiedDate);
         }

         public int Delete_TicketDamages(string SerialNo)
         {
             return new ACSDATicketUnused().Delete_TicketDamages(SerialNo);
         }

         public List<TicketUnused> Select_TicketUnused()
         {
             return new ACSDATicketUnused().Select_TicketUnused();
         }

    }
}
