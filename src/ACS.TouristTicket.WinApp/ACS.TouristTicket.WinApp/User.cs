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
    public partial class User : Form
    {
        enum processMode
        {
            none, newMode, editMode
        }

        processMode _processMode;
        ErrorProvider err = new ErrorProvider();
        bool errorFound;

        string RoleID = "";

        public User()
        {
            InitializeComponent();
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region "Sub Functions"

        int Check_UserIDAlreadyExisted(string UserID)
        {
            var userList = from row in new ACSFCUser().Select_User().AsEnumerable()
                           where row.UserID.Equals(UserID)
                           select row;

            if (userList.Count() > 0)
                return 1;
            else
                return 0;
        }

        void Load_Roles()
        {
            dgvRoles.AutoGenerateColumns = false;
            dgvRoles.DataSource = new ACSFCUser().Select_Role();
        }

        void Load_UserAccessLog()
        {
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.DataSource = new ACSFCUser().Select_UserAccessLog();
        }

        int Insert_NewUser(string userID, string password, string displayName, string status, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSFCUser().Insert_NewUser(userID, password, displayName, status, createdDate, createdBy, modifiedDate, modifiedBy);
        }

        int Insert_UserInRole(string userID, string roleID, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSFCUser().Insert_UserInRole(userID, roleID, createdDate, createdBy, modifiedDate, modifiedBy);
        }

        int Update_User(string userID, string password, string displayName, string status, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSFCUser().Update_User(userID, password, displayName, status, modifiedDate, modifiedBy);
        }

        int Update_UserInRole(string userID, string roleID, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSFCUser().Update_UserInRole(userID, roleID, modifiedDate, modifiedBy);
        }
        
        #endregion

        private void User_Load(object sender, EventArgs e)
        {
            Load_Roles();
            Load_UserAccessLog();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            _processMode = processMode.newMode;

            txtUserID.Enabled = true;
            txtDisplayName.Enabled = true;
            txtPassword.Enabled = true;
            txtConfirmPassword.Enabled = true;
            txtUserID.Focus();

            btnSave.Enabled = true;
        }

        void UsePasswordChar(bool bValue)
        {
            txtPassword.UseSystemPasswordChar = bValue;
            txtConfirmPassword.UseSystemPasswordChar = bValue;
        }

        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVisible.Checked)
                UsePasswordChar(false);
            else
                UsePasswordChar(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _processMode = processMode.editMode;
            btnSave.Enabled = true;
        }

        bool DisplayNameIsEmpty(string DisplayName)
        {
            if (DisplayName == "")
            {
                err.SetError(txtDisplayName, "Please Entery Display Name");
                return true;
            }
            else
            {
                err.Clear();
                return false;
            }
        }

        bool CheckRoleSelected()
        {
            for (int i = 0; i < 2; i++)
            {
                if (Convert.ToInt32(dgvRoles.Rows[i].Cells["colRowID"].Value) == 1)
                {
                    return true;
                }
                else
                {
                    if (i == 1)
                    {
                        MessageBox.Show("Please Select Role For User.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
            }
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckUserID(txtUserID.Text))
                return;

            if (DisplayNameIsEmpty(txtDisplayName.Text))
                return;

            if (PasswordDoesNotMatch())
                return;

            if (!CheckRoleSelected())
                return;

            try
            {
                if (_processMode == processMode.newMode)
                {
                    Insert_NewUser(txtUserID.Text, txtPassword.Text, txtDisplayName.Text, cboStatus.Text, DateTime.Now, 1, DateTime.Now, 1);
                    Insert_UserInRole(txtUserID.Text, RoleID, DateTime.Now, 1, DateTime.Now, 1);
                    MessageBox.Show("New user created successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (_processMode == processMode.editMode)
                {
                    Update_User(txtUserID.Text, txtPassword.Text, txtDisplayName.Text, cboStatus.Text, DateTime.Now, 1);
                    Update_UserInRole(txtUserID.Text, RoleID, DateTime.Now, 1);
                    MessageBox.Show("User updated successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
            }
        }

        bool CheckUserID(string UserID)
        {
            if (UserID == "")
            {
                err.SetError(txtUserID, "Please Enter UserID");
                return true;
            }
            else
            {
                if (Check_UserIDAlreadyExisted(UserID) > 0)
                {
                    err.SetError(txtUserID, "UserID is already existed.");
                    return true;
                }
                else
                {
                    err.Clear();
                    return false;
                }
            }
        }

        bool PasswordDoesNotMatch()
        {
            if (txtPassword.Text == "")
            {
                err.SetError(txtPassword, "Please Enter Password");
                return true;
            }
            else
            {
                if (txtConfirmPassword.Text == "")
                {
                    err.SetError(txtConfirmPassword, "Enter Confirm Password.");
                    return true;
                }
                else
                {
                    if (txtPassword.Text != txtConfirmPassword.Text)
                    {
                        err.SetError(txtConfirmPassword, "Confirm Password Does Not Match.");
                        return true;
                    }
                    else
                    {
                        err.Clear();
                        return false;
                    }
                }
            }
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowPos = dgvRoles.CurrentRow.Index;

            try
            {
                if (e.ColumnIndex == 0)

                    if (Convert.ToInt16(dgvRoles.Rows[rowPos].Cells["colRowID"].Value) == 0)
                    {
                        dgvRoles.Rows[rowPos].Cells["colRowID"].Value = 1;
                        if (rowPos > 0)
                            dgvRoles.Rows[rowPos - 1].Cells["colRowID"].Value = 0;
                        else
                            dgvRoles.Rows[rowPos + 1].Cells["colRowID"].Value = 0;
                    }
                    else
                        dgvRoles.Rows[rowPos].Cells["colRowID"].Value = 0;

                RoleID = dgvRoles.CurrentRow.Cells["colRoleID"].Value.ToString();
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
            }
        }

        private void txtUserID_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
