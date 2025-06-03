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

using Zen.Barcode;
using com.google.zxing;
using com.google.zxing.qrcode;
using com.google.zxing.common;

namespace ACS.TouristTicket.WinApp
{
    public partial class MultipleTicketEntry : Form
    {
        public MultipleTicketEntry()
        {
            InitializeComponent();
        }

        string price = "10.00";
        string serialNo;
        string issuedOn;
        string expiryOn;
        string ticket2D;
        string encryptData;

        int daysAllowed(string ZoneGroupID)
        {
            var getRow = from row in (new ACSFCTicketSettings().SelectTicketSetting().AsEnumerable())
                    where row.ZoneGroupID.Equals(ZoneGroupID)
                    select row;

            return Convert.ToInt32(getRow.First().DaysAllowed);
        }

        int usageAllowed(string ZoneGroupID)
        {
            var getRow = from row in (new ACSFCTicketSettings().SelectTicketSetting().AsEnumerable())
                         where row.ZoneGroupID.Equals(ZoneGroupID)
                         select row;

            return Convert.ToInt32(getRow.First().EntryAllowed);
        }

        void Load_ZoneGroupID()
        {
            var getRow = from row in (new ACSFCZoneGroup().Select_ZoneGroup().AsEnumerable())
                         select row;

            cboZoneID.Items.Clear();
            
            for (int i = 0; i < getRow.Count(); i++)
            {
                cboZoneID.Items.Add(getRow.ElementAt(i).ZoneGroupName);
            }
            cboZoneID.Items.Insert(0, "[Select Zone Group]");
            cboZoneID.SelectedIndex = 0;
        }

        void Generate_Data()
        {
            //serialNo = Get_MaxSerialNo().ToString();

            issuedOn = DateTime.Now.ToShortDateString();
            expiryOn = DateTime.Now.AddDays(Convert.ToDouble(7)).ToString();
        }

        void Generate_Encry()
        {
            this.Generate_Data();

            if (cboZoneID.SelectedIndex == 0 || cboZoneID.Text == "" || cboZoneID.Text == null)
            {
                MessageBox.Show("Select ZoneGroupID First", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboZoneID.Focus();
                return;
            }
            else
            {
                ticket2D = serialNo + cboZoneID.Text + DateTime.Now.Year.ToString() +
                    DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "5" + "1";

                encryptData = new ACSFCSupport().EncDec(ticket2D);
            }
        }

        void Load_TicketList()
        {
            dgvList.AutoGenerateColumns = false;

            var getRow = from row in (new ACSFCTicket().Select_TicketDetail().AsEnumerable())
                         where row.PKID >= currentInsertPKID
                         select row;

            dgvList.DataSource = getRow.ToList();

            //dgvList.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvList.Columns[0].Width = 80;
            //dgvList.Columns[0].HeaderText = "Serial No";

            //dgvList.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvList.Columns[1].Width = 100;
            //dgvList.Columns[1].HeaderText = "Ticket Status";

            //dgvList.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvList.Columns[2].Width = 80;
            //dgvList.Columns[2].HeaderText = "Price";

            //dgvList.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvList.Columns[3].Width = 100;
            ////dgvList.Columns[3].HeaderText = "L_Days";

            //dgvList.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvList.Columns[4].Width = 100;
            ////dgvList.Columns[4].HeaderText = "L_Usage";

            //dgvList.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvList.Columns[5].Width = 100;
            ////dgvList.Columns[5].HeaderText = "AlreadyUsed";

            //dgvList.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvList.Columns[5].Width = 150;
            //dgvList.Columns[5].HeaderText = "Activated Date";

            //dgvList.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvList.Columns[5].Width = 50;
            //dgvList.Columns[5].HeaderText = "T_Used";
        }

        private void MultipleTicketEntry_Load(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            Load_ZoneGroupID();
        }

        void InsertTicket(int NoOfTicket)
        {
            currentInsertPKID = GetMaxTicketSerialID();

            for (int i = 0; i < NoOfTicket; i++)
            {
                Generate_Encry();
                new ACSFCTicket().Insert_Ticket(GetMaxTicketSerialID(), zonegid, Convert.ToDecimal(price), "NEW", Convert.ToInt32(txtEntryAllowed.Text), 0, Convert.ToInt32(txtAllowedDays.Text), Convert.ToDateTime(expiryOn), encryptData, DateTime.Now, new ACSCMGlobal()._userPKID, DateTime.Now, new ACSCMGlobal()._userPKID);
            }
        }

        string[] tickets;
        int GetMaxTicketSerialID()
        {
            return new ACSFCTicket().SelectNewTicketID();
        }

        int currentInsertPKID;
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboZoneID.SelectedIndex > 0)
                {
                    if (MessageBox.Show("Do you really want to save this Ticket Collections ? \n\nTicket Total : " + txtNumberOfTickets.Text, "Save Ticket", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        errProvider.Clear();
                        InsertTicket(Convert.ToInt32(txtNumberOfTickets.Text));
                        MessageBox.Show("Total [" + txtNumberOfTickets.Text + "] successfully added !", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnOk.Enabled = false;
                        btnPreview.Enabled = true;
                        Load_TicketList();
                    }
                }
                else
                    errProvider.SetError(cboZoneID, "Select ZoneGroupID");
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Batch Ticket Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        string zonegid;
        void GetZoneGroupID_ByZone(string ZoneGroup)
        {
            ACSFCZoneGroup zone = new ACSFCZoneGroup();
            IEnumerable<Model.ZoneGroup> getRow = from row in zone.Select_ZoneGroup().AsEnumerable()
                                                  where row.ZoneGroupName.Equals(ZoneGroup)
                                                  select row;

            if (getRow.Count() > 0)
            {
                zonegid = getRow.First().ZoneGroupID.ToString();
                txtAllowedDays.Text = getRow.First().DaysAllowed.ToString();
                txtEntryAllowed.Text = getRow.First().EntriesAllowed.ToString();
                txtPrice.Text = getRow.First().Price.ToString();
            }
            else
            {
                txtAllowedDays.Text = "-";
                txtEntryAllowed.Text = "-";
                txtPrice.Text = "-";
            }
        }

        private void cboZoneID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboZoneID.SelectedIndex > 0)
                GetZoneGroupID_ByZone(cboZoneID.Text);
            else
            {
                txtAllowedDays.Text = "";
                txtEntryAllowed.Text = "";
                txtPrice.Text = "";
            }
        }

        private void txtNumberOfTickets_TextChanged(object sender, EventArgs e)
        {
            if (txtNumberOfTickets.Text == String.Empty)
            {
                btnOk.Enabled = false;
                return;
            }

            if (!new ACSCMValidator().IsNumberic(txtNumberOfTickets.Text))
            {
                errProvider.SetError(txtNumberOfTickets, "Invalid Ticket Count !");
                btnOk.Enabled = false;
            }
            else
            {
                errProvider.Clear();
                btnOk.Enabled = true;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                TicketPreview ticketPreview = new TicketPreview();

                var getRow = from row in (new ACSFCTicket().Select_Ticket().AsEnumerable())
                             where row.PKID >= currentInsertPKID
                             select row;

                ticketPreview._ticketCollection = getRow.ToList();
                MdiNavigator.AssignMdiChild(ticketPreview);
                MdiNavigator.ShowMdiChild(ticketPreview);

            }
            catch ( Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Ticket List Preview", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
