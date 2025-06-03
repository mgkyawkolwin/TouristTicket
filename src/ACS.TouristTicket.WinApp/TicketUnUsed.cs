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
    public partial class TicketUnUsed : Form
    {
        public TicketUnUsed()
        {
            InitializeComponent();
        }

        enum processMode
        {
            none, newMode, editMode
        }
        processMode _processMode;

        private void btnNew_Click(object sender, EventArgs e)
        {
            _processMode = processMode.newMode;
            txtSerialNo.Enabled = true;
            txtReason.Enabled = true;
            chkRemove.Enabled = false;
            txtSerialNo.Text ="";
            txtZoneGroup.Text = "";
            txtReason.Text = "";
            txtSerialNo.Focus();

            btnNew.Enabled = false;
            btnCancel.Enabled = true;
            btnEdit.Enabled = true;
        }

        void ControlStateAfterSaved()
        {
            txtSerialNo.Enabled = false;
            txtReason.Enabled = false;

            btnNew.Enabled = true;
            btnCancel.Enabled = false;
            btnEdit.Enabled = true;
            btnSave.Enabled = false;
        }

        private void txtSerialNo_TextChanged(object sender, EventArgs e)
        {
            if (txtSerialNo.Text == "")
                btnSave.Enabled = false;
            else
                btnSave.Enabled = true;
        }

        private void Select_TicketDamages()
        {
            dgvDamages.AutoGenerateColumns = false;
            dgvDamages.DataSource = new ACSFCTicketUnused().Select_TicketDamages();
        }

        string zoneGroup;
        string ticketStatus;
        bool TicketSerialNoIsValid(string serialNo)
        {
            var ticket = from row in (new ACSFCTicket().Select_TicketDetail().AsEnumerable())
                         where row.PKID.Equals(Convert.ToInt32(serialNo))
                         select row;

            if (ticket.Count() > 0)
            {
                zoneGroup = ticket.FirstOrDefault().ZoneGroupName;
                ticketStatus = ticket.FirstOrDefault().TicketStatus;
                return true;
            }
            else
                return false;
        }

        bool TicketAlreadyExisted(string SerialNo)
        {
            var ticket = from row in (new ACSFCTicketUnused().Select_TicketDamages().AsEnumerable())
                    where row.SerialNo.Equals(SerialNo)
                    select row;

            if (ticket.Count() > 0)
                return true;
            else
                return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_processMode == processMode.newMode)
                {
                    if (TicketAlreadyExisted(txtSerialNo.Text))
                    {
                        MessageBox.Show("Ticket ID already added to unused ticket lists !", "Existed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (MessageBox.Show("Do you really want to add this ticket to damages list ?", "Save Damages", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        new ACSFCTicketUnused().Insert_TicketUnused(txtSerialNo.Text, txtReason.Text
                           , new ACSCMGlobal()._userPKID, DateTime.Now, new ACSCMGlobal()._userPKID, DateTime.Now);
                        Select_TicketDamages();

                        ControlStateAfterSaved();
                    }
                }
                else if (_processMode == processMode.editMode)
                {
                    if (MessageBox.Show("Update unused ticket data ?", "Update Damages", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        new ACSFCTicketUnused().Update_TicketUnused(txtSerialNo.Text, txtReason.Text
                           , new ACSCMGlobal()._userPKID, DateTime.Now);
                        Select_TicketDamages();

                        ControlStateAfterSaved();
                    }
                }
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Password changing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void TicketDamage_Load(object sender, EventArgs e)
        {
            Select_TicketDamages();
        }

        private void txtSerialNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (new ACSCMValidator().IsNumberic(txtSerialNo.Text))
                {
                    if (TicketSerialNoIsValid(txtSerialNo.Text))
                    {
                        if (ticketStatus != "PRINTED")
                        {
                            MessageBox.Show("Invalid ticket status.\n\nOnly 'PRINTED' ticket status can add to unused ticket lists.\nThis ticket is not printed yet.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtSerialNo.Focus();
                            txtSerialNo.SelectAll();
                        }
                        else
                        {
                            txtZoneGroup.Text = zoneGroup;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid ticket serial number.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtZoneGroup.Text = "";
                        txtSerialNo.Focus();
                        txtSerialNo.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Ticket Serial No", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSerialNo.Focus();
                    txtSerialNo.SelectAll();
                }
            }
        }

        private void dgvDamages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSerialNo.Text = dgvDamages.CurrentRow.Cells["colSerialNo"].Value.ToString();
            txtReason.Text = dgvDamages.CurrentRow.Cells["colReason"].Value == null ? "" :
            dgvDamages.CurrentRow.Cells["colReason"].Value.ToString();

            txtSerialNo.Enabled = false;
            txtReason.Enabled = false;
            btnEdit.Enabled = true;
            //btnDelete.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            _processMode = processMode.editMode;
            txtSerialNo.Enabled = true;
            txtReason.Enabled = true;
            chkRemove.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtSerialNo.Text != "")
            {
                if (MessageBox.Show("Do you really want to delete this ticket from damage lists ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    new ACSFCTicketUnused().Delete_TicketDamages(txtSerialNo.Text);
                    Select_TicketDamages();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSerialNo.Enabled = false;
            txtReason.Enabled = false;
            chkRemove.Enabled = false;

            btnNew.Enabled = true;
            btnEdit.Enabled = false;
            btnSave.Enabled = false;
            //btnDelete.Enabled = true;
            btnCancel.Enabled = false;
        }
    }
}
