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

        public bool editLogin;

        enum processMode
        {
            none, newMode, editMode
        }
        processMode _processMode;

        private void btnNew_Click(object sender, EventArgs e)
        {
           

            _processMode = processMode.newMode;
            cboGroup.Enabled = true;
            txtZoneID.Enabled = true;
            txtZoneName.Enabled = true;
            txtAddress.Enabled = true;
            txtPhone.Enabled = true;
            txtIncharge.Enabled = true;

            txtZoneID.Text = "";
            txtZoneName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
            txtIncharge.Text = "";

            btnCancel.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnNew.Enabled = false;
            btnSave.Enabled = true;

            cboGroup.SelectedIndex = 0;
            cboGroup.Focus();
        }

        ErrorProvider err = new ErrorProvider();
        bool ZoneIDExisted(string ZoneID)
        {
            var getRow = from row in (new ACSFCZone().Select_ZoneList().AsEnumerable())
                         where row.ZoneID.Equals(ZoneID)
                         select row;

            if (getRow.Count() > 0)
            {
                err.SetError(txtZoneID, "Zone ID already existed for " + cboGroup.Text);
                return true;
            }
            else
            {
                err.Clear();
                return false;
            }
        }

        bool ZoneNameExisted(string Zone)
        {
            var getRow = from row in (new ACSFCZone().Select_ZoneList().AsEnumerable())
                         where row.ZoneName.Equals(Zone)
                         select row;
             
            if (getRow.Count() > 0)
            {
                err.SetError(txtZoneName, "Zone Name already existed for " + cboGroup.Text);
                return true;
            }
            else
            {
                err.Clear();
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!new ACSCMValidator().IsNumberic(txtZoneID.Text))
                {
                    err.SetError(txtZoneID, "ZoneID must be numeric !");
                    return;
                }

                if (_processMode == processMode.newMode)
                {
                    if (ZoneIDExisted(txtZoneID.Text))
                        return;

                    if (ZoneNameExisted(txtZoneName.Text))
                        return;

                    new ACSFCZone().Insert_NewZone(txtZoneID.Text, ZoneGroupID, txtZoneName.Text, txtAddress.Text, txtPhone.Text, txtIncharge.Text, new ACSCMGlobal()._userPKID, DateTime.Now, new ACSCMGlobal()._userPKID, DateTime.Now);
                    MessageBox.Show("New zone added successfully ... ", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (_processMode == processMode.editMode)
                {
                    //call update here
                    new ACSFCZone().Update_Zone(PKID, LinkID, txtZoneID.Text, ZoneGroupID, txtZoneName.Text, txtAddress.Text, txtPhone.Text, txtIncharge.Text, new ACSCMGlobal()._userPKID, DateTime.Now);
                    MessageBox.Show("Zone updated successfully... ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                _processMode = processMode.none;
                Load_ZoneList();

                txtZoneID.Enabled = false;
                txtZoneName.Enabled = false;
                txtAddress.Enabled = false;
                txtPhone.Enabled = false;
                txtIncharge.Enabled = false;

                btnNew.Enabled = true;
                btnCancel.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Save Zone", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void Filter_ByZoneID(string ZoneID)
        {
            try
            {
                var filter = from row in (new ACSFCZone().Select_ZoneList().AsEnumerable())
                             where row.ZoneID.StartsWith(ZoneID)
                             select row;

                if (filter.Count() > 0)
                    dgvZone.DataSource = filter.ToList();
                else
                    dgvZone.DataSource = null;
            }
            catch
            {

            }
        }

        void Load_ZoneList()
        {
            try
            {
                dgvZone.AutoGenerateColumns = false;
                dgvZone.DataSource = new ACSFCZone().Select_ZoneAndZoneGroup();



                //dgvZone.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgvZone.Columns[0].Width = 80;
                //dgvZone.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //dgvZone.Columns[0].HeaderText = "Zone ID";

                //dgvZone.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgvZone.Columns[1].Width = 350;
                //dgvZone.Columns[1].HeaderText = "Zone Name";

                //dgvZone.Columns[2].Visible = false;

                //dgvZone.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgvZone.Columns[3].Width = 150;
                //dgvZone.Columns[3].HeaderText = "Zone Group";
            }
            catch (Exception ex)
            {

            }
        }

        void Load_ZoneGroupID()
        {
            var getRow = from row in (new ACSFCZoneGroup().Select_ZoneGroup().AsEnumerable())
                         select row;

            cboGroup.Items.Clear();

            for (int i = 0; i < getRow.Count(); i++)
            {
                cboGroup.Items.Add(getRow.ElementAt(i).ZoneGroupName);
            }
            cboGroup.Items.Insert(0, "[Select Zone Group]");
        }

        private void Zone_Load(object sender, EventArgs e)
        {
            Load_ZoneList();
            Load_ZoneGroupID();
            //btnNew.Enabled = true;
            //btnUpdate.Enabled = false;
            //btnCancel.Enabled = false;
            //btnSave.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _processMode = processMode.editMode;
                AuthorizationCheck();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Update Zone", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayLogin();

                if (new ACSCMGlobal().accessGranted)
                {
                    if (MessageBox.Show("Are you sure to delete this zone?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        new ACSFCZone().DeleteZone(txtZoneID.Text);
                        MessageBox.Show("Zone deleting succeeded !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_ZoneList();
                    }
                }
                else
                    MessageBox.Show("You r not authorized to perform this process !");

                // txtZoneID.Enabled = false;
                // txtZoneName.ReadOnly = false;
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Delete Zone", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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

        void AuthorizationCheck()
        {
            DisplayLogin();
            if (new ACSCMGlobal().accessGranted)
            {
                cboGroup.Enabled = true;
                txtZoneID.Enabled = true;
                txtZoneName.Enabled = true;
                txtAddress.Enabled = true;
                txtPhone.Enabled = true;
                txtIncharge.Enabled = true;

                btnSave.Enabled = true;
                btnNew.Enabled = false;
                btnDelete.Enabled = false;
                btnCancel.Enabled = true;
                btnUpdate.Enabled = false;
            }
        }

        private void txtZoneID_TextChanged(object sender, EventArgs e)
        {
            if (_processMode == processMode.newMode)
            {
                Filter_ByZoneID(txtZoneID.Text);
            }
        }

        int PKID;
        int LinkID;
        private void dgvZone_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (_processMode == processMode.none)
                {
                    PKID = Convert.ToInt32(dgvZone.CurrentRow.Cells["colPKID"].Value.ToString());
                    LinkID = Convert.ToInt32(dgvZone.CurrentRow.Cells["colLinkID"].Value.ToString());
                    txtZoneID.Text = dgvZone.CurrentRow.Cells["colZoneID"].Value.ToString();
                    txtZoneName.Text = dgvZone.CurrentRow.Cells["colZoneName"].Value.ToString();
                    txtAddress.Text = dgvZone.CurrentRow.Cells["colAddress"].Value.ToString();
                    txtPhone.Text = dgvZone.CurrentRow.Cells["colPhone"].Value.ToString();
                    txtIncharge.Text = dgvZone.CurrentRow.Cells["colIncharge"].Value.ToString();
                    cboGroup.Text = dgvZone.CurrentRow.Cells["colZoneGroup"].Value.ToString();
                    btnUpdate.Enabled = true;
                }
            }
            catch { }
        }

        string ZoneGroupID;
        void GetZoneGroupID_ByName(string ZoneGroupName)
        {
            ACSFCZoneGroup zone = new ACSFCZoneGroup();
            IEnumerable<Model.ZoneGroup> getRow = from row in zone.Select_ZoneGroup().AsEnumerable()
                                                  where row.ZoneGroupName.Equals(ZoneGroupName)
                                                  select row;

            if (getRow.Count() > 0)
            {
                ZoneGroupID = getRow.FirstOrDefault().ZoneGroupID;
            }
        }

        private void cboGroupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboGroup.SelectedIndex > 0)
                    GetZoneGroupID_ByName(cboGroup.Text);
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Select Zone", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _processMode = processMode.none;
            cboGroup.Enabled = false;
            txtZoneID.Enabled = false;
            txtZoneName.Enabled = false;
            txtAddress.Enabled = false;
            txtPhone.Enabled = false;
            txtIncharge.Enabled = false;

            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
