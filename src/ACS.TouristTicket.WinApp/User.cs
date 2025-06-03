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
        enum processMode { none, newMode, editMode }

        processMode _processMode;
        ErrorProvider err = new ErrorProvider();
        string[] strSpecial = new string[] { "~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "+" };
        string[] strNumber = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

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

        void Load_UserAccessLog()
        {
            dgvUsers.AutoGenerateColumns = false;
            dgvUsers.DataSource = new ACSFCUser().Select_UserAccessLog();
        }

        int Insert_NewUser(string userID, string password, string displayName, string status, string position, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSFCUser().Insert_NewUser(userID, password, displayName, status, position, createdDate, createdBy, modifiedDate, modifiedBy);
        }

        int Insert_UserInRole(string userID, string roleID, Nullable<System.DateTime> createdDate, Nullable<int> createdBy, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSFCUser().Insert_UserInRole(userID, roleID, createdDate, createdBy, modifiedDate, modifiedBy);
        }

        int Update_User(string userID, string password, string displayName, string status, string position, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSFCUser().Update_User(userID, password, displayName, status, position, modifiedDate, modifiedBy);
        }

        int Update_UserInRole(string userID, string roleID, Nullable<System.DateTime> modifiedDate, Nullable<int> modifiedBy)
        {
            return new ACSFCUser().Update_UserInRole(userID, roleID, modifiedDate, modifiedBy);
        }
        
        #endregion

        private void User_Load(object sender, EventArgs e)
        {
            cboStatus.Items.Add("[SELECT]");
            cboStatus.Items.Add("ACTIVATED");   
            cboStatus.Items.Add("LOCKED");

            lblRoleDescription.Text = "";
            Load_UserAccessLog();
        }

        void EnabledTextBox(bool value)
        {
            txtUserID.Enabled = value;
            txtDisplayName.Enabled = value;
            txtPosition.Enabled = value;
            txtPassword.Enabled = value;
            txtConfirmPassword.Enabled = value;
            chkVisible.Enabled = value;
            cboStatus.Enabled = value;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            _processMode = processMode.newMode;

            txtUserID.Text = "";
            txtDisplayName.Text = "";
            txtPosition.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkVisible.Checked = false;
            rdbAdmin.Checked = false;
            rdbUser.Checked = false;
            cboStatus.SelectedIndex = 0;

            EnabledTextBox(true);
            txtUserID.Focus();

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            btnSave.Enabled = true;
            err.Clear();
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
            try
            {
                if (txtUserID.Text == String.Empty)
                {
                    MessageBox.Show("Select user from table first !", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                _processMode = processMode.editMode;

                DisplayLogin();
                if (new ACSCMGlobal().processCancel)
                    return;

                if (new ACSCMGlobal().accessGranted)
                {
                    txtUserID.Enabled = false;
                    txtDisplayName.Enabled = true;
                    txtPosition.Enabled = true;
                    txtPassword.Enabled = true;
                    txtConfirmPassword.Enabled = true;
                    chkVisible.Enabled = true;
                    cboStatus.Enabled = true;

                    txtPassword.Text = "[Reset Password]";
                    //txtConfirmPassword.Text = "[Confirm Password]";

                    txtPassword.UseSystemPasswordChar = false;
                    txtConfirmPassword.UseSystemPasswordChar = false;

                    btnNew.Enabled = false;
                    btnEdit.Enabled = false;
                    btnCancel.Enabled = true;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
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
            if (rdbUser.Checked)
                return true;

            if (rdbAdmin.Checked)
                return true;

            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (_processMode == processMode.newMode)
                {
                    if (CheckUserID(txtUserID.Text))
                        return;

                    if (DisplayNameIsEmpty(txtDisplayName.Text))
                        return;

                    if (!PasswordValidated())
                        return;

                    if (!CheckRoleSelected())
                    {
                        MessageBox.Show("Select user role !", "required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (cboStatus.SelectedIndex == 0)
                    {
                        MessageBox.Show("Select user status !", "required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    Insert_NewUser(txtUserID.Text, new ACSCMGlobal().Get_HasedPassword(txtPassword.Text), txtDisplayName.Text, cboStatus.Text, txtPosition.Text, DateTime.Now, new ACSCMGlobal()._userPKID, DateTime.Now, new ACSCMGlobal()._userPKID);
                    Insert_UserInRole(txtUserID.Text, rdbUser.Checked ? rdbUser.Text : rdbAdmin.Text, DateTime.Now, new ACSCMGlobal()._userPKID, DateTime.Now, new ACSCMGlobal()._userPKID);
                    MessageBox.Show("New user created successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (_processMode == processMode.editMode)
                {
                    if (DisplayNameIsEmpty(txtDisplayName.Text))
                        return;

                    if (txtPassword.Text == "[Reset Password]")
                    {
                        Update_User(txtUserID.Text, orgPassword, txtDisplayName.Text, cboStatus.Text, txtPosition.Text, DateTime.Now, new ACSCMGlobal()._userPKID);
                        Update_UserInRole(txtUserID.Text, rdbUser.Checked ? rdbUser.Text : rdbAdmin.Text, DateTime.Now, new ACSCMGlobal()._userPKID);
                    }
                    else
                    {

                        if (!PasswordValidated())
                            return;

                        Update_User(txtUserID.Text, new ACSCMGlobal().Get_HasedPassword(txtPassword.Text), txtDisplayName.Text, cboStatus.Text, txtPosition.Text, DateTime.Now, new ACSCMGlobal()._userPKID);
                        Update_UserInRole(txtUserID.Text, rdbUser.Checked ? rdbUser.Text : rdbAdmin.Text, DateTime.Now, new ACSCMGlobal()._userPKID);
                    }

                    MessageBox.Show("User updated successfully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                EnabledTextBox(false);
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;

                Load_UserAccessLog();
            }
            catch
            {
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Save User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
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

        bool PasswordValidated()
        {
            if (txtPassword.Text == "")
            {
                err.SetError(txtPassword, "Please Enter Password");
                return false;
            }
            else
            {
                if (txtPassword.Text.Length < 6)
                {
                    err.SetError(txtPassword, "Password length must have at least 6 characters or digits.");
                    return false;
                }

                    for (int i = 0; i < strSpecial.Length; i++)
                    {
                        if (txtPassword.Text.Contains(strSpecial[i]))
                        {
                            for (int j = 0; j < strSpecial.Length; j++)
                            {
                                if (txtPassword.Text.Contains(strNumber[j]))
                                {
                                    if (txtConfirmPassword.Text == "")
                                    {
                                        err.SetError(txtConfirmPassword, "Enter Confirm Password.");
                                        return false;
                                    }
                                    else
                                    {
                                        if (txtPassword.Text != txtConfirmPassword.Text)
                                        {
                                            err.SetError(txtConfirmPassword, "Confirm Password Does Not Match.");
                                            return false;
                                        }
                                        else
                                        {
                                            err.Clear();
                                            return true;
                                        }
                                    }
                                }
                                else
                                    if (j == strNumber.Length - 1)
                                    {
                                        err.SetError(txtPassword, "Password must contain at least one number. [0,1,2,3,4,5,6,7,8,9]");
                                        return false;
                                    }
                            }
                        }
                        else
                            if (i == strSpecial.Length - 1)
                            {
                                err.SetError(txtPassword, "Password must contain at least one of this special characters. [~,!,@,#, $,%,^,&,*,(,),-,+]");
                                return false;
                            }
                    }
                    return false;
            }
        }

        void Load_UserRole(string UserID)
        {
            try
            {
                var getRow = from row in (new ACSFCUser().Select_UserInRole().AsEnumerable())
                             where row.UserID.Equals(UserID)
                             select row;

                if (getRow.Count() > 0)
                {
                    if (getRow.First().RoleName.ToLower() == "user")
                        rdbUser.Checked = true;
                    else if (getRow.First().RoleName.ToLower() == "administrator")
                        rdbAdmin.Checked = true;
                    else
                    {
                        rdbUser.Checked = false;
                        rdbAdmin.Checked = false;
                    }
                }
                else
                {
                    rdbUser.Checked = false;
                    rdbAdmin.Checked = false;
                }
            }
            catch 
            {
                //Show ex here
            }
        }

        string orgPassword;
        void GetUserInfo(string UserID)
        {
            var getRow = from row in (new ACSFCUser().Select_User().AsEnumerable())
                             where row.UserID.Equals(UserID)
                             select row;

            txtUserID.Text = UserID;
            txtDisplayName.Text = getRow.First().DisplayName;
            orgPassword = getRow.First().Password;
            cboStatus.Text = getRow.First().Status;

            Load_UserRole(UserID);
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    GetUserInfo(dgvUsers.CurrentRow.Cells[0].Value.ToString());

                    btnChangePassword.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            catch 
            {
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Select User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        void DisplayLogin()
        {
            Login login = new Login();
            login.editLogin = true;
            login.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            login.StartPosition = FormStartPosition.CenterScreen;
            login.Width = 400;
            login.Height = 205;
            //login.ControlBox = false;
            //login.MinimizeBox = false;
            //login.MaximizeBox = false;
            login.ShowDialog();
        }

        void AuthorizationCheck()
        {
            DisplayLogin();

            if (new ACSCMGlobal().processCancel)
                return;

            if (new ACSCMGlobal().accessGranted)
            {
                //txt.ReadOnly = false;
                //txtZoneName.ReadOnly = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserID.Text == String.Empty)
                {
                    MessageBox.Show("Select user from table first !", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DisplayLogin();
                
                if (new ACSCMGlobal().processCancel)
                    return;

                if (new ACSCMGlobal().accessGranted)
                {
                    if (MessageBox.Show("Are you sure to delete this user ? \n\nUserID : [" + txtUserID.Text.Trim() + "]\nDisplay Name : [" + txtDisplayName.Text.Trim() + "]", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        new ACSFCUser().DeleteUserByUserID(txtUserID.Text);
                        new ACSFCUser().DeleteUserInRoleByUserID(txtUserID.Text);

                        MessageBox.Show("User deleted successfully !", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtUserID.Text = "";
                        txtDisplayName.Text = "";
                        txtPosition.Text = "";
                        txtPassword.Text = "";
                        txtConfirmPassword.Text = "";
                        cboStatus.Text = "";
                        chkVisible.Checked = false;
                        rdbAdmin.Checked = false;
                        rdbUser.Checked = false;

                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;

                        Load_UserAccessLog();
                    }
                }
                else
                    MessageBox.Show("You are not authorized to perform this process !", "Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch
            {
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void rdbUser_CheckedChanged(object sender, EventArgs e)
        {
            lblRoleDescription.Text = "User can access information on this system in READ-ONLY mode.";
            
            if (rdbUser.Checked)
                rdbUser.Font = new Font("Microsoft San Serif", 9, FontStyle.Bold);
            else
                rdbUser.Font = new Font("Microsoft San Serif", 9, FontStyle.Regular);
        }

        private void rdbAdmin_CheckedChanged(object sender, EventArgs e)
        {
            lblRoleDescription.Text = "User can access information on this system in READ-WRITE mode.";

            if (rdbAdmin.Checked)
                rdbAdmin.Font = new Font("Microsoft San Serif", 9, FontStyle.Bold);
            else
                rdbAdmin.Font = new Font("Microsoft San Serif", 9, FontStyle.Regular);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                ChangePassword changePw = new ChangePassword();
                changePw.ShowPassword(txtUserID.Text, txtDisplayName.Text, txtPassword.Text);
                changePw.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Change User Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDisplayName.Enabled = false;
            txtPassword.Enabled = false;
            txtPosition.Enabled = false;
            txtConfirmPassword.Enabled = false;
            cboStatus.Enabled = false;
            chkVisible.Enabled = false;

            btnCancel.Enabled = false;
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnSave.Enabled = false;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (_processMode == processMode.editMode)
            {
                if (txtPassword.Text == "")
                    txtPassword.Text = "[Reset Password]";
                else if (txtPassword.Text == "[Reset Password]")
                    txtPassword.Text = ""; 
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            //if (_processMode == processMode.editMode)
            //{
            //    if (txtPassword.Text == "[Reset Password]")
            //        txtPassword.Text = "[Reset Password]";
            //}
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (_processMode == processMode.editMode)
            {
                if (txtPassword.Text == "")
                    txtPassword.Text = "[Reset Password]";
            }
        }
    }
}
