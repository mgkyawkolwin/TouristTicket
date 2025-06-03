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
    public partial class Counter : Form
    {
        public bool editLogin;

        enum processMode
        {
            none, newMode, editMode
        }
        processMode _processMode;

        string zoneGroupID;
        string zoneID;

        public Counter()
        {
            InitializeComponent();
        }

        void Load_ZoneGroup()
        {
            var filter = from row in (new ACSFCZoneGroup().Select_ZoneGroup().AsEnumerable())
                         select row;

            if (filter.Count() > 0)
            {
                cboZoneGroup.Items.Clear();

                for (int i = 0; i < filter.Count(); i++)
                {
                    cboZoneGroup.Items.Add(filter.ElementAt(i).ZoneGroupName);
                }
                cboZoneGroup.Items.Insert(0, "[Select Zone Group]");
                cboZoneGroup.SelectedIndex = 0;
            }
            else
            {
                cboZoneGroup.Items.Clear();
                cboZoneGroup.Text = "No Zone Group Found";
            }
        }

        void FilterZone_ByZoneGroup(string ZoneGroup)
        {
            try
            {
                var filter = from row in (new ACSFCZone().Select_ZoneAndZoneGroup().AsEnumerable())
                             where row.ZoneGroupName.Equals(ZoneGroup)
                             select row;
                if (filter.Count() > 0)
                {
                    zoneGroupID = filter.FirstOrDefault().ZoneGroupID;

                    cboZone.Items.Clear();

                    for (int i = 0; i < filter.Count(); i++)
                    {
                        cboZone.Items.Add(filter.ElementAt(i).ZoneName);
                    }
                    cboZone.Items.Insert(0, "[Select Zone]");
                    cboZone.SelectedIndex = 0;
                }
                else
                {
                    cboZone.Items.Clear();
                    cboZone.Text = "No Zone Found";
                }
            }
            catch
            {

            }
        }

        void Load_CounterDetail()
        {
            dgvCounter.AutoGenerateColumns = false;
            dgvCounter.DataSource = new ACSFCCounter().Select_CounterDetail();
        }

        private void Counter_Load(object sender, EventArgs e)
        {
            Load_ZoneGroup();
            Load_CounterDetail();
        }

        private void cboZoneGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterZone_ByZoneGroup(cboZoneGroup.Text);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cboZoneGroup.Enabled = true;
            cboZone.Enabled = true;
            txtCounterID.Text = "";
            btnNew.Enabled = false;
            btnCancel.Enabled = true;
            Load_ZoneGroup();
            cboZoneGroup.SelectedIndex = 0;
        }

        private void cboZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var filter = from row in (new ACSFCZone().Select_ZoneAndZoneGroup().AsEnumerable())
                             where row.ZoneName.StartsWith(cboZone.Text)
                             select row;

                zoneID = filter.FirstOrDefault().ZoneID;
                btnGenerate.Enabled = true;
            }
            catch
            {

            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            cboZoneGroup.Enabled = false;
            cboZone.Enabled = false;
            btnGenerate.Enabled = false;
            btnSave.Enabled = true;
            txtCounterID.Text = zoneGroupID + zoneID + new ACSFCCounter().SelectNewCounterID().ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cboZoneGroup.Enabled = true;
            cboZone.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Insert new counter ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    new ACSFCCounter().Insert_Counter(Convert.ToInt32(txtCounterID.Text), Convert.ToInt32(zoneID), new ACSCMGlobal()._userPKID, DateTime.Now);
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    btnGenerate.Enabled = false;
                    Load_CounterDetail();
                    MessageBox.Show("New Counter ID Created !\nCounterID: [" + txtCounterID.Text + "]\nZone: [" + cboZone.Text + "]", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

            }
        }

        int PKID;
        private void dgvCounter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            PKID = Convert.ToInt32(dgvCounter.CurrentRow.Cells[0].Value.ToString());
            txtCounterID.Text = dgvCounter.CurrentRow.Cells[1].Value.ToString();
            cboZone.Text = dgvCounter.CurrentRow.Cells[2].Value.ToString();
            cboZoneGroup.Text = dgvCounter.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (MessageBox.Show("Delete counter ?\nCounterID: " + txtCounterID.Text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            //    {
            //        new ACSFCCounter().Delete_Counter(Convert.ToInt32(txtCounterID.Text));
            //    }
            //}
            //catch (Exception ex)
            //{

            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }
    }
}
