using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACS.TouristTicket.WinApp
{
   public  class FormFactory
    {
       Background background;
       SingleTicketEntry singleEntry;
       MultipleTicketEntry batchEntry;
       TicketList ticketList;
       TicketList ticketDetailList;
       TicketSetting ticketSetting;
       UserList listUser;
       User userManagement;
       Zone zone;
       ZoneGroup zoneGroup;
       ZoneSearch zoneSearch;
       MyAccount myAccount;
       TicketUnUsed ticketUnused;
       Import_Data importData;
       ExportData exportData;
       Counter counter;
       UnusedTicketList unusedTicketList;
       PrintingCode printingCode;
       CheckPrintingCode checkCode;
       About about;

       public Background CreateBackground()
       {
           if (background == null || background.IsDisposed)
               background = new Background();
           return background;
       }

       public SingleTicketEntry CreateSingleEntry()
       {
           if (singleEntry == null || singleEntry.IsDisposed)
               singleEntry = new SingleTicketEntry();
           return singleEntry;
       }

       public MultipleTicketEntry CreateBatchEntry()
       {
           if (batchEntry == null || batchEntry.IsDisposed)
               batchEntry = new MultipleTicketEntry();
           return batchEntry;
       }

       public TicketUnUsed CreateTicketUnused()
       {
           if (ticketUnused == null || ticketUnused.IsDisposed)
               ticketUnused = new TicketUnUsed();
           return ticketUnused;
       }

       public TicketList CreateTicketList()
       {
           if (ticketList == null || ticketList.IsDisposed)
               ticketList = new TicketList();
           return ticketList;
       }

       public TicketSetting CreateTicketSetting()
       {
           if (ticketSetting == null || ticketSetting.IsDisposed)
               ticketSetting = new TicketSetting();
           return ticketSetting;
       }

       public User CreateUser()
       {
           if (userManagement == null || userManagement.IsDisposed)
               userManagement = new User();
           return userManagement;
       }

       public Zone CreateZone()
       {
           if (zone == null || zone.IsDisposed)
               zone = new Zone();
           return zone;
       }

       public ZoneGroup CreateZoneGroup()
       {
           if (zoneGroup == null || zoneGroup.IsDisposed)
               zoneGroup = new ZoneGroup();
           return zoneGroup;
       }

       public ZoneSearch CreateZoneSearch()
       {
           if (zoneSearch == null || zoneSearch.IsDisposed)
               zoneSearch = new ZoneSearch();
           return zoneSearch;
       }

       public MyAccount CreateMyAccount()
       {
           if (myAccount == null || myAccount.IsDisposed)
               myAccount = new MyAccount();
           return myAccount;
       }

       public UserList ListUser()
       {
           if (listUser == null || listUser.IsDisposed)
               listUser = new UserList();
           return listUser;
       }

       public TicketList ListTicketDetail()
       {
           if (ticketDetailList == null || ticketDetailList.IsDisposed)
               ticketDetailList = new TicketList();
           return ticketDetailList;
       }

       public Import_Data CreateImportData()
       {
           if (importData == null || importData.IsDisposed)
               importData = new Import_Data();
           return importData;
       }

       public ExportData CreateExportData()
       {
           if (exportData == null || exportData.IsDisposed)
               exportData = new ExportData();
           return exportData;
       }

       public Counter CreateCounter()
       {
           if (counter == null || counter.IsDisposed)
               counter = new Counter();
           return counter;
       }

       public UnusedTicketList CreateUnusedTicketList()
       {
           if (unusedTicketList == null || unusedTicketList.IsDisposed)
               unusedTicketList = new UnusedTicketList();
           return unusedTicketList;
       }

       public PrintingCode CreatePrintingCode()
       {
           if (printingCode == null || printingCode.IsDisposed)
               printingCode = new PrintingCode();
           return printingCode;
       }

       public CheckPrintingCode CreateCheckCode()
       {
           if (checkCode == null || checkCode.IsDisposed)
               checkCode = new CheckPrintingCode();
           return checkCode;
       }

       public About CreateAbout()
       {
           if (about == null || about.IsDisposed)
               about = new About();
           return about;
       }
    }
}
