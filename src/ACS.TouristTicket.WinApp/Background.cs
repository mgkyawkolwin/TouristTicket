using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACS.TouristTicket.WinApp
{
    public partial class Background : Form
    {
        public Background()
        {
            InitializeComponent();
        }

        private void Background_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        public void Display_Denied(bool display, string currentRole, string displayName)
        {
            lblMessage.Text = "''Sorry, '" + displayName + "' only Administrator in user role can access this page,";
            lblRole.Text = "your current role is " + currentRole + "...''";

            if (display)
                pnlMsg.Visible = true;
            else
                pnlMsg.Visible = false;
        }

        private void Background_Deactivate(object sender, EventArgs e)
        {
            pnlMsg.Visible = false;
        }
    }
}
