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
    public partial class SingleTicketEntry : Form
    {
        public SingleTicketEntry()
        {
            InitializeComponent();
        }

        private void TicketEntry_Load(object sender, EventArgs e)
        {

        }

        int Get_MaxSerialNo()
        {
            var getTicket = from row in (new ACSFCTicket().Select_Ticket()).AsEnumerable()
                            select row.PKID;

            return getTicket.Last() + 1;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pnlCard.Visible = false;
            txtSerialNo.Text = "";
            //txtPrice.Text = "";
            //txtAllowedDays.Text = "";
           // txtEntryAllowed.Text = "";
            txtIssued.Text = "";
            txtExpiryDate.Text = "";
            txtTicket2DID.Text = "";

            txtSerialNo.Text = Get_MaxSerialNo().ToString();

            txtIssued.Text = DateTime.Now.ToShortDateString();
            txtExpiryDate.Text = DateTime.Now.AddDays(Convert.ToDouble(7)).ToString();
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

        private void btnGenerate2D_Click(object sender, EventArgs e)
        {
            if (cboZoneID.SelectedIndex == 0 || cboZoneID.Text == "" || cboZoneID.Text == null)
            {
                MessageBox.Show("Select ZoneGroupID First", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboZoneID.Focus();
                return;
            }
            else
            {
                txtTicket2DID.Text = txtSerialNo.Text + cboZoneID.Text + DateTime.Now.Year.ToString() +
                    DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + "5" + "1";

                txtEncryptedTicketID.Text = new ACSFCSupport().EncDec(txtTicket2DID.Text);

                GenerateID();
            }
        }

        void GenerateID()
        {
            QRCodeWriter writer = new QRCodeWriter();
            ByteMatrix bm = writer.encode(txtEncryptedTicketID.Text, BarcodeFormat.QR_CODE, 180, 180);
            pb2D1.Image = bm.ToBitmap();
            pb2D2.Image = bm.ToBitmap();
            pb1D.Image = BarcodeDrawFactory.Code128WithChecksum.Draw(txtSerialNo.Text, 30,2);
            lblSerialNo.Text = txtSerialNo.Text;
            pnlCard.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                new ACSFCTicket().Insert_Ticket(Convert.ToDecimal(txtPrice.Text), "READY", Convert.ToInt32(txtEntryAllowed.Text), 0 , Convert.ToInt32(txtAllowedDays.Text), Convert.ToDateTime(txtExpiryDate.Text), txtEncryptedTicketID.Text, DateTime.Now, 1, DateTime.Now, 1);
                MessageBox.Show("New Ticket Data Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch ( Exception ex)
            {

            }
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
