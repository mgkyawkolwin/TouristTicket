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
    public partial class ActivateTicket : Form
    {
        public ActivateTicket()
        {
            InitializeComponent();
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Get_TicketInformation(int TicketSerialNo)
        {
            try
            {
                var getTicket = from row in (new ACSFCTicket().Select_Ticket()).AsEnumerable()
                                where row.PKID.Equals(Convert.ToInt32(txtSerialNo.Text))
                                select row;

                if (getTicket.Count() > 0)
                {
                    if (getTicket.First().AlreadyUsed == 0)
                    {
                        lblMessage.Text = "Valid - Need to be activated";
                        txtExpiryDate.Text = "";
                        btnActivate.Enabled = true;
                        btnCheckIn.Enabled = false;
                    }
                    else if ((getTicket.First().AlreadyUsed > 0) && (getTicket.First().AlreadyUsed < getTicket.First().AllowedUsage))
                    {
                        lblMessage.Text = "Valid";
                        txtExpiryDate.Text = getTicket.First().ExpiryDate.ToString();
                        btnActivate.Enabled = false;
                        btnCheckIn.Enabled = true;
                    }
                    else
                    {
                        lblMessage.Text = "Invalid Ticket Found";
                        btnActivate.Enabled = false;
                        btnCheckIn.Enabled = false;
                        return;
                    }

                        txtPrice.Text = getTicket.First().Price.ToString();
                        txtIssued.Text = DateTime.Now.ToString();
                        txtActivatedDate.Text = "";
                        txtAllowedDays.Text = getTicket.First().AllowedDays.ToString();
                        txtEntryAllowed.Text = getTicket.First().AllowedUsage.ToString();
                        txtEntryCount.Text = getTicket.First().AlreadyUsed.ToString();

                        foreach (Control c in this.Controls)
                        {
                            if (c.GetType().Name == "TextBox")
                                c.Enabled = false;
                        }

                        txtSerialNo.Enabled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Activate this ticket ?", "Activation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                txtActivatedDate.Text = DateTime.Now.ToString();

                new ACSFCTicket().Update_Ticket(Convert.ToDecimal(txtPrice.Text), "Activated", Convert.ToInt32(txtEntryAllowed.Text), Convert.ToInt32(txtEntryCount.Text), Convert.ToInt32(txtAllowedDays.Text), DateTime.Now.AddDays(Convert.ToDouble(txtAllowedDays.Text)), "TicketData", DateTime.Now, 1, DateTime.Now, 1);
                txtExpiryDate.Text =DateTime.Now.AddDays(Convert.ToDouble(txtAllowedDays.Text)).ToString();
                MessageBox.Show("Ticket is activated successfully.\n\nExpiry Date : " + txtExpiryDate.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblMessage.Text = "Activated Successfully";
                btnActivate.Enabled = false;
                btnCheckIn.Enabled = true;
            }
        }

        private void txtSerialNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Get_TicketInformation(Convert.ToInt32(txtSerialNo.Text));
            }
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi Buddy, I am about to go into your museum now !", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            new ACSFCTicket().Update_Ticket(Convert.ToDecimal(txtPrice.Text), lblMessage.Text, Convert.ToInt32(txtEntryAllowed.Text), Convert.ToInt32(txtEntryCount.Text) + 1, Convert.ToInt32(txtAllowedDays.Text), DateTime.Now.AddDays(Convert.ToDouble(txtAllowedDays.Text)), "TicketData", DateTime.Now, 1, DateTime.Now, 1);
            txtEntryCount.Text = (Convert.ToInt32(txtEntryCount.Text) + 1).ToString();
        }
    }
}
