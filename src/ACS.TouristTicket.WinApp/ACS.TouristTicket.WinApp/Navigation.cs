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
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void btnCheckInTicket_Click(object sender, EventArgs e)
        {
            TicketCheckIn frmTicketCheckIn = new TicketCheckIn();
            MdiNavigator.AssignMdiChild(frmTicketCheckIn);
            MdiNavigator.ShowMdiChild(frmTicketCheckIn);
        }

        private void btnTicketActivation_Click(object sender, EventArgs e)
        {
            ActivateTicket frmActivateTicket = new ActivateTicket();
            MdiNavigator.AssignMdiChild(frmActivateTicket);
            MdiNavigator.ShowMdiChild(frmActivateTicket);
        }

        private void btnRoleManagement_Click(object sender, EventArgs e)
        {
            Role frmRole = new Role();
            MdiNavigator.AssignMdiChild(frmRole);
            MdiNavigator.ShowMdiChild(frmRole);
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            User frmUser = new User();
            MdiNavigator.AssignMdiChild(frmUser);
            MdiNavigator.ShowMdiChild(frmUser);
        }

        private void btnSystemSetting_Click(object sender, EventArgs e)
        {
            Setting frmSetting = new Setting();
            MdiNavigator.AssignMdiChild(frmSetting);
            MdiNavigator.ShowMdiChild(frmSetting);

        }

        void CreateZone()
        {
            Zone frmZone = new Zone();
            MdiNavigator.AssignMdiChild(frmZone);
            MdiNavigator.ShowMdiChild(frmZone);
        }

        void NewTicketEntry()
        {
            SingleTicketEntry frmTicketEntry = new SingleTicketEntry();
            MdiNavigator.AssignMdiChild(frmTicketEntry);
            MdiNavigator.ShowMdiChild(frmTicketEntry);
        }

        void MultipleTicketEntry()
        {
            MultipleTicketEntry frmMultipleTicket = new MultipleTicketEntry();
            MdiNavigator.AssignMdiChild(frmMultipleTicket);
            MdiNavigator.ShowMdiChild(frmMultipleTicket);
        }

        void ActivateTicket()
        {
            ActivateTicket frmActivateTicket = new ActivateTicket();
            MdiNavigator.AssignMdiChild(frmActivateTicket);
            MdiNavigator.ShowMdiChild(frmActivateTicket);
        }

        private void lblTicketActivate_Click(object sender, EventArgs e)
        {
            ActivateTicket();
        }

        private void pbTicketActivate_Click(object sender, EventArgs e)
        {
            ActivateTicket();
        }

        void CreateUser()
        {
            User frmUser = new User();
            MdiNavigator.AssignMdiChild(frmUser);
            MdiNavigator.ShowMdiChild(frmUser);
        }

        private void pbUser_Click(object sender, EventArgs e)
        {
            CreateUser();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            CreateUser();
        }

        void CreateSettings()
        {
            Setting frmSetting = new Setting();
            MdiNavigator.AssignMdiChild(frmSetting);
            MdiNavigator.ShowMdiChild(frmSetting);
        }

        private void pbSettings_Click(object sender, EventArgs e)
        {
            CreateSettings();
        }

        private void lblSettings_Click(object sender, EventArgs e)
        {
            CreateSettings();
        }

         #region "MouseMove"

        void MouseMove(PictureBox pb)
        {
            pb.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbReport_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(pbReport);
        }

        private void pbUser_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(pbUser);
        }

        private void pbEntry_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(pbEntry);
        }

        private void pbTicketActivate_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(pbTicketActivate);
        }

        private void pbUserAccessReport_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(pbUserAccessReport);
        }

         private void pbSettings_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove(pbSettings);
        }

         private void pbExport_MouseMove(object sender, MouseEventArgs e)
         {
             MouseMove(pbExport);
         }

         private void pbImport_MouseMove(object sender, MouseEventArgs e)
         {
             MouseMove(pbImport);
         }

        #endregion

         #region "MouseLeave"

         void MouseLeave(PictureBox pb)
         {
             pb.BorderStyle = BorderStyle.None;
         }

         private void pbUser_MouseLeave(object sender, EventArgs e)
         {
             MouseLeave(pbUser);
         }

         private void pbEntry_MouseLeave(object sender, EventArgs e)
         {
             MouseLeave(pbEntry);
         }

         private void pbSettings_MouseLeave(object sender, EventArgs e)
         {
             MouseLeave(pbSettings);
         }

         private void pbExport_MouseLeave(object sender, EventArgs e)
         {
             MouseLeave(pbExport);
         }

         private void pbImport_MouseLeave(object sender, EventArgs e)
         {
             MouseLeave(pbImport);
         }

         private void pbTicketActivate_MouseLeave(object sender, EventArgs e)
         {
             MouseLeave(pbTicketActivate);
         }

         private void pbReport_MouseLeave(object sender, EventArgs e)
         {
             MouseLeave(pbReport);
         }

         private void pbUserAccessReport_MouseLeave(object sender, EventArgs e)
         {
             MouseLeave(pbUserAccessReport);
         }

         #endregion

         private void tsmiClose_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void pbEntry_Click(object sender, EventArgs e)
         {
             NewTicketEntry();
         }

         private void lblEntry_Click(object sender, EventArgs e)
         {
             NewTicketEntry();
         }

         private void button1_Click(object sender, EventArgs e)
         {
            
         }

         private void pbZone_Click(object sender, EventArgs e)
         {
             CreateZone();
         }

         private void lblZone_Click(object sender, EventArgs e)
         {
             CreateZone();
         }

         private void pbMultiple_Click(object sender, EventArgs e)
         {
             MultipleTicketEntry();
         }

         private void Navigation_Load(object sender, EventArgs e)
         {
             new ACSCMGlobal().AccessGranted = true;
         }
    }
}
