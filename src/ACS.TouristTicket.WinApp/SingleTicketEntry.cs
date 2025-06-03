using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

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

        void getZoneGroupID()
        {
            ACSFCZoneGroup zone = new ACSFCZoneGroup();
            IList<Model.ZoneGroup> zoneGroups = (from row in zone.Select_ZoneGroup().AsEnumerable()
                                                  select row).ToList();

            zoneGroups.Insert(0,new Model.ZoneGroup() { ZoneGroupID = "0",ZoneGroupName="[Select Zone Group]"});
            cboZoneID.Items.Clear();
            
            cboZoneID.DataSource = zoneGroups;
            cboZoneID.DisplayMember = "ZoneGroupName";
            cboZoneID.ValueMember = "ZoneGroupID";
            cboZoneID.SelectedIndex = 0;
        }

        private void TicketEntry_Load(object sender, EventArgs e)
        {
            getZoneGroupID();
        }

        int GetMaxTicketSerialID()
        {
            return new ACSFCTicket().SelectNewTicketID();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                txtSerialNo.Text = "";
                txtIssued.Text = "";
                txtExpiryDate.Text = "";

                txtSerialNo.Text = GetMaxTicketSerialID().ToString();

                txtIssued.Text = DateTime.Now.ToShortDateString();
                txtExpiryDate.Text = DateTime.Now.AddDays(Convert.ToDouble(7)).ToShortDateString();
                cboZoneID.SelectedIndex = 0;
            }
            catch ( Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Retrieve Ticket Serial No", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        void GetZoneGroupName_ByID(string ZoneGroupID)
        {
            //ACSFCZoneGroup zone = new ACSFCZoneGroup();
            //IEnumerable<Model.ZoneGroup> getRow = from row in zone.Select_ZoneGroup().AsEnumerable()
            //                                      where row.ZoneGroupID.Equals(ZoneGroupID)
            //                                      select row;

            //if (getRow.Count() > 0)
            //{
            //    pbZone.Visible = true;
            //    lblZoneName.Text = getRow.First().ZoneGroupName.ToString();

            //    GetZoneGroupSetting_ByID(ZoneGroupID);
            //}
            //else
            //{
            //    pbZone.Visible = false;
            //    lblZoneName.Text = "";
            //}

        }

        //void GetZoneGroupSetting_ByID(string ZoneGroupID)
        //{
        //    ACSFCTicketSettings ticketSetting = new ACSFCTicketSettings();
        //    IEnumerable<Model.TicketSetting> getRow = from row in ticketSetting.SelectTicketSetting().AsEnumerable()
        //                                              where row.ZoneGroupID.Equals(ZoneGroupID)
        //                                              select row;
        //    if (getRow.Count() > 0)
        //    {
        //        txtAllowedDays.Text = getRow.First().DaysAllowed.ToString();
        //        txtEntryAllowed.Text = getRow.First().EntryAllowed.ToString();
        //        txtPrice.Text = getRow.First().Price.ToString();
        //    }
        //    else
        //    {
        //        txtAllowedDays.Text = "Not Found";
        //        txtEntryAllowed.Text = "Not Found";
        //        txtPrice.Text = "Not Found";
        //    }
        //}

        private void cboZoneID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model.ZoneGroup groupInfo = (Model.ZoneGroup) cboZoneID.SelectedItem;
            txtAllowedDays.Text = groupInfo.DaysAllowed.ToString();
            txtEntryAllowed.Text = groupInfo.EntriesAllowed.ToString();
            txtPrice.Text = groupInfo.Price.ToString();

            txtIssued.Text = "";
            txtExpiryDate.Text = "";
            txtSerialNo.Text = "";

            if (cboZoneID.SelectedIndex > 0)
                btnGenerate.Enabled = true;
            else
                btnGenerate.Enabled = false;
        }

        public string GenerateTicketData(int ticketID, int zone1ID, int zone2ID, int zone3ID, int zone4ID, int zone5ID, decimal ticketPrice,int allowedUsage, DateTime createdDate, int createdBy)
        {
            // 7 + (3x5)=15 + 6 + 3 + 3 + 4 = 38
            return ticketID.ToString("0000000") + zone1ID.ToString("000") + zone2ID.ToString("000") + zone3ID.ToString("000") + zone4ID.ToString("000") + zone5ID.ToString("000") + createdDate.ToString("yymmdd") + ticketPrice.ToString("000") + allowedUsage.ToString("000") + createdBy.ToString("0000");
        }

        void GenerateID()
        {
            QRCodeWriter writer = new QRCodeWriter();
            ByteMatrix bm = writer.encode(txtEncryptedTicketID.Text, BarcodeFormat.QR_CODE, 160, 160);
            pb2D1.Image = bm.ToBitmap();
            pb2D2.Image = bm.ToBitmap();
            pb1D.Image = BarcodeDrawFactory.Code128WithChecksum.Draw(txtSerialNo.Text, 30, 2);
            lblSerialNo.Text = txtSerialNo.Text;
            pnlCard.Visible = true;
            lblTicketPreview.Visible = true;

            //pb2D1.Image.Save(@"D:\nml.png");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you really want to save the ticket ?", "Save Ticket", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    new ACSFCTicket().Insert_Ticket(Convert.ToInt32(txtSerialNo.Text), cboZoneID.SelectedValue.ToString(), Convert.ToDecimal(txtPrice.Text), "NEW", Convert.ToInt32(txtEntryAllowed.Text), 0, Convert.ToInt32(txtAllowedDays.Text), null, txtEncryptedTicketID.Text, DateTime.Now, new ACSCMGlobal()._userPKID, DateTime.Now, new ACSCMGlobal()._userPKID);
                    MessageBox.Show("New Ticket Data Saved", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblTicketPreview.Visible = false;
                    pnlCard.Visible = false;
                    btnGenerate.Enabled = true;
                    btnAdd.Enabled = false;
                    btnCancel.Enabled = false;
                }
            }
            catch ( Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Saving Ticket", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cboZoneID.SelectedIndex = 0;

            foreach (Control tb in this.Controls)
            {
                if (tb.GetType().Name == "TextBox")
                    tb.Text = "";
            }

            btnGenerate.Enabled = true;
            btnAdd.Enabled = false;
            btnCancel.Enabled = false;

            pnlCard.Visible = false;
            lblTicketPreview.Visible = false;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                //get computername
                //txtAllowedDays.Text = Environment.MachineName;
                //get ip
                //txtAllowedDays.Text = System.Net.Dns.GetHostAddresses(Environment.MachineName)[1].ToString();
                if (cboZoneID.SelectedIndex == 0 || cboZoneID.Text == "" || cboZoneID.Text == null)
                {
                    MessageBox.Show("Select ZoneGroupID First", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cboZoneID.Focus();
                    return;
                }
                else
                {
                    //get the ticket serial number first
                    txtSerialNo.Text = GetMaxTicketSerialID().ToString();
                    txtIssued.Text = DateTime.Now.ToString(ACSCConstant.Format.DateFormat);
                    txtExpiryDate.Text = DateTime.Now.AddDays(Convert.ToInt32(txtAllowedDays.Text)).ToString(ACSCConstant.Format.DateFormat);
                    string ticketData = GenerateTicketData(Convert.ToInt32(txtSerialNo.Text), Convert.ToInt32(cboZoneID.SelectedValue.ToString()), 0, 0, 0, 0, Convert.ToDecimal(txtPrice.Text), Convert.ToInt32(txtEntryAllowed.Text), Convert.ToDateTime(txtIssued.Text, new CultureInfo("en-GB")), 0);
                    txtEncryptedTicketID.Text = new ACSFCSupport().EncDec(ticketData);
                    GenerateID();
                    btnGenerate.Enabled = false;
                    btnAdd.Enabled = true;
                    btnCancel.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Generate Ticket ID", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
