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
    public partial class TicketSetting : Form
    {
        public TicketSetting()
        {
            InitializeComponent();
        }

        enum mode
        {
            none, newMode, editMode
        }
        mode _mode;

        static bool authenticated;
        public bool _authenticated
        {
            get { return authenticated; }
            set { authenticated = true; }
        }

        void Save_Settings()
        {
            try
            {
                new ACSFCTicketSettings().InsertTicketSetting(cboTicketZoneID.Text, Convert.ToInt32(txtDayAllowed.Text), Convert.ToInt32(txtEntryAllowed.Text), Convert.ToDecimal(txtPrice.Text), DateTime.Now, 1, DateTime.Now, 1);
                MessageBox.Show("Setting defined successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SelectTicketSetting();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void SelectTicketSetting()
        {
            dgvSetting.DataSource = new ACSFCTicketSettings().SelectTicketSetting();
            dgvSetting.AutoGenerateColumns = true;

            dgvSetting.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSetting.Columns[1].HeaderText = "Zone ID";
            dgvSetting.Columns[1].Width = 80;
            dgvSetting.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvSetting.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSetting.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvSetting.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSetting.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvSetting.Columns[0].Visible = false;
            dgvSetting.Columns[4].Visible = false;
            dgvSetting.Columns[5].Visible = false;
            dgvSetting.Columns[6].Visible = false;
            dgvSetting.Columns[7].Visible = false;
        }

        void getZoneGroupID()
        {
            ACSFCZoneGroup zone=  new ACSFCZoneGroup();
            IEnumerable<Model.ZoneGroup> getRow = from row in zone.Select_ZoneGroup().AsEnumerable()
                                             select row;
            
            cboTicketZoneID.Items.Clear();
            for (int i=0; i< getRow.Count(); i++)
            {
                cboTicketZoneID.Items.Add(getRow.ElementAt(i).ZoneGroupID.ToString());
            }
            
        }

        void getZoneGroupName_ByID(string ID)
        {
            ACSFCZoneGroup zone = new ACSFCZoneGroup();
            IEnumerable<Model.ZoneGroup> getRow = from row in zone.Select_ZoneGroup().AsEnumerable()
                                             where row.ZoneGroupID.Equals(ID)
                                             select row;

          
            if (getRow.Count() > 0)
            {
                lblZoneName.Text = getRow.First().ZoneGroupName.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_mode == mode.newMode)
                {
                    new ACSFCTicketSettings().InsertTicketSetting(cboTicketZoneID.Text, Convert.ToInt32(txtDayAllowed.Text), Convert.ToInt32(txtEntryAllowed.Text), Convert.ToDecimal(txtPrice.Text), DateTime.Now, new ACSCMGlobal()._userPKID, DateTime.Now, new ACSCMGlobal()._userPKID);
                    MessageBox.Show("Setting defined successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SelectTicketSetting();
                }
                else if (_mode == mode.editMode)
                {
                    new ACSFCTicketSettings().UpdateTicketSettings(cboTicketZoneID.Text, Convert.ToInt32(txtDayAllowed.Text), Convert.ToInt32(txtEntryAllowed.Text), Convert.ToDecimal(txtPrice.Text), new ACSCMGlobal()._userPKID, DateTime.Now);
                    MessageBox.Show("Setting updated successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SelectTicketSetting();
                }
            }
            catch ( Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Saving Ticket Setting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void cboTicketZoneID_SelectedIndexChanged(object sender, EventArgs e)
        {
            getZoneGroupName_ByID(cboTicketZoneID.SelectedItem.ToString());
        }

        private void TicketSetting_Load(object sender, EventArgs e)
        {
            getZoneGroupID();
            SelectTicketSetting();
        }

        void DisplayLogin()
        {
            Login login = new Login();
            login.editLogin = true;
            login.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Width = 400;
            login.Height = 202;
            login.ControlBox = true;
            login.MinimizeBox = false;
            login.MaximizeBox = false;
            login.ShowDialog();
        }

        //void AuthorizationCheck()
        //{
        //    try
        //    {
        //        DisplayLogin();
        //        if (authenticated)
        //        {
        //            DeleteTicketSettings();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        void DeleteTicketSettings()
        {
            if (authenticated)
            {
                if (MessageBox.Show("Are you sure to delete it?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    new ACSFCTicketSettings().DeleteTicketSettings(cboTicketZoneID.Text);
                    MessageBox.Show("Deleted");
                }
            }
            else
            {
                MessageBox.Show("Sorry.You are not authorized to proceed.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayLogin();

                if (authenticated)
                {
                    if (MessageBox.Show("r u sure to delete it?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        new ACSFCTicketSettings().DeleteTicketSettings(cboTicketZoneID.Text);
                        MessageBox.Show("Deleted");

                        btnCancel.Enabled = false;
                        btnNew.Enabled = true;
                        btnUpdate.Enabled = true;
                        btnDelete.Enabled = false;
                        btnSave.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Sorry.You are not authorized to proceed.");
                }
            }
            catch ( Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Delete Ticket Setting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        void AuthorizationCheck()
        {
            DisplayLogin();
            if (authenticated)
            {
                txtDayAllowed.ReadOnly = false;
                txtEntryAllowed.ReadOnly = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _mode = mode.editMode;
                AuthorizationCheck();

                btnCancel.Enabled = true;
                btnNew.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
            }
            catch ( Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Update Ticket Setting", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            _mode = mode.newMode;
            txtDayAllowed.ReadOnly = false;
            txtEntryAllowed.ReadOnly = false;

            btnCancel.Enabled = true;
            btnNew.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
        }
    }
}
