using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace EHR
{
    public partial class AdminForm : Telerik.WinControls.UI.RadForm
    {
        private dashboardControl dash = new dashboardControl();
        private UsersControl usr = new UsersControl();
        private LoginsControl lgn = new LoginsControl();
        private DoctorControl dcl = new DoctorControl();
            
        public AdminForm()
        {
            InitializeComponent();

            adminPanelContainer.Controls.Add(dash);
        }


        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            adminPanelContainer.Controls.Clear();
            adminPanelContainer.Controls.Add(dash);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            adminPanelContainer.Controls.Clear();
            adminPanelContainer.Controls.Add(usr);
        }

        private void btnLogins_Click(object sender, EventArgs e)
        {
            adminPanelContainer.Controls.Clear();
            adminPanelContainer.Controls.Add(lgn);
            lgn.showLogins();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            adminPanelContainer.Controls.Clear();
            adminPanelContainer.Controls.Add(dcl);
            dcl.showDoctors();
        }
    }
}
