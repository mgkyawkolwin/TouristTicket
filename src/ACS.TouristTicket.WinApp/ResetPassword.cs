﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACS.TouristTicket.WinApp
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        public void ShowPassword(string userid, string displayname)
        {
            txtUserID.Text = userid;
            txtDisplayName.Text = displayname;
        }
    }
}
