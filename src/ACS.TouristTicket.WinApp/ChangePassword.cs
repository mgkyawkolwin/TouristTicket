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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        static string oldPassword;
        public void ShowPassword(string userid, string displayname, string oldpassword)
        {
            txtUserID.Text = userid;
            txtDisplayName.Text = displayname;
            oldPassword = oldpassword;
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

        string[] strSpecial = new string[] { "~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "+" };
        string[] strNumber = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        ErrorProvider err = new ErrorProvider();
        bool PasswordValidated()
        {
            if (txtOldPassword.Text == "")
            {
                err.SetError(txtOldPassword, "Please Enter Old Password");
                return false;
            }
            else
            {
                if (new ACSCMGlobal().Get_HasedPassword(txtOldPassword.Text) != oldPassword) 
                {
                    err.SetError(txtOldPassword, "Old Password Is Incorrect.");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!PasswordValidated())
                    return;
                else
                {
                    new ACSFCUser().Update_User(txtUserID.Text
                       , new ACSCMGlobal().Get_HasedPassword(txtPassword.Text)
                       , txtDisplayName.Text
                       , new ACSCMGlobal()._status
                        , new ACSCMGlobal()._position
                       , DateTime.Now
                       , new ACSCMGlobal()._userPKID);

                    MessageBox.Show("Password changing succeeded !\n\nLog Out and Log In again to varify your update.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch( Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Password changing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}
