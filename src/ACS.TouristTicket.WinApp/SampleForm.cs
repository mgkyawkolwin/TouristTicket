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
    public partial class SampleForm : Form
    {
        public SampleForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRetrieve_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = new ACSFCUser().UserLogin("addmin", "admin123"); //new ACSFSample().GetSampleData();
            }
            catch (Exception ex)
            {
                //log exception to database
                //show message box to user informing the error and necessary action to do
            }
        }

        private void txtInsert_Click(object sender, EventArgs e)
        {
            try
            {
                new ACSFSample().InsertSampleData(txtSampleData.Text);
            }
            catch (Exception ex)
            {
                //log exception to database
                //show message box to user informing the error and necessary action to do
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                List<SampleObject> data = new List<SampleObject>((IEnumerable<SampleObject>)dataGridView1.DataSource);
                new ACSFSample().UpdateSampleData(data);
            }
            catch (Exception ex)
            {
                //log exception to database
                //show message box to user informing the error and necessary action to do
            }
        }

        private void SampleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
