#region  ===============  Source Code Information  ===============
/*
 *  Solution Name 	: ACS.TouristTicket.WinApp
 *  Project Name  	: ReportLibraryProject
 *  Project Type  	: Class Library
 *  Code Platform 	: Microsoft Visual C#.NET 2010
 *  File Name     	: FrmReportViewer.cs
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
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace ACS.TouristTicket.ReportLibrary.Forms
{
    public partial class FrmReportViewer : Form
    {        
        #region +++ Constructor and Destructor codes +++
        
        public FrmReportViewer()
        {
            InitializeComponent();
        }       

        public FrmReportViewer(ReportDataSource rds,String sReportPath)
        {
            InitializeComponent();

            this.DisplayLocalReport(rds, sReportPath);
        }

        #endregion

        #region +++ Private Access Function +++       

        private void DisplayLocalReport(ReportDataSource rds,String sReportPath)
        {
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.Reset();
            reportViewer1.LocalReport.Dispose();
            reportViewer1.LocalReport.DataSources.Clear();

            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = sReportPath;
            reportViewer1.RefreshReport(); 
        }

        #endregion        
    }
}

     