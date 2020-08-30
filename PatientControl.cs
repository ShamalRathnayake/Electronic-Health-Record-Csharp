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
    public partial class PatientControl : UserControl
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=ehr;username=root;password=;");
        public PatientControl()
        {
            InitializeComponent();
            showPatients();
        }

        public void showPatients()
        {
            try
            {
                string query = "SELECT * FROM patient";
                MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                con.Open();
                adp.Fill(dt);
                radGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

    }
}
