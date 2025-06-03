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
    public partial class PrintingCode : Form
    {
        public PrintingCode()
        {
            InitializeComponent();
        }

        private void PrintingCode_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to define printing approved code ?\n\nApprove code: " + txtPrintingCode.Text, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                new ACSFCTicket().InsertPrintingCode(txtPrintingCode.Text);
                MessageBox.Show("Printing Approved Code Inserted !", "Defined Approved Code", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
