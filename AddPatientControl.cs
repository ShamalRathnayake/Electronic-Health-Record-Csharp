using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ZXing.QrCode.Internal;
using ZXing.QrCode;
using ZXing;
using System.Drawing.Printing;

namespace EHR
{
    public partial class AddPatientControl : UserControl
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=ehr;username=root;password=;");
        public AddPatientControl()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string patientName = txtPtName.Text;
            string patientAge = txtPtAge.Text;
            string patientEmail = txtPtEmail.Text;
            string patientAddress = txtPtAddress.Text;
            string patientPhone = txtPtPhone.Text;
            string patientAllergies = txtPtAllergies.Text;
            string patientPreMeds = txtPtMeds.Text;
            string patientPreIll = txtPtIll.Text;



            if (string.IsNullOrWhiteSpace(patientName) == false && string.IsNullOrWhiteSpace(patientAge) == false )
            {
                string query = "INSERT INTO `patient`(`name`, `age`, `email`, `address`, `phone`, `allergies`, `preMed`, `preIll`) VALUES ('" + patientName +"','"+ patientAge +"','"+patientEmail+"','"+patientAddress +"','"+ patientPhone  +"','"+patientAllergies+"','"+patientPreMeds+"','"+patientPreIll+"');";
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();


                txtPtName.Text="";
                txtPtAge.Text="";
                txtPtEmail.Text="";
                txtPtAddress.Text="";
                txtPtPhone.Text="";
                txtPtAllergies.Text="";
                txtPtMeds.Text="";
                txtPtIll.Text="";


                string query1 = "SELECT id FROM patient WHERE name = '"+patientName+"' AND age = '"+patientAge+"' AND email = '"+patientEmail+"' AND address = '"+patientAddress+"' AND phone = '"+patientPhone+"';";
                MySqlCommand cmd1 = new MySqlCommand(query1, con);
                con.Open();
                int id = (Int32)cmd1.ExecuteScalar();
                con.Close();


                QrCodeEncodingOptions options = new QrCodeEncodingOptions();

                options = new QrCodeEncodingOptions
                {
                    DisableECI = true,
                    CharacterSet = "UTF-8",
                    Width = 250,
                    Height = 250,
                };
                var writer = new BarcodeWriter();
                writer.Format = BarcodeFormat.QR_CODE;
                writer.Options = options;

                

                if (string.IsNullOrWhiteSpace(id.ToString()) || string.IsNullOrEmpty(id.ToString()))
                {
                    pictureBox1.Image = null;
                    MessageBox.Show("Unable to Generate QR Code", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var qr = new ZXing.BarcodeWriter();
                    qr.Options = options;
                    qr.Format = ZXing.BarcodeFormat.QR_CODE;
                    var result = new Bitmap(qr.Write(id.ToString()));
                    pictureBox1.Image = result;
                    
                }
                

            }
            else
            {
                con.Close();
                MessageBox.Show("Please Fill Patient's Name and Age");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();
        }
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }

        
    }
}
