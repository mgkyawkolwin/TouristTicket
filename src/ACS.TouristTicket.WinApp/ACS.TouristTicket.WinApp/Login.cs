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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (new ACSFCUser().UserLogin(txtUserID.Text, txtPassword.Text) != null)
                {
                    if (new ACSFCUser().UserLogin(txtUserID.Text, txtPassword.Text).Count == 0)
                    {
                        MessageBox.Show("Invalid User ID or Password !", "LogIn Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtUserID.Focus();
                        txtUserID.SelectAll();
                    }
                    else
                    {
                        
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
    }
}
