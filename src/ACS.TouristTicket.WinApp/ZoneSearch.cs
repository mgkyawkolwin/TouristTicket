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
    public partial class ZoneSearch : Form
    {
        public ZoneSearch()
        {
            InitializeComponent();
        }

        void Load_ZoneList()
        {
            try
            {
                dgvZone.DataSource = new ACSFCZone().Select_ZoneAndZoneGroup();

                dgvZone.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvZone.Columns[0].Width = 80;
                dgvZone.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvZone.Columns[0].HeaderText = "Zone ID";

                dgvZone.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvZone.Columns[1].Width = 350;
                dgvZone.Columns[1].HeaderText = "Zone Name";

                dgvZone.Columns[2].Visible = false;

                dgvZone.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvZone.Columns[3].Width = 150;
                dgvZone.Columns[3].HeaderText = "Zone Group";

                dgvZone.Columns[4].Visible = false;
                dgvZone.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {

            }
        }

        private void ZoneSearch_Load(object sender, EventArgs e)
        {
            Load_Zone();
            Load_DistinctZoneGroupName();
            Load_ZoneList();
        }

        void GetZoneInformation_ByZoneGroup(string ZoneGroupName)
        {
            ACSFCZone zone = new ACSFCZone();

            if (ZoneGroupName != "All")
            {
                IEnumerable<Model.ZoneAndZoneGroup> getRow = from row in zone.Select_ZoneAndZoneGroup().AsEnumerable()
                                                             where row.ZoneGroupName.Equals(ZoneGroupName)
                                                             select row;

                dgvZone.DataSource = getRow.ToList();
            }
            else
            {
                dgvZone.DataSource = zone.Select_ZoneAndZoneGroup();
            }

            //dgvZone.Columns[3].Visible = false;
            //dgvZone.Columns[4].Visible = false;
        }

        void GetZoneInformation_ByZone(string Zone)
        {
            ACSFCZone zone = new ACSFCZone();

            if (Zone != "All")
            {
                IEnumerable<Model.ZoneAndZoneGroup> getRow = from row in zone.Select_ZoneAndZoneGroup().AsEnumerable()
                                                             where row.ZoneName.Equals(Zone)
                                                             select row;

                dgvZone.DataSource = getRow.ToList();
            }
            else
            {
                dgvZone.DataSource = zone.Select_ZoneAndZoneGroup();
            }

            //dgvZone.Columns[3].Visible = false;
            //dgvZone.Columns[4].Visible = false;
        }

        void Load_DistinctZoneGroupName()
        {
            var getRow = from row in (new ACSFCZoneGroup().Select_DistinctZoneGroupName().AsEnumerable())
                         select row;

            cboZoneGroup.Items.Clear();

            for (int i = 0; i < getRow.Count(); i++)
            {
                cboZoneGroup.Items.Add(getRow.ElementAt(i).ZoneGroupName);
            }
            cboZoneGroup.Items.Insert(0, "[Select Zone Group]");
        }

        void Load_Zone()
        {
            var getRow = from row in (new ACSFCZone().Select_ZoneAndZoneGroup().AsEnumerable())
                         select row;

            cboZone.Items.Clear();

            for (int i = 0; i < getRow.Count(); i++)
            {
                cboZone.Items.Add(getRow.ElementAt(i).ZoneName);
            }
            cboZone.Items.Insert(0, "[Select Zone]");
        }

        private void rdbZone_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbZone.Checked)
            {
                cboZoneGroup.Enabled = false;
                cboZone.Enabled = true;
            }
        }

        private void rdbZoneGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbZoneGroup.Checked)
            {
                cboZoneGroup.Enabled = true;
                cboZone.Enabled = false;
            }
        }

        private void cboZoneGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboZoneGroup.SelectedIndex > 0)
                GetZoneInformation_ByZoneGroup(cboZoneGroup.Text);
            else
                GetZoneInformation_ByZoneGroup("All");
        }

        private void cboZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboZone.SelectedIndex > 0)
                GetZoneInformation_ByZone(cboZone.Text);
            else
                GetZoneInformation_ByZone("All");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           // ReportLibrary.Classes.Reporting.tt = new ReportLibrary.Classes.Reporting.tt();

            ReportLibrary.Classes.Reporting.View_ZoneAndGroupList((List<ZoneAndZoneGroup>)dgvZone.DataSource);
        }
    }
}
