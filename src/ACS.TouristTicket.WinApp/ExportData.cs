using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;
using System.Security.Cryptography;
using System.Xml;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.Facade;
using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.WinApp
{
    public partial class ExportData : Form
    {
        public ExportData()
        {
            InitializeComponent();
        }

        string zoneGroupID;
        void Load_ZoneGroupName()
        {
            var getRow = from row in (new ACSFCZoneGroup().Select_ZoneGroup().AsEnumerable())
                         select row;

            if (getRow.Count() > 0)
            {
                cboZoneGroup.Items.Clear();

                for (int i = 0; i < getRow.Count(); i++)
                {
                    cboZoneGroup.Items.Add(getRow.ElementAt(i).ZoneGroupName);
                }
                cboZoneGroup.Items.Insert(0, "[Select Zone Group]");
                cboZoneGroup.SelectedIndex = 0;
            }
            else
            {
                cboZoneGroup.Items.Clear();
                cboZoneGroup.Text = "No Zone Group";
            }
        }

        void Load_ZoneName(string ZoneGroupName)
        {
            var getRow = from row in (new ACSFCZone().Select_ZoneAndZoneGroup().AsEnumerable())
                         where row.ZoneGroupName.Equals(ZoneGroupName)
                            select row;
            
            if (getRow.Count() > 0)
            {
                zoneGroupID = getRow.First().ZoneGroupID;

                cboZone.Items.Clear();

                for (int i = 0; i < getRow.Count(); i++)
                {
                    cboZone.Items.Add(getRow.ElementAt(i).ZoneName);
                }
                cboZone.Items.Insert(0, "[Select Zone]");
                cboZone.SelectedIndex = 0;
            }
            else
            {
                cboZone.Items.Clear();
                cboZone.Text = "No Zone Found";
            }
        }

        private void ExportData_Load(object sender, EventArgs e)
        {
            Load_ZoneGroupName();
        }

        private void cboZoneGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_ZoneName(cboZoneGroup.Text);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExportFileName.Text))
            {
                MessageBox.Show("Please choose the file name to be exported", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ACSFDataSync localDataSyncService = new ACSFDataSync();
                CounterData data = new CounterData();
                data.TicketsToExport = localDataSyncService.ExportFromServer(Convert.ToInt32(zoneGroupID)).ToList<Ticket>();

                //convert to xml structure
                XmlSerializer serializer = new XmlSerializer(typeof(CounterData));
                MemoryStream ms = new MemoryStream();
                serializer.Serialize(new XmlTextWriter(ms, UTF8Encoding.UTF8), data);
                //important to reset the position
                ms.Position = 0;
                StreamReader sr = new StreamReader(ms);
                //encrypt the xml using counter ID
                string encryptedXml = ACSFCLogEncryptDecrypt.EncryptLog(sr.ReadToEnd());

                //save to the file
                FileInfo datafile = new FileInfo(txtExportFileName.Text);
                if (!datafile.Exists)
                {
                    FileStream fs = datafile.Create();
                    XmlTextWriter xmlWriter = new XmlTextWriter(fs, UTF8Encoding.UTF8);
                    xmlWriter.WriteString(encryptedXml);
                    xmlWriter.Close();
                    MessageBox.Show("Ticket list data is successfully exported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("File with the same name is already existed. \r\nPlease change the file name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void btnBrowserImportFolder_Click(object sender, EventArgs e)
        {
            ofdFileDialog.ShowDialog();
            txtExportFileName.Text = ofdFileDialog.FileName;

            if (txtExportFileName.Text != null || txtExportFileName.Text != "")
                btnExport.Enabled = true;
            else
                btnExport.Enabled = false;
        }

        private void cboZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var filter = from row in (new ACSFCCounter().Select_CounterDetail().AsEnumerable())
                             where row.ZoneName.Equals(cboZone.Text)
                             select row;
                if (filter.Count() > 0)
                {
                    cboCounter.Items.Clear();
                    for (int i = 0; i < filter.Count(); i++)
                    {
                        cboCounter.Items.Add(filter.ElementAt(i).CounterID);
                    }
                    cboCounter.Items.Insert(0, "[Select Counter]");
                    cboCounter.SelectedIndex = 0;
                }
                else
                {
                    cboCounter.Items.Clear();
                    cboCounter.Text = "No Counter Found";
                }
            }
            catch
            {

            }
        }
    }
}
