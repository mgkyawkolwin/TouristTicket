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
using ACS.TouristTicket.Service;

namespace ACS.TouristTicket.WinApp
{
    public partial class Login : Form
    {
       public bool editLogin;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (editLogin)
                this.Text = "Describe Your Admin ID";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string hashPassword = new ACSCMGlobal().Get_HasedPassword(txtPassword.Text);
                if (new ACSFCUser().UserLogin(txtUserID.Text, hashPassword) != null)
                {
                    if (new ACSFCUser().UserLogin(txtUserID.Text, hashPassword).Count == 0)
                    {
                        MessageBox.Show("Invalid User ID or Password !", "LogIn Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtUserID.Focus();
                        txtUserID.SelectAll();
                    }
                    else
                    {
                        //Check Log In Account Is Pending or Blocked
                        var getStatus = from row in (new ACSFCUser().UserLogin(txtUserID.Text, hashPassword))
                                        select row;

                        if (getStatus.First().Status.ToLower() == "pending")
                        {
                            MessageBox.Show("Your account is now in pending state.\nContact to your system administrator to activate.","Pending", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        if (getStatus.First().Status.ToLower() == "blocked")
                        {
                            MessageBox.Show("Your account is blocked by your system administrator.\nContact to your system administrator to activate.", "Blocked", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        //Check Log In User Role
                        var getRole = from row in (new ACSFCUser().Select_UserInRole().AsEnumerable())
                                      where row.UserID.Equals(txtUserID.Text)
                                      select row;

                        //Send UserInfo to GlobalAccess
                        new ACSCMGlobal()._displayName = getRole.First().DisplayName;
                        new ACSCMGlobal()._userType = getRole.First().RoleName;
                        new ACSCMGlobal()._status = getRole.First().Status;
                        new ACSCMGlobal()._position = getRole.First().Position;
                        
                        if (editLogin)
                        {
                            new ACSCMGlobal()._fromEdit = true;
                            if (txtUserID.Text == new ACSCMGlobal()._userID &&
                                hashPassword == new ACSCMGlobal()._password)
                            {
                                new ACSCMGlobal().processCancel = false;
                                new ACSCMGlobal().accessGranted = true;
                            }
                            else
                            {
                                MessageBox.Show("Account verification failed, your authorization did not match with current log in account.", "Access Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return;
                            }
                        }
                        else
                        {
                            var getName = from row in (new ACSFCUser().Select_User()).AsEnumerable()
                                          where row.UserID.Equals(txtUserID.Text.Trim())
                                          select row;
 
                            Main main = new Main();
                            main._userID = getName.First().DisplayName;
                            main._time = DateTime.Now.ToString("dd, MMM-yyyy <hh:mm tt>");
                            main._authenticated = true;

                            new ACSCMGlobal()._fromEdit = false;
                            new ACSCMGlobal()._userPKID = getName.First().PKID;
                            new ACSCMGlobal()._userID = txtUserID.Text;
                            new ACSCMGlobal()._password = hashPassword;
                        }

                        //Add to UserAccessLog File
                        new ACSFCUser().Insert_UserAccessLog(txtUserID.Text, DateTime.Now, "Log In", DateTime.Now, 1, DateTime.Now, 1);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User ID or Password !", "LogIn Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUserID.Focus();
                    txtUserID.SelectAll();
                }
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void txtUserID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                txtPassword.SelectAll();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main._authenticated = false;

            new ACSCMGlobal().processCancel = true;

            this.Close();
        }
    }
}
