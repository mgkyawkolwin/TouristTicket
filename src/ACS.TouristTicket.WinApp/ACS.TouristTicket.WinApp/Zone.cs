using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.Facade;
using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.WinApp
{
    public partial class Zone : Form
    {
        public Zone()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtZoneID.Text = "";
            txtZoneName.Text = "";
            txtZoneName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           if (new ACSFCZone().Insert_NewZone(txtZoneID.Text, txtZoneName.Text, 1, DateTime.Now, 1, DateTime.Now) > 0);
                MessageBox.Show("New Zone Saved");

                Load_ZoneList();
        }

        void Load_ZoneList()
        {
            try
            {
                dgvZone.DataSource = new ACSFCZone().Select_ZoneList();
            }
            catch (Exception ex)
            {

            }
        }

        private void Zone_Load(object sender, EventArgs e)
        {
            Load_ZoneList();
        }
    }
}
