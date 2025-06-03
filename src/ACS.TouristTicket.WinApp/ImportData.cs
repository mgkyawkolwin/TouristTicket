using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using ACS.TouristTicket.Model;
using ACS.TouristTicket.Facade;

namespace ACS.TouristTicket.WinApp
{
    public partial class Import_Data : Form
    {
        public Import_Data()
        {
            InitializeComponent();
        }

        private void ImportToCentralServer()
        {
            FileInfo datafile = new FileInfo(tbxImportFileName.Text);
            if (datafile.Exists)
            {
                FileStream fs = datafile.OpenRead();
                StreamReader reader = new StreamReader(fs);
                string encryptedXml = reader.ReadToEnd();
                reader.Close();
                string xmlLog = ACSFCLogEncryptDecrypt.DecryptLog(encryptedXml);

                CounterData data = new CounterData();
                //convert to xml structure
                XmlSerializer serializer = new XmlSerializer(typeof(CounterData));
                data = (CounterData)serializer.Deserialize(new MemoryStream(UTF8Encoding.UTF8.GetBytes(xmlLog)));               

                //TO DO: la da, use the logs inside "data" and refer to my DataSync to call the service to insert Activation/Usage logs to server.

                //ACSUploadTicketActivationLogRequest request = new ACSUploadTicketActivationLogRequest();
                
                //request.TicketActivationLogs = data.ActivationLogs;

                dgvList.AutoGenerateColumns = true;
                dgvList.DataSource = data.TicketsToExport; // request.TicketActivationLogs;

                //new ACSFDataSync().UploadTicketActivationLog(request);

                MessageBox.Show("Counter data is successfully imported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ExportToFile()
        {
            //if (string.IsNullOrWhiteSpace(tbxExportFileName.Text))
            //{
            //    MessageBox.Show("Please choose the file name to be exported", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    ACSFDataSync localDataSyncService = new ACSFDataSync();
            //    CounterData data = new CounterData();
            //    data.ActivationLogs = localDataSyncService.RetrieveTicketActivationLog().ToList<TicketActivationLog>();
            //    data.UsageLogs = localDataSyncService.RetrieveTicketUsageLog().ToList<TicketUsageLog>();
            //    //convert to xml structure
            //    XmlSerializer serializer = new XmlSerializer(typeof(CounterData));
            //    MemoryStream ms = new MemoryStream();
            //    serializer.Serialize(new XmlTextWriter(ms, UTF8Encoding.UTF8), data);
            //    //important to reset the position
            //    ms.Position = 0;
            //    StreamReader sr = new StreamReader(ms);
            //    //encrypt the xml using counter ID
            //    string encryptedXml = ACSFCLogEncryptDecrypt.EncryptLog(sr.ReadToEnd());

            //    //save to the file
            //    FileInfo datafile = new FileInfo(tbxExportFileName.Text);
            //    if (!datafile.Exists)
            //    {
            //        FileStream fs = datafile.Create();
            //        XmlTextWriter xmlWriter = new XmlTextWriter(fs, UTF8Encoding.UTF8);
            //        xmlWriter.WriteString(encryptedXml);
            //        xmlWriter.Close();
            //        MessageBox.Show("Counter data is successfully exported.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Fille with the same name is already existed. \r\nPlease change the file name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ImportToCentralServer();
        }

        private void btnBrowserImportFolder_Click(object sender, EventArgs e)
        {
            ofdFileDialog.ShowDialog(this);
            tbxImportFileName.Text = ofdFileDialog.FileName;
        }
    }
}
