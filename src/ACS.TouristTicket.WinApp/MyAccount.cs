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
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
        }

        static string oldPassword;
        public void ShowPassword(string userid, string displayname, string password)
        {
            txtUserID.Text = userid;
            txtDisplayName.Text = displayname;
            oldPassword = password;

            lblRole.Text = new ACSCMGlobal()._userType;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                ChangePassword changePw = new ChangePassword();
                changePw.ShowPassword(txtUserID.Text, txtDisplayName.Text, oldPassword);
                changePw.ShowDialog();
            }
            catch ( Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtDisplayName.Enabled = true;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            btnEdit.Enabled = false;
            btnChangePassword.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                new ACSFCUser().Update_User(txtUserID.Text
                    , new ACSCMGlobal()._password
                    , txtDisplayName.Text
                    , new ACSCMGlobal()._status
                    , new ACSCMGlobal()._position
                    , DateTime.Now
                    , new ACSCMGlobal()._userPKID);
                txtDisplayName.Enabled = false;
                btnSave.Enabled = false;

                //Reassign Display Name
                new ACSCMGlobal()._displayName = txtDisplayName.Text;

                Main main = new Main();
                main._userID = new ACSCMGlobal()._displayName;

                MessageBox.Show("Information Updated !", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch ( Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Edit My Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void txtDisplayName_TextChanged(object sender, EventArgs e)
        {
            if (txtDisplayName.Text == String.Empty
                || txtDisplayName.Text == ""
                || txtDisplayName.Text == null)
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnChangePassword.Enabled = false;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;

            txtDisplayName.Enabled = false;
        }
    }
}
