#region  ===============  Source Code Information  ===============
/*
 *  Solution Name 	: ACS.TouristTicket.WinApp
 *  Project Name  	: ReportLibraryProject
 *  Project Type  	: Class Library
 *  Code Platform 	: Microsoft Visual C#.NET 2010
 *  File Name     	: Reporting.cs
 *  
 *  Created Date  	: 7 - Auguest - 2012
 *  Author	      	: Shwe Sin Han
 *  Version	      	: 1.0.0
 *  
 *  Updated Date  	: 
 *  Updated By    	: 
 *  Remark 	      	: 
 *  Version	      	: 
 *  
 *  Copyright (C) 2012 ACS Software Team.  All rights reserved.
*/

#endregion

using System;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;

using ACS.Library.Common;
using ACS.TouristTicket.Common;
using ACS.TouristTicket.Facade;
using ACS.TouristTicket.Model;

namespace ACS.TouristTicket.ReportLibrary.Classes
{
    public class Reporting
    {
        //public const String sReportPath = @"D:\Projects\ACS.TouristTicket.TicketAdmin\ACS.TouristTicket.ReportLibrary\Reports\";
        public const String sReportPath = @"D:\ACS.TouristTicket.TicketAdmin\ACS.TouristTicket.TicketAdmin\ACS.TouristTicket.ReportLibrary\Reports\";

        //View Zone Report
        public static void View_Zone()
        {
            ACS.TouristTicket.DataAccess.TouristTicketContainer obj_TTContainer = new DataAccess.TouristTicketContainer();            
            ReportDataSource rds = new ReportDataSource();            

            rds.Name = "DataSet1";                             
            rds.Value = obj_TTContainer.SelectZone();
         
            ACS.TouristTicket.ReportLibrary.Forms.FrmReportViewer rv = new Forms.FrmReportViewer(rds, sReportPath + "Report16.rdlc");
            rv.Text = "Zone Reporting";
            rv.Show();
        }

        //View Ticket List Report
        public static void View_TicketList(IEnumerable<Model.TicketDetail> getRow)
        {
            ACS.TouristTicket.DataAccess.TouristTicketContainer obj_TTContainer = new DataAccess.TouristTicketContainer();
            ReportDataSource rds = new ReportDataSource();

            rds.Name = "TicketDetail";
            rds.Value = getRow;

            ACS.TouristTicket.ReportLibrary.Forms.FrmReportViewer rv = new Forms.FrmReportViewer(rds, sReportPath + "TicketDetail.rdlc");
            rv.Text = "Ticket List";
            rv.Show();
        }

        //View Ticket List Report 
        public static void View_TicketList(IEnumerable<Model.TicketUnused> getRow)
        {
            ReportDataSource rds = new ReportDataSource();

            rds.Name = "TicketUnused";
            rds.Value = getRow;

            ACS.TouristTicket.ReportLibrary.Forms.FrmReportViewer rv = new Forms.FrmReportViewer(rds, sReportPath + "TicketUnused.rdlc");
            rv.Text = "Ticket Unused";
            rv.Show();
        }

        //View Ticket List Report 
        public static void View_TicketList(IEnumerable<Model.Ticket> getRow)
        {          
            ReportDataSource rds = new ReportDataSource();

            rds.Name = "TicketDetail";
            rds.Value = getRow;

            ACS.TouristTicket.ReportLibrary.Forms.FrmReportViewer rv = new Forms.FrmReportViewer(rds, sReportPath + "TicketDetail.rdlc");
            rv.Text = "Ticket List";
            rv.Show();
        }

        //View Zone And Group List Report
        public static void View_ZoneAndGroupList(IEnumerable<Model.ZoneAndZoneGroup> getRow)
        {
            ReportDataSource rds = new ReportDataSource();

            rds.Name = "ZoneAndZoneGroup";
            rds.Value = getRow;

            ACS.TouristTicket.ReportLibrary.Forms.FrmReportViewer rv = new Forms.FrmReportViewer(rds, sReportPath + "ZoneAndGroupList.rdlc");
            rv.Text = "Zone And Group List";
            rv.Show();
        }

        //View Zone And Group List Report
        public static void View_ZoneAndGroupList(IEnumerable<Model.ZoneGroup> getRow)
        {
            ReportDataSource rds = new ReportDataSource();

            rds.Name = "ZoneAndGroup";
            rds.Value = getRow;

            ACS.TouristTicket.ReportLibrary.Forms.FrmReportViewer rv = new Forms.FrmReportViewer(rds, sReportPath + "Rdlc_ZoneAndGroupList.rdlc");
            rv.Text = "Zone And Group List";
            rv.Show();
        }

        ////View User List Report
        //public static void View_UserList()
        //{
        //    ACS.TouristTicket.DataAccess.TouristTicketContainer obj_TTContainer = new DataAccess.TouristTicketContainer();
        //    ReportDataSource rds = new ReportDataSource();

        //    rds.Name = "DataSet1";
        //    rds.Value = obj_TTContainer.SelectUser();

        //    ACS.TouristTicket.ReportLibrary.Forms.FrmReportViewer rv = new Forms.FrmReportViewer(rds, sReportPath + "Rdlc_UserList.rdlc");
        //    rv.Text = "User List";
        //    rv.Show();
        //}

        //View User Report
        public static void View_UserList(IEnumerable<Model.UserAccessLog> getRow)
        {
            ReportDataSource rds = new ReportDataSource();

            rds.Name = "UserList";
            rds.Value = getRow;

            ACS.TouristTicket.ReportLibrary.Forms.FrmReportViewer rv = new Forms.FrmReportViewer(rds, sReportPath + "UserList.rdlc");
            rv.Text = "User List";
            rv.Show();
        }
    }
}
