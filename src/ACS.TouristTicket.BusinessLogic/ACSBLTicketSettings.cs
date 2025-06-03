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
    public class ACSBLTicketSettings
    {
        public int DeleteTicketSettings(string TicketZoneID)
        {
            return new ACSDATicketSettings().DeleteTicketSettings(TicketZoneID);
        }

        public int InsertTicketSetting(string TicketZoneID, int DaysAllowed, int EntryAllowed, decimal Price, Nullable<DateTime> CreatedDate, Nullable<int> CreatedBy, Nullable<DateTime> ModifiedDate, Nullable<int> ModifiedBy)
        {
            return new ACSDATicketSettings().InsertTicketSettings(TicketZoneID, DaysAllowed, EntryAllowed, Price, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate);
        }

        public int UpdateTicketSettings(string ticketzoneID, int DaysAllowed, int EntryAllowed, decimal Price, Nullable<int> modifiedBy, Nullable<DateTime> ModifiedDate)
        {
            return new ACSDATicketSettings().UpdaTeticketSettings(ticketzoneID, DaysAllowed, EntryAllowed, Price, modifiedBy, ModifiedDate);
        }

        public List<TicketSetting> SelectTicketSetting()
        {
            return new ACSDATicketSettings().SelectTicketSetting();
        }
    }

    
}
