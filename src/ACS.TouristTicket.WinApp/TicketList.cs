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
    public partial class TicketList : Form
    {
        private bool blnPrint = false;

        List<TicketDetail> ticketDetail;
        List<TicketUnused> ticketUnused;

        public TicketList()
        {
            InitializeComponent();
        }

        void Load_ZoneGroupName()
        {
            var getRow = from row in (new ACSFCZoneGroup().Select_ZoneGroup().AsEnumerable())
                         select row;

            cboZoneGroup.Items.Clear();

            for (int i = 0; i < getRow.Count(); i++)
            {
                cboZoneGroup.Items.Add(getRow.ElementAt(i).ZoneGroupName);
            }
            cboZoneGroup.Items.Insert(0, "[SELECT ALL]");
        }

        public List<Ticket> GetTicketList()
        {
            List<Ticket> selected = new List<Ticket>();

            try
            {
                foreach (DataGridViewRow row in dgvList.Rows)
                {
                    object value = row.Cells["colSelect"].Value;
                    if (value != null && (Boolean)value == true)
                    {
                        var getRow = (from gRow in new ACSFCTicket().Select_Ticket()
                                      where gRow.PKID.Equals(Convert.ToInt32(row.Cells["colSerialNo"].Value))
                                      select gRow).FirstOrDefault<Ticket>();

                        selected.Add(getRow);
                    }
                }
            }
            catch ( Exception ex)
            {

            }
            return selected;
        }

        public List<TicketDetail> GetTicketDetail()
        {
            List<TicketDetail> selected = new List<TicketDetail>();

            try
            {
                foreach (DataGridViewRow row in dgvList.Rows)
                {
                    object value = row.Cells["colSelect"].Value;
                    if (value != null && (Boolean)value == true)
                    {
                        var getRow = (from gRow in ticketDetail
                                      where gRow.PKID.Equals(Convert.ToInt32(row.Cells["colSerialNo"].Value))
                                      select gRow).FirstOrDefault<TicketDetail>();

                        selected.Add(getRow);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return selected;
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
                        var getRow =(from gRow in new ACSFCTicketUnused().Select_TicketDamages()
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

        private void TicketList_Load(object sender, EventArgs e)
        {
            blnPrint = false;
            
            //Ticket Condition Combo 
            cboStatus.Items.Add("[SELECT ALL]");
            cboStatus.Items.Add("NEW");
            cboStatus.Items.Add("PRINTED");
            cboStatus.Items.Add("ACTIVATED");
            cboStatus.Items.Add("USED");
            cboStatus.Items.Add("EXPIRED");
            cboStatus.Items.Add("UNUSED");
            cboStatus.SelectedIndex = 0;

            Load_ZoneGroupName();

            cboTicket_Condition_SelectedIndexChanged(null, null);
        }

        private void cboTicket_Condition_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboStatus.SelectedIndex == 1)
                    btnPrintView.Enabled = true;
                else
                    btnPrintView.Enabled = false;

                if (cboStatus.SelectedIndex == 6)
                    btnUnused.Enabled = true;
                else
                    btnUnused.Enabled = false;

                btnSearch_Click(null, null);
            }
            catch ( Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Selecting Ticket List", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        } 

        private void btnSearch_Click(object sender, EventArgs e)
        {
            IFormatProvider format = new System.Globalization.CultureInfo("en-GB");
            IList<Model.TicketDetail> tickets = new ACSFCTicket().SelectTicketCollectionsUsingFilters
                (
                    chkTicketSerial.Checked ? new Nullable<int>(Convert.ToInt32(txtSerialNoFrom.Text)) : null,
                    chkTicketSerial.Checked ? new Nullable<int>(Convert.ToInt32(txtSerialNoTo.Text)) : null,
                    chkTicketInZone.Checked ? (cboZoneGroup.SelectedIndex > 0 ? cboZoneGroup.Text : null) : null,
                    cboStatus.SelectedIndex > 0 ? cboStatus.Text : null,
                    chkCreatedDate.Checked ? new Nullable<DateTime>(Convert.ToDateTime(dtCreated1.Value.ToString("dd/MM/yyyy"), format)) : null,
                    chkCreatedDate.Checked ? new Nullable<DateTime>(Convert.ToDateTime(dtCreated2.Value.ToString("dd/MM/yyyy") + " 23:59", format)) : null
                );
            dgvList.DataSource = tickets;
            ticketDetail = tickets.ToList();
        }

        void CheckBoxColumn_Status()
        {
            for (int i = 0; i < dgvList.RowCount; i++)
            {
                if (dgvList.Rows[i].Cells["colStatus"].Value != null)
                {
                    if (dgvList.Rows[i].Cells["colStatus"].Value.ToString() == "NEW")
                        dgvList.Rows[i].Cells["colSelect"].ReadOnly = false;
                    else
                        dgvList.Rows[i].Cells["colSelect"].ReadOnly = true;
                }
            }
        }

        private void GetTicketList_ByStatus(String sTicketStatus, byte iPrint = 0)
        {
            if (sTicketStatus == "[SELECT ALL]")
            {
                dgvList.AutoGenerateColumns = false;
                dgvList.DataSource = new ACSFCTicket().Select_TicketDetail();

                if (dgvList.RowCount > 0)
                    CheckBoxColumn_Status();
            }
            else
            {
                ACSFCTicket ticketList = new ACSFCTicket();
                IEnumerable<Model.TicketDetail> getRow = from cols in ticketList.Select_TicketDetail().AsEnumerable()
                                                   where cols.TicketStatus.Equals(sTicketStatus)
                                                   select cols;

                dgvList.AutoGenerateColumns = false;

                if (getRow.Count() > 0)
                {
                    //dgvList.DataSource = getRow.ToList();
                    //if (iPrint == 1)
                    //{
                    //    ReportLibrary.Classes.Reporting.View_TicketList();
                    //}
                    //else
                    //{
                    //    dgvList.DataSource = getRow.ToList();
                    //}
                }
                else
                {
                    dgvList.DataSource = null;
                }
            }

            if (dgvList.RowCount > 0)
                CheckBoxColumn_Status();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvList.DataSource != null)
                {
                    if (chkSelected.Checked)
                        ReportLibrary.Classes.Reporting.View_TicketList(GetTicketDetail());
                    else
                        ReportLibrary.Classes.Reporting.View_TicketList((List<TicketDetail>)dgvList.DataSource);
                }
                else
                {
                    MessageBox.Show("Please search the records first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch ( Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Ticket List Report View", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        static bool IsPrinted;
        public bool isPrinted
        {
            get { return IsPrinted; }
            set { IsPrinted = value; }
        }

        private void btnPrintView_Click(object sender, EventArgs e)
        {
            try
            {
                TicketPreview ticketPreview = new TicketPreview();

                var getRow = from row in (new ACSFCTicket().Select_Ticket().AsEnumerable())
                             where row.TicketStatus.Equals("NEW")
                             select row;

                if (chkSelected.Checked)
                    ticketPreview._ticketCollection = GetTicketList();
                else
                    ticketPreview._ticketCollection = getRow.ToList();

                MdiNavigator.AssignMdiChild(ticketPreview);
                MdiNavigator.ShowMdiChild(ticketPreview);

                if (IsPrinted)
                {
                    for (int i = 0; i < dgvList.RowCount; i++)
                    {
                        dgvList.Rows[i].Cells["colStatus"].Value = "PRINTED";
                    }
                }
            }
            catch ( Exception ex)
            {
                new ACSFCExceptionLog().Insert_ExceptionLog(ex.Message, ex.StackTrace, DateTime.Now);
                MessageBox.Show("Enexpected exception occured and current process failed to perform !\n\nPlease contact to your system administrator", "Generating Ticket Card", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (dgvList.CurrentRow.Cells["colStatus"].Value.ToString() == "NEW" || dgvList.CurrentRow.Cells["colStatus"].Value.ToString() == "UNUSED")
                {
                    dgvList.Columns[e.ColumnIndex].ReadOnly = false;
                    object value = dgvList.CurrentRow.Cells["colSelect"].Value;

                    if (value != null && (Boolean)value == true)
                        dgvList.CurrentRow.Cells[e.ColumnIndex].Value = false;
                    else
                        dgvList.CurrentRow.Cells[e.ColumnIndex].Value = true;
                }
                else
                    dgvList.Columns[e.ColumnIndex].ReadOnly = true;
            }

            //                  
        }

        private void chkTicketSerial_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTicketSerial.Checked)
            {
                txtSerialNoFrom.Enabled = true;
                txtSerialNoTo.Enabled = true;
            }
            else
            {
                txtSerialNoFrom.Enabled = false;
                txtSerialNoTo.Enabled = false;
            }
        }

        private void chkTicketInZone_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTicketInZone.Checked)
                cboZoneGroup.Enabled = true;
            else
                cboZoneGroup.Enabled = false;
        }

        private void chkCreatedDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCreatedDate.Checked)
            {
                dtCreated1.Enabled = true;
                dtCreated2.Enabled = true;
            }
            else
            {
                dtCreated1.Enabled = false;
                dtCreated2.Enabled = false;
            }
        }

        private void btnUnused_Click(object sender, EventArgs e)
        {
            if (dgvList.DataSource != null)
            {
                UnusedTicketList unusedList = new FormFactory().CreateUnusedTicketList();

                if (chkSelected.Checked)
                    unusedList.GetUnusedList(GetTicketUnused());
                else
                    unusedList.GetUnusedList(new ACSFCTicketUnused().Select_TicketDamages());

                unusedList.Show();
            }
            else
            {
                MessageBox.Show("Please search the records first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }       
    }
}
