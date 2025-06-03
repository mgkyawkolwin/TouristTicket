using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ACS.TouristTicket.Common;

namespace ACS.TouristTicket.WinApp
{
    public partial class Main : Form
    {
        FormFactory formFactory = new FormFactory();
        
        public Main()
        {
            InitializeComponent();
        }

        static bool authenticated;
        public bool _authenticated
        {
            get { return authenticated; }
            set { authenticated = value; }
        }

        static string userID;
        public string _userID
        {
            get { return userID; }
            set { userID = value; }
        }

        static string time;
        public string _time
        {
            get { return time; }
            set { time = value; }
        }

        void LoggingInfo(string userId, string time)
        {
            tslUserID.Text = userId;
            tslLoggedInTime.Text = time;

            tsUserInfo.Visible = true;
        }

        void MenuEnabled(bool value)
        {
                ticketLimitationInZoneGroupToolStripMenuItem.Enabled = value;
                zoneManagementToolStripMenuItem.Enabled = value;
                userManagementToolStripMenuItem.Enabled = value;
                settingsToolStripMenuItem.Enabled = value;
        }

        void MenuState(bool state)
        {
            tvManu.Visible = state;

            entryToolStripMenuItem.Enabled = state;
            zoneManagementToolStripMenuItem.Enabled = state;
            userManagementToolStripMenuItem.Enabled = state;
            settingsToolStripMenuItem.Enabled = state;
        }

        private void Main_Load(object sender, EventArgs e)
        {

            //start sync
            AdminDataSync sync = new AdminDataSync();
            sync.SyncProgressChanged = new ProgressChangedEventHandler(SyncProgressChanged);
            sync.Sync();

            tvManu.Visible = false;
            tsUserInfo.Visible = false;

            MdiNavigator.AssignMdiParent(this);
            Background background = formFactory.CreateBackground();
            background.MdiParent = this;
            background.Show();

            Login login = new Login();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.ShowDialog();

            if (!authenticated)
            {
                logInToolStripMenuItem.Enabled = true;
                logOutToolStripMenuItem.Enabled = false;

                MenuState(false);
            }
            else
            {
                logInToolStripMenuItem.Enabled = false;
                logOutToolStripMenuItem.Enabled = true;

                MenuState(true);
            }
        }

        void SyncProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            SyncInfo info = e.UserState as SyncInfo;
            if (info.IsConnected)
            {
                tslConnectionStatus.Text = "Connected";
                tslConnectionStatus.BackColor = Color.Green;
            }
            else
            {
                tslConnectionStatus.Text = "Disconnected";
                tslConnectionStatus.BackColor = Color.Red;
            }
            if (info.LastDownloadedDate != null)
                tslLastDownloadedDate.Text = info.LastDownloadedDate.Value.ToString("dd MMM yyyy  HH:mm");
            if (info.LastUploadedDate != null)
                tslLastUploadedDate.Text = info.LastUploadedDate.Value.ToString("dd MMM yyyy  HH:mm");

            tslStatus.Text = info.Status;
        }

