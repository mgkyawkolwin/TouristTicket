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

namespace ACS.TouristTicket.WinApp
{
    public partial class CheckPrintingCode : Form
    {
        public CheckPrintingCode()
        {
            InitializeComponent();
        }

        static bool b;
        public bool _b
        {
            get { return b; }
            set { b = value; }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var code = from row in new ACSFCTicket().SelectPrintingCode()
                       select row;

            if (txtPrintingCode.Text == code.First().ApprovedCode)
                b = true;
            else
                b = false;

            this.Close();
        }

        private void CheckPrintingCode_Load(object sender, EventArgs e)
        {
            txtPrintingCode.Text = "";
            txtPrintingCode.Focus();
        }
    }
}
