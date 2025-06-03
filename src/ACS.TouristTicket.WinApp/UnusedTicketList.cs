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
using ACS.TouristTicket.ReportLibrary;

namespace ACS.TouristTicket.WinApp
{
    public partial class UnusedTicketList : Form
    {
        public UnusedTicketList()
        {
            InitializeComponent();
        }

        public void GetUnusedList(List<TicketUnused> get)
        {
            dgvList.AutoGenerateColumns = false;
            dgvList.DataSource = get;
        }

        private void UnusedTicketList_Load(object sender, EventArgs e)
        {

        }

        public List<TicketUnused> GetTicketUnused()
        {
            List<TicketUnused> selected = new List<TicketUnused>();

            try
            {
                foreach (DataGridViewRow row in dgvList.Rows)
                {
                    object value = row.Cells["colSelect"].Value;
                    if (value != null && (Boolean)value == true)
                    {
                        var getRow = (from gRow in new ACSFCTicketUnused().Select_TicketDamages()
                                      where gRow.SerialNo.Equals(row.Cells["colSerialNo"].Value.ToString())
                                      select gRow).FirstOrDefault<TicketUnused>();

                        selected.Add(getRow);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return selected;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (dgvList.DataSource != null)
            {
                if (chkSelected.Checked)
                    ReportLibrary.Classes.Reporting.View_TicketList(GetTicketUnused());
                else
                    ReportLibrary.Classes.Reporting.View_TicketList((List<TicketUnused>)dgvList.DataSource);
            }
            else
            {
                MessageBox.Show("Please search the records first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                    //dgvList.Columns[e.ColumnIndex].ReadOnly = false;
                    object value = dgvList.CurrentRow.Cells["colSelect"].Value;

                    if (value != null && (Boolean)value == true)
                        dgvList.CurrentRow.Cells[e.ColumnIndex].Value = false;
                    else
                        dgvList.CurrentRow.Cells[e.ColumnIndex].Value = true;
            }
        }
    }
}
