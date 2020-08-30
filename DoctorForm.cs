using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace EHR
{
    public partial class DoctorForm : Telerik.WinControls.UI.RadForm
    {

        ScanControl sctrl = new ScanControl();
        AddPatientControl addptctrl = new AddPatientControl();
        TreatControl tctrl = new TreatControl();
        PatientControl pctrl = new PatientControl();
        public DoctorForm()
        {
            InitializeComponent();

            doctorPanelContainer.Controls.Add(sctrl);
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            doctorPanelContainer.Controls.Clear();
            doctorPanelContainer.Controls.Add(sctrl);
        }

        private void DoctorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sctrl.camClose();
            sctrl.Dispose();
            Application.Exit();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            doctorPanelContainer.Controls.Clear();
            doctorPanelContainer.Controls.Add(addptctrl);
            sctrl.camClose();
        }

        private void btnTreat_Click(object sender, EventArgs e)
        {
            doctorPanelContainer.Controls.Clear();
            doctorPanelContainer.Controls.Add(tctrl);
            sctrl.camClose();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            doctorPanelContainer.Controls.Clear();
            doctorPanelContainer.Controls.Add(pctrl);
            pctrl.showPatients();
            sctrl.camClose();
        }
    }
}
