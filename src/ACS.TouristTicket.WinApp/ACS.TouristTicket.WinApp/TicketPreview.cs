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
    public partial class TicketPreview : Form
    {
        public TicketPreview()
        {
            InitializeComponent();
        }

        string serialNo;

        private List<TouristTicket.Model.Ticket> ticketCollection;
        public List<TouristTicket.Model.Ticket> _ticketCollection
        {
            get
            {
                if (ticketCollection == null)
                    ticketCollection = new List<Ticket>();
                return ticketCollection;
            }
            set { ticketCollection = value; }
        }

        string qrCode;
        const int ColumnCounts = 2;
        private void Generate_TicketDesignCollection()
        {
            try
            {
                int CurrentColumnIndex = 1;
                QRCodeWriter writer = new QRCodeWriter();
                ByteMatrix bm;
                string cardHtml = "<table border='0' cellpadding='0px' align='center' valign='middle' style='font-family:Arial;font-size:9pt;border:solid 1px black'>" +
                                       "<tr><td align='center'>[TOP_LEFT]</td><td align='center'>[TOP_CENTER]<br /><br />[SERIALNO]<br /><br />[ISSUE_DATE]</td><td>[TOP_RIGHT]</td></tr>" +
                                       "<tr><td colspan='3' align='center' style='vertical-align:middle;'>[BOTTOM]</td></tr>" +
                                       "</table>";

                string html = @"<center><br /><table border='0' width=""990"" cellpadding=""0px"" cellspacing=""0px"" style='border:solid 0px black;'><tr><td align='center' style='height:265px'>";
                string newHtml = @"<center><table width='100%'><tr>" +
                        "<td style='border:solid 1px black; width:20px'><br /><br /><br /></td>" +
                        "<td style='border:solid 1px black; width:20px'><br /><br /><br /></td>" +
                        "<td style='border:solid 1px black; width:20px'><br /><br /><br /></td>" +
                        "<td style='border:solid 1px black; width:20px'><br /><br /><br /></td>" +
                        "<td style='border:solid 1px black; width:20px'><br /><br /><br /></td>" +
                        "</tr></table>";

           
                for (int i = 0; i < ticketCollection.Count(); i++)
                {
                    int a;
                    int intResult = Math.DivRem(i, 8, out a);

                    if (i > 1)
                    {
                        if (a == 0)
                            html = html + "";
                    }

                    html = html + cardHtml;

                    serialNo = ticketCollection.ElementAt(i).PKID.ToString();
                    qrCode = ticketCollection.ElementAt(i).TicketData.ToString();
                    bm = writer.encode(qrCode, BarcodeFormat.QR_CODE, 140, 140);

                    bm.ToBitmap().Save(AppDomain.CurrentDomain.BaseDirectory + @"\sys_images\2D\" + serialNo + ".png");
                    BarcodeDrawFactory.Code128WithChecksum.Draw(serialNo, 30, 2).Save(AppDomain.CurrentDomain.BaseDirectory + @"\sys_images\1D\" + serialNo + ".png");

                    html = html.Replace("[TOP_LEFT]", @"<img width=""140px"" height=""140px"" src='" + AppDomain.CurrentDomain.BaseDirectory + @"\sys_images\2D\" + serialNo + ".png'");
                    html = html.Replace("[TOP_CENTER]", @"<img width=""120px"" height=""30px"" src='" + AppDomain.CurrentDomain.BaseDirectory + @"\sys_images\1D\" + serialNo + ".png'");
                    html = html.Replace("[SERIALNO]", serialNo);
                    html = html.Replace("[ISSUE_DATE]", "DATE OF ISSUE");
                    html = html.Replace("[TOP_RIGHT]", @"<img width=""140px"" height=""140px"" src='" + AppDomain.CurrentDomain.BaseDirectory + @"\sys_images\2D\" + serialNo + ".png'");
                    html = html.Replace("[BOTTOM]", newHtml);

                    if (CurrentColumnIndex < ColumnCounts)
                    {
                        if (i > 1)
                        {
                            if (a == 0)
                                html = html + "";
                        }
                        html = html + "<td align='center' style='height:265px'>";
                        CurrentColumnIndex++;
                    }
                    else
                    {
                        if (i > 1)
                        {
                            if (a == 0)
                                html = html + "";
                        }
                        html = html + "<tr><td align='center' style='height:265px'>";
                        CurrentColumnIndex = 1;
                    }

                    //html = @"<center><br /><table border='0' width=""990"" cellpadding=""0px"" cellspacing=""0px"" style='border:solid 0px black;'><tr><td align='center'>" + cardHtml + "</td><td>" + cardHtml + "</td></tr></table>";
                }
                webBrowser1.DocumentText = html;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Formatting Preview Style Failed\n" + ex.Message.ToString());
            }
        }


        private void TicketPreview_Load(object sender, EventArgs e)
        {
            Generate_TicketDesignCollection();
        }

        private void tsbPrint_Click(object sender, EventArgs e)
        {
            webBrowser1.ShowPrintPreviewDialog();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
