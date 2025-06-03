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
        int daysAllowed=7;
        int usageAllowed = 5;
        string issuedOn;
        string expiryOn;
        string ticket2D;
        string encryptData;

        int Get_MaxSerialNo()
        {
            var getTicket = from row in (new ACSFCTicket().Select_Ticket()).AsEnumerable()
                            select row.PKID;

            return getTicket.Last() + 1;
        }

        void Generate_Data()
        {
            serialNo = Get_MaxSerialNo().ToString();

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
            dgvList.AutoGenerateColumns = true;
            dgvList.DataSource = new ACSFCTicket().Select_Ticket();
        }

        private void MultipleTicketEntry_Load(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            Load_TicketList();
        }

        void InsertTicket(int NoOfTicket)
        {
            for (int i = 0; i <= NoOfTicket; i++)
            {
                Generate_Encry();
                new ACSFCTicket().Insert_Ticket(Convert.ToDecimal(price), "READY", Convert.ToInt32(usageAllowed), 0, Convert.ToInt32(daysAllowed), Convert.ToDateTime(expiryOn), encryptData, DateTime.Now, 1, DateTime.Now, 1);
            }
            //MessageBox.Show("New Ticket Data Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                InsertTicket(Convert.ToInt32(txtNumberOfTickets.Text));
                Load_TicketList();
            }
            catch (Exception ex)
            {

            }
        }

        private void cboZoneID_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboZoneID.SelectedIndex)
            {
                case 1:
                    lblZoneName.Text = "YANGON";
                    break;

                case 2:
                    lblZoneName.Text = "MANDALAY";
                    break;

                case 3:
                    lblZoneName.Text = "BAGO";
                    break;

                case 4:
                    lblZoneName.Text = "MON";
                    break;

                default:
                    lblZoneName.Text = "Select Zone Group ID";
                    break;
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
            //Generate_TicketDesignCollection();
            TicketPreview ticketPreview = new TicketPreview();
            ticketPreview._ticketCollection = new ACSFCTicket().Select_Ticket();
            ticketPreview.Show();
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
