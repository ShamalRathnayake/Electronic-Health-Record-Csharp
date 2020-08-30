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

namespace EHR
{
    public partial class TreatControl : UserControl
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=ehr;username=root;password=;");
        public TreatControl()
        {
            InitializeComponent();


        }

        private void btnScanAgain_Click(object sender, EventArgs e)
        {
            ScanControl sc = new ScanControl();
            this.Hide();
            this.Parent.Controls.Add(sc);
        }



        string nameid;

        public void getPtData(string ptid)
        {
            try
            {
                
                
                string viewquery = "SELECT preIll,preMed FROM patient WHERE id = '" + ptid + "'";
                MySqlCommand cmdout = new MySqlCommand(viewquery, con);
                con.Open();
                MySqlDataReader rdr = cmdout.ExecuteReader();
                if (rdr.Read())
                {

                    txtPreIll.Text = rdr.GetString(0);
                    txtPreMed.Text = rdr.GetString(1);

                }
                con.Close();
                nameid = ptid;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrescribe_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (string.IsNullOrEmpty(txtNewMed.Text)||string.IsNullOrWhiteSpace(txtNewMed.Text))
                {
                    MessageBox.Show("Please Enter Medications!!");
                }
                else
                {
                    string query1 = "UPDATE patient SET preIll = CONCAT( '\n',preIll, '\n','" + txtCurIll.Text + "'),preMed = CONCAT( '\n',preMed, '\n','" + txtNewMed.Text + "') WHERE id = '" + nameid + "' ";
                    MySqlCommand cmd1 = new MySqlCommand(query1, con);
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();

                    txtCurIll.Text = "";
                    txtNewMed.Text = "";

                    getPtData(nameid);



                }






            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }

        }

        
    }


}
