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
        public Main()
        {
            InitializeComponent();
        }


        void MenuEnabled(bool value)
        {
                ticketLimitationInZoneGroupToolStripMenuItem.Enabled = value;
                zoneManagementToolStripMenuItem.Enabled = value;
                userManagementToolStripMenuItem.Enabled = value;
                settingsToolStripMenuItem.Enabled = value;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MdiNavigator.AssignMdiParent(this);
            Login login = new Login();
            MdiNavigator.AssignMdiChild(login);
            MdiNavigator.ShowMdiChild(login);        
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

        private void Main_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void Main_Activated(object sender, EventArgs e)
        {

        }
    }
}