        private void singleTicketEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingleTicketEntry frmTicketEntry = new SingleTicketEntry();
            MdiNavigator.AssignMdiChild(frmTicketEntry);
            MdiNavigator.ShowMdiChild(frmTicketEntry);
        }

        private void multipleTicketEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MultipleTicketEntry frmMultipleTicket = new MultipleTicketEntry();
            MdiNavigator.AssignMdiChild(frmMultipleTicket);
            MdiNavigator.ShowMdiChild(frmMultipleTicket);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            if (authenticated)
            {
                logInToolStripMenuItem.Enabled = false;
                logOutToolStripMenuItem.Enabled = true;
               
                MenuState(true);

                LoggingInfo(userID, time);

                if (!(new ACSCMGlobal()._fromEdit))
                    tvManu.CollapseAll();

                new ACSCMGlobal()._fromEdit = true;
            }
        }

        private void tvManu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Text.ToLower())
            {
                case "single entry":
                    SingleTicketEntry singleEntry = formFactory.CreateSingleEntry();
                    MdiNavigator.AssignMdiChild(singleEntry);
                    MdiNavigator.ShowMdiChild(singleEntry);
                    break;

                case "batch entry":
                    MultipleTicketEntry batchEntry = formFactory.CreateBatchEntry();
                    MdiNavigator.AssignMdiChild(batchEntry);
                    MdiNavigator.ShowMdiChild(batchEntry);
                    break;

                case "unused ticket":
                    TicketUnUsed ticketUnused = formFactory.CreateTicketUnused();
                    MdiNavigator.AssignMdiChild(ticketUnused);
                    MdiNavigator.ShowMdiChild(ticketUnused);
                    break;

                case "ticket report":
                    TicketList ticketList = formFactory.CreateTicketList();
                    MdiNavigator.AssignMdiChild(ticketList);
                    MdiNavigator.ShowMdiChild(ticketList);
                    break;

                case "printing approved code":
                    if (new ACSCMGlobal()._userType.ToLower() == "user")
                    {
                        Background bg = formFactory.CreateBackground();
                        bg.Display_Denied(true, "User", new ACSCMGlobal()._displayName);
                        MdiNavigator.AssignMdiChild(bg);
                        MdiNavigator.ShowMdiChild(bg);
                        return;
                    }
                    else
                    {
                        PrintingCode printingCode = formFactory.CreatePrintingCode();
                        MdiNavigator.AssignMdiChild(printingCode);
                        MdiNavigator.ShowMdiChild(printingCode);
                    }
                    break;

                case "zone":
                    Zone zone = formFactory.CreateZone();
                    MdiNavigator.AssignMdiChild(zone);
                    MdiNavigator.ShowMdiChild(zone);
                    break;

                case "zone group":
                    ZoneGroup zoneGroup = formFactory.CreateZoneGroup();
                    MdiNavigator.AssignMdiChild(zoneGroup);
                    MdiNavigator.ShowMdiChild(zoneGroup);
                    break;

                case "zone report":
                    ZoneSearch zoneSearch = formFactory.CreateZoneSearch();
                    MdiNavigator.AssignMdiChild(zoneSearch);
                    MdiNavigator.ShowMdiChild(zoneSearch);
                    break;

                case "counter":
                    Counter counter = formFactory.CreateCounter();
                    MdiNavigator.AssignMdiChild(counter);
                    MdiNavigator.ShowMdiChild(counter);
                    break;

                case "user":
                    if (new ACSCMGlobal()._userType.ToLower() == "user")
                    {
                        Background bg = formFactory.CreateBackground();
                        bg.Display_Denied(true, "User", new ACSCMGlobal()._displayName);
                        MdiNavigator.AssignMdiChild(bg);
                        MdiNavigator.ShowMdiChild(bg);
                        return;
                    }
                    else
                    {
                        User user = formFactory.CreateUser();
                        MdiNavigator.AssignMdiChild(user);
                        MdiNavigator.ShowMdiChild(user);
                    }
                    break;

                case "my account":
                    MyAccount myAccount = formFactory.CreateMyAccount();
                    myAccount.ShowPassword(new ACSCMGlobal()._userID
                        , new ACSCMGlobal()._displayName
                        , new ACSCMGlobal()._password);
                    MdiNavigator.AssignMdiChild(myAccount);
                    MdiNavigator.ShowMdiChild(myAccount);
                    break;

                case "ticket detail list":
                    TicketList ticketDetailList = formFactory.ListTicketDetail();
                    MdiNavigator.AssignMdiChild(ticketDetailList);
                    MdiNavigator.ShowMdiChild(ticketDetailList);
                    break;

                case "user report":
                    UserList listUser = formFactory.ListUser();
                    MdiNavigator.AssignMdiChild(listUser);
                    MdiNavigator.ShowMdiChild(listUser);
                    break;

                case "import data":
                    Import_Data importData = formFactory.CreateImportData();
                    MdiNavigator.AssignMdiChild(importData);
                    MdiNavigator.ShowMdiChild(importData);
                    break;

                case "export data":
                    ExportData exportData = formFactory.CreateExportData();
                    MdiNavigator.AssignMdiChild(exportData);
                    MdiNavigator.ShowMdiChild(exportData);
                    break;

                case "about ticket admin":
                    About about = formFactory.CreateAbout();
                    MdiNavigator.AssignMdiChild(about);
                    MdiNavigator.ShowMdiChild(about);
                    break;

                default:
                    break;
            }
        }

        void DisposedMdiChild()
        {
            foreach (Form f in this.MdiChildren)
            {
                //if (f.GetType().Name.ToLower() != "background")
                //{
                    f.Close();
                    f.Dispose();
                //}
            }

            Background background = formFactory.CreateBackground();
            background.MdiParent = this;
            background.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuState(false);

            logInToolStripMenuItem.Enabled = true;
            logOutToolStripMenuItem.Enabled = false;
            tsUserInfo.Visible = false;

            DisposedMdiChild();

            Login login = new Login();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.ShowDialog();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.ShowDialog();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tvManu_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            //if (new ACSCMGlobal()._isAdmin == false)
            //    tvManu.Nodes[1].

        }

        private void tvManu_Click(object sender, EventArgs e)
        {

        }

        private void tvManu_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
