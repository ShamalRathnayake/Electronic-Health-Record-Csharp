using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using ZXing;
using AForge.Video;
using MySql.Data.MySqlClient;
using Telerik.WinForms.Documents.Model.Styles;
using System.Windows.Documents;

namespace EHR
{
    public partial class ScanControl : UserControl
    {
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice captureDevice;
        public ScanControl()
        {
            InitializeComponent();

            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
            {
                cboDevice.Items.Add(filterInfo.Name);
            }
            cboDevice.SelectedIndex = 0;

            



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            captureDevice = new VideoCaptureDevice(FilterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
            txtPtName.Text = "";
            txtPtAge.Text = "";
            txtPtEmail.Text = "";
            txtPtAddress.Text = "";
            txtPtPhone.Text = "";
            txtPtAllergies.Text = "";
            txtPtMeds.Text = "";
            txtPtIll.Text = "";
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

         string id;

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox.Image != null)
                {
                    BarcodeReader barcodeReader = new BarcodeReader();
                    Result result = barcodeReader.Decode((Bitmap)pictureBox.Image);
                    if (result != null) { 

                        
                       id = result.ToString();
                        if (captureDevice.IsRunning)
                        {
                            captureDevice.Stop();
                        }
                        ViewPatientData(id);
                        







                        
                    }
                }
            }
            catch (Exception )
            {

                
            }
            
        }

        string checkid;
        private void ViewPatientData(string idNo)
        {
            if (idNo != checkid)
            {
                checkid = idNo;
                try
                {

                    MySqlConnection con = new MySqlConnection("Server=localhost;Database=ehr;username=root;password=;");
                    string viewquery = "SELECT * FROM patient WHERE id = '" + idNo + "'";
                    MySqlCommand cmdout = new MySqlCommand(viewquery, con);
                    con.Open();
                    MySqlDataReader rdr = cmdout.ExecuteReader();
                    if (rdr.Read())
                    {

                        txtPtName.Text = rdr.GetString(1);
                        txtPtAge.Text = rdr.GetString(2);
                        txtPtEmail.Text = rdr.GetString(3);
                        txtPtAddress.Text = rdr.GetString(4);
                        txtPtPhone.Text = rdr.GetString(5);
                        txtPtAllergies.Text = rdr.GetString(6);
                        txtPtMeds.Text = rdr.GetString(7);
                        txtPtIll.Text = rdr.GetString(8);


                    }
                    con.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        public void camClose()
        {
            
                if (captureDevice.IsRunning)
                {
                    captureDevice.Stop();
                }
            
            
        }

        private void ScanControl_Load(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(FilterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void btnTreat_Click(object sender, EventArgs e)
        {
            TreatControl tc = new TreatControl();
           
           
            this.Hide();
            this.Parent.Controls.Add(tc);
            tc.getPtData(id);
        }

        
    }
}
