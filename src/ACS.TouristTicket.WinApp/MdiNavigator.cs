using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ACS.TouristTicket.WinApp
{
    public static class MdiNavigator
    {
        static Form mdiParent;
        static IList<Form> mdiChildrens;

        static MdiNavigator()
        {
            mdiChildrens = new List<Form>();
        }

        public static void AssignMdiParent(Form form)
        {
            mdiParent = form;
            mdiParent.WindowState = FormWindowState.Maximized;
            mdiParent.IsMdiContainer = true;
        }

        public static void AssignMdiChild(Form form)
        {
            form.Load += new EventHandler(MdiChild_OnLoad);
            form.FormClosing += new FormClosingEventHandler(MdiChild_FormClosing);
            form.FormClosed += new FormClosedEventHandler(MdiChild_FormClosed);
        }

        static void MdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ShowNavigator();
        }

        public static void ShowMdiChild(Form form)
        {
            form.MdiParent = mdiParent;
            //form.ControlBox = false;
            //form.MaximizeBox = false;
            //form.MinimizeBox = false;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.BringToFront();
        }

        static void MdiChild_OnLoad(object sender, EventArgs e)
        {
            //((Form)sender).MdiParent = mdiParent;
        }

        static void MdiChild_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
