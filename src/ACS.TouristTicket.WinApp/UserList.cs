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
using ACS.TouristTicket.ReportLibrary;

namespace ACS.TouristTicket.WinApp
{
    public partial class UserList : Form
    {
        List<Model.UserAccessLog> userList;
        
        public UserList()
        {
            InitializeComponent();
        }

        private void List_User_Load(object sender, EventArgs e)
        { 
            cboUserStatus.Items.Add("[SELECT ONE]");
            cboUserStatus.Items.Add("Activated");
            cboUserStatus.Items.Add("Blocked");
            cboUserStatus.Items.Add("Pending");
            cboUserStatus.SelectedIndex = 0;

            btnSearch_Click(null, null);
            dgvList.AutoGenerateColumns = false;
            Control_Enable(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                IFormatProvider format = new System.Globalization.CultureInfo("en-GB");
                IList<Model.UserAccessLog> user = new ACSFCUser().Select_UserCollectionUsingFilters
                    (
                        chkStatus.Checked ? (cboUserStatus.SelectedIndex > 0 ? cboUserStatus.Text : null) : null,
                        chkDisplayName.Checked ? (txtDisplayName.Text.Trim() != String.Empty ? txtDisplayName.Text.Trim() : null) : null,

                        chkLoginDate.Checked ? new Nullable<DateTime>(Convert.ToDateTime(dtpLoginDateFrom.Value.ToString("dd/MM/yy"), format)) : null,
                        chkLoginDate.Checked ? new Nullable<DateTime>(Convert.ToDateTime(dtpLoginDateTo.Value.ToString("dd/MM/yy"), format)) : null,

                        chkCreatedDate.Checked ? new Nullable<DateTime>(Convert.ToDateTime(dtpCreatedDateFrom.Value.ToString("dd/MM/yy"), format)) : null,
                        chkCreatedDate.Checked ? new Nullable<DateTime>(Convert.ToDateTime(dtpCreatedDateTo.Value.ToString("dd/MM/yy"), format)) : null
                    );


                dgvList.AutoGenerateColumns = false;
                dgvList.DataSource = null;
                dgvList.DataSource = user.ToList<UserAccessLog>();            
                userList = user.ToList<UserAccessLog>();
                btnPrint.Enabled = userList.Count != 0 ? true : false;
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Ticket List Report View", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }             
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (userList != null)
                {
                    ReportLibrary.Classes.Reporting.View_UserList(userList);
                }
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Ticket List Report View", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }          
        }
               
        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {   
            cboUserStatus.Enabled = chkStatus.Checked ? true : false;
        }

        private void chkDisplayName_CheckedChanged(object sender, EventArgs e)
        {
            txtDisplayName.Enabled = chkDisplayName.Checked ? true : false;
        }

        private void chkLoginDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpLoginDateFrom.Enabled = dtpLoginDateTo.Enabled = chkLoginDate.Checked ? true : false;            
        }

        private void chkCreatedDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpCreatedDateFrom.Enabled = dtpCreatedDateTo.Enabled = chkCreatedDate.Checked ? true : false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Control_Enable(false);            
            cboUserStatus.SelectedIndex = 0;
            txtDisplayName.Text = String.Empty;

            dtpLoginDateFrom.Value = DateTime.Now;
            dtpLoginDateFrom.Value = DateTime.Now;
            dtpLoginDateTo.Value = DateTime.Now;
            dtpCreatedDateFrom.Value = DateTime.Now;
            dtpCreatedDateTo.Value = DateTime.Now;
        }

        private void Control_Enable(Boolean blnStatus)
        {
            chkStatus.Checked = blnStatus;
            chkDisplayName.Checked = blnStatus;
            chkLoginDate.Checked = blnStatus;
            chkCreatedDate.Checked = blnStatus;

            cboUserStatus.Enabled = blnStatus;
            txtDisplayName.Enabled = blnStatus;

            dtpLoginDateFrom.Enabled = blnStatus;
            dtpLoginDateTo.Enabled = blnStatus;
            dtpCreatedDateFrom.Enabled = blnStatus;
            dtpCreatedDateTo.Enabled = blnStatus;
        }

    }
}
