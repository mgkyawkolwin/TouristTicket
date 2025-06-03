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
using ACS.TouristTicket.WinApp;

namespace ACS.TouristTicket.WinApp
{
    public partial class ZoneGroup : Form
    {
        enum processMode
        {
            none, newMode, editMode
        }
        processMode _processMode;
       
        public ZoneGroup()
        {
            InitializeComponent();
        }

        ErrorProvider err = new ErrorProvider();

        bool ZoneGroupIDExisted(string ZoneGroupID)
        {
            var getRow = from row in (new ACSFCZoneGroup().Select_ZoneGroup().AsEnumerable())
                         where row.ZoneGroupID.Equals(ZoneGroupID)
                         select row;

            if (getRow.Count() > 0)
            {
                err.SetError(txtZoneGroupID, "Zone Group ID already existed.");
                return true;
            }
            else
            {
                err.Clear();
                return false;
            }
        }

        bool ZoneGroupNameExisted(string ZoneGroup)
        {
            var getRow = from row in (new ACSFCZoneGroup().Select_ZoneGroup().AsEnumerable())
                         where row.ZoneGroupName.Equals(ZoneGroup)
                         select row;

            if (getRow.Count() > 0)
            {
                err.SetError(txtZoneGroupName, "Zone Group Name already existed.");
                return true;
            }
            else
            {
                err.Clear();
                return false;
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

        void textClear()
        {
           
            txtZoneGroupID.Focus();
            txtZoneGroupID.Clear();
            txtZoneGroupName.Clear();
            txtDaysAllowed.Clear();
            txtEntriesAllowed.Clear();
            txtPrice.Clear();
        }

        void AuthorizationCheck()
        {
            try
            {
                //Display Log In Form and Check Admin ID
                DisplayLogin();
                
                //Check User Cancellation of Log In
                if (new ACSCMGlobal().processCancel)
                    return;

                //Check Access Granted or Not
                if (new ACSCMGlobal().accessGranted)
                {
                    //txtZoneGroupID.ReadOnly = false;
                    //txtZoneGroupName.ReadOnly = false;
                    //btnSave.Enabled = true;
                    SetFormState(ACSCConstant.FormState.Editing);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void DeleteZoneGroup()
        {
            try
            {
                DisplayLogin();
                if (new ACSCMGlobal().accessGranted)
                {

                    if (MessageBox.Show("Are you sure you want to delete selected ZoneGroup? This process will be permanently removed!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        new ACSFCZoneGroup().Delete_ZoneGroup(txtZoneGroupID.Text);
                        MessageBox.Show("Deletion Sussessful ... ","Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        showZoneGroup();
                    }
                }
                else
                    MessageBox.Show("You r not authorized to perform this process !");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deleting Failed!", ex.Message);
            }
        }

        void showZoneGroup()
        {
            dgvZoneGroup.DataSource = new ACSFCZoneGroup().Select_ZoneGroup();

            //dgvZoneGroup.Columns[0].Visible = false; //Hide PKID

            //dgvZoneGroup.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvZoneGroup.Columns[1].Width = 80;
            //dgvZoneGroup.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //dgvZoneGroup.Columns[1].HeaderText = "GroupID";

            //dgvZoneGroup.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvZoneGroup.Columns[2].Width = 350;
            //dgvZoneGroup.Columns[2].HeaderText = "Group Name";
        }

        bool IsDecimal(string value)
        {
           decimal d;
           if (decimal.TryParse(value, out d))
           {
               return decimal.Round(d, 2) == d;
           }
           return false;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            //SetFormState(ACSCConstant.FormState.Displaying);

            try
            {
                if (!new ACSCMValidator().IsNumberic(txtZoneGroupID.Text))
                {
                    err.SetError(txtZoneGroupID, "ZoneGroupID must be numeric !");
                    return;
                }

                if (!new ACSCMValidator().IsNumberic(txtZoneGroupID.Text))
                {
                    err.SetError(txtZoneGroupID, "ZoneGroupID must be numeric !");
                    return;
                }

                if (!new ACSCMValidator().IsNumberic(txtDaysAllowed.Text))
                {
                    err.SetError(txtDaysAllowed, "Days allowed must be numeric !");
                    return;
                }

                if (!new ACSCMValidator().IsNumberic(txtEntriesAllowed.Text))
                {
                    err.SetError(txtEntriesAllowed, "Entries allowed must be numeric !");
                    return;
                }

                if (!IsDecimal(txtPrice.Text))
                {
                    err.SetError(txtPrice, "Price must be decimal !");
                    return;
                }

                if (_processMode == processMode.newMode)
                {
                    if (ZoneGroupIDExisted(txtZoneGroupID.Text))
                        return;

                    if (ZoneGroupNameExisted(txtZoneGroupName.Text))
                        return;
                    //call insert here
                    new ACSFCZoneGroup().Insert_ZoneGroup(txtZoneGroupID.Text, txtZoneGroupName.Text, Convert.ToInt32(txtDaysAllowed.Text), Convert.ToInt32(txtEntriesAllowed.Text), Convert.ToDecimal(txtPrice.Text), DateTime.Now, new ACSCMGlobal()._userPKID, DateTime.Now, new ACSCMGlobal()._userPKID);
                    showZoneGroup();
                    MessageBox.Show("Saving Succeeded ... ", "New Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnNew.Enabled = true;
                    btnCancel.Enabled = false;
                    btnSave.Enabled = false;
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                }
                else if (_processMode == processMode.editMode)
                {
                    //call update here
                    new ACSFCZoneGroup().Update_ZoneGroup(Convert.ToInt32(dgvZoneGroup.CurrentRow.Cells[0].Value.ToString()), txtZoneGroupID.Text, txtZoneGroupName.Text, Convert.ToInt32(txtDaysAllowed.Text), Convert.ToInt32(txtEntriesAllowed.Text), Convert.ToDecimal(txtPrice.Text), new ACSCMGlobal()._userPKID, DateTime.Now);
                    MessageBox.Show("Updating Succeeded ... ", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                showZoneGroup();
                txtZoneGroupID.ReadOnly = true;
                txtZoneGroupName.ReadOnly = true;
                txtDaysAllowed.ReadOnly = true;
                txtEntriesAllowed.ReadOnly = true;
                txtPrice.ReadOnly = true;
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Save Zone Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ZoneGroup_Load(object sender, EventArgs e)
        {
            _processMode = processMode.none;
            //txtZoneGroupID.Text = (dataGridView1.CurrentRow.Cells[0].Value.ToString());
            txtZoneGroupID.Focus();
            showZoneGroup();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SetFormState(ACSCConstant.FormState.New);
            _processMode = processMode.newMode;
            //txtZoneGroupID.ReadOnly = false;
            //txtZoneGroupName.ReadOnly = false;
            textClear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //SetFormState(ACSCConstant.FormState.Editing);
            try
            {
                _processMode = processMode.editMode;
                AuthorizationCheck();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Update Zone Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteZoneGroup();
        }

        private void tsmiClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvZoneGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetFormState(ACSCConstant.FormState.Displaying);
            try
            {
                Model.ZoneGroup groupInfo = (Model.ZoneGroup) dgvZoneGroup.CurrentRow.DataBoundItem;
                txtZoneGroupID.Text = groupInfo.ZoneGroupID.ToString();
                txtZoneGroupName.Text = groupInfo.ZoneGroupName;
                txtDaysAllowed.Text = groupInfo.DaysAllowed.ToString();
                txtEntriesAllowed.Text = groupInfo.EntriesAllowed.ToString();
                txtPrice.Text = groupInfo.Price.ToString();
            }
            catch
            { }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayLogin();

                if (new ACSCMGlobal().processCancel)
                    return;

                if (new ACSCMGlobal().accessGranted)
                {
                    if (MessageBox.Show("Are you sure you want to delete selected ZoneGroup? This process will be permanently removed!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        new ACSFCZoneGroup().Delete_ZoneGroup(txtZoneGroupID.Text);
                        MessageBox.Show("Success");
                        showZoneGroup();
                    }
                }
                else
                    MessageBox.Show("You r not authorized to perform this process !");
            }
            catch (Exception ex)
            { 
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Delete Zone Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtZoneGroupName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetFormState(ACSCConstant.FormState formState)
        {
            txtZoneGroupID.ReadOnly = !Convert.ToBoolean(Convert.ToInt32(txtZoneGroupID.Tag) & Convert.ToInt32(formState));
            txtZoneGroupName.ReadOnly = !Convert.ToBoolean(Convert.ToInt32(txtZoneGroupName.Tag) & Convert.ToInt32(formState));
            txtDaysAllowed.ReadOnly = !Convert.ToBoolean(Convert.ToInt32(txtDaysAllowed.Tag) & Convert.ToInt32(formState));
            txtEntriesAllowed.ReadOnly = !Convert.ToBoolean(Convert.ToInt32(txtEntriesAllowed.Tag) & Convert.ToInt32(formState));
            txtPrice.ReadOnly = !Convert.ToBoolean(Convert.ToInt32(txtPrice.Tag) & Convert.ToInt32(formState));

            btnNew.Enabled = Convert.ToBoolean(Convert.ToInt32(btnNew.Tag) & Convert.ToInt32(formState));
            btnUpdate.Enabled = Convert.ToBoolean(Convert.ToInt32(btnUpdate.Tag) & Convert.ToInt32(formState));
            btnDelete.Enabled = Convert.ToBoolean(Convert.ToInt32(btnDelete.Tag) & Convert.ToInt32(formState));
            btnSave.Enabled = Convert.ToBoolean(Convert.ToInt32(btnSave.Tag) & Convert.ToInt32(formState));
            btnCancel.Enabled = Convert.ToBoolean(Convert.ToInt32(btnCancel.Tag) & Convert.ToInt32(formState));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetFormState(ACSCConstant.FormState.Normal);
        }

        private void dgvZoneGroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
