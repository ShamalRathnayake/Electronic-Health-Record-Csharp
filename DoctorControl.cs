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
    public partial class DoctorControl : UserControl
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=ehr;username=root;password=;");
        public DoctorControl()
        {
            InitializeComponent();


            showDoctors();

        }
        public void showDoctors()
        {
            try
            {
                string query = "SELECT * FROM doctor;";
                MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                radGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
