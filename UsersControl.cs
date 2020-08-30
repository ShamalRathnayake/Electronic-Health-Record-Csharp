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
    
    public partial class UsersControl : UserControl
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=ehr;username=root;password=;");
        public UsersControl()
        {
            InitializeComponent();

            if (rbtnAdmin.IsChecked)
            {
                disable();
            }
            else if (rbtnDoctor.IsChecked)
            {
                enable();

            }
            else {
                MessageBox.Show("Plase Choose User Role");
            }

            viewUsers();
        }

        public void disable()
        {
            txtUserName.Text = "";
            txtPassword1.Text = "";
            txtPassword2.Text = "";
            txtName.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            txtSpecialty.Enabled = false;
        }
        public void enable()
        {
            txtUserName.Text = "";
            txtPassword1.Text = "";
            txtPassword2.Text = "";
            txtName.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtSpecialty.Enabled = true;
        }

        private void rbtnAdmin_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            disable();
        }

        private void rbtnDoctor_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            enable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password1 = txtPassword1.Text;
            string password2 = txtPassword2.Text;
            string name = txtName.Text;
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string specialty = txtSpecialty.Text;

            if (rbtnAdmin.IsChecked)
           {

                
                if (string.IsNullOrWhiteSpace(userName) == false && string.IsNullOrWhiteSpace(password1) == false && string.IsNullOrWhiteSpace(password2) == false)
                {
                    if (password1 == password2)
                    {
                        try
                        {
                            string password = Protect.Encrypt(password1);
                            String query = "INSERT INTO `user`( `user_name`, `password`, `role`) VALUES('" + userName + "','" + password + "','Administrator')";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            con.Close();
                            MessageBox.Show(ex.Message);
                        }


                      
                    }
                    else
                    {
                        MessageBox.Show("password do not match");
                    }
                }
                else
                {
                    MessageBox.Show("Fill all boxes");
                }

          }
           else if (rbtnDoctor.IsChecked)
            {
                if (string.IsNullOrWhiteSpace(userName) == false && string.IsNullOrWhiteSpace(password1) == false && string.IsNullOrWhiteSpace(password2) == false && string.IsNullOrWhiteSpace(name) == false && string.IsNullOrWhiteSpace(phone) == false && string.IsNullOrWhiteSpace(email) == false && string.IsNullOrWhiteSpace(specialty) == false)
                {
                    if (password1 == password2)
                    {
                        try
                        {
                            string password = Protect.Encrypt(password1);
                            String query = "INSERT INTO `user`( `user_name`, `password`, `role`) VALUES('" + userName + "','" + password + "','Doctor')";
                            
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            String query1 = "INSERT INTO `doctor`(`name`,`phone`,`email`,`specialty`) VALUES('" + name + "','" + phone + "','" + email + "','" + specialty + "')";
                            MySqlCommand cmd1 = new MySqlCommand(query1, con);
                            con.Open();
                            cmd1.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            con.Close();
                            MessageBox.Show(ex.Message);
                        }




                    }
                    else
                    {
                        MessageBox.Show("password do not match");
                    }
                }
                else
                {
                    MessageBox.Show("Fill all boxes");
                }

            }
            viewUsers();

            txtUserName.Text = "";
            txtPassword1.Text = "";
            txtPassword2.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtSpecialty.Text = "";
        }
        public void viewUsers()
        {
            try
            {
                 String query2 = "SELECT id,user_name,role FROM user;";
            MySqlDataAdapter adp = new MySqlDataAdapter(query2, con);
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            radGridView2.DataSource = dt;
            con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }

            
                        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
             String query3 = "DELETE FROM user WHERE id= "+txtId.Text+"";
            MySqlCommand cmd3 = new MySqlCommand(query3, con);
            con.Open();
            cmd3.ExecuteNonQuery();
            con.Close();
            txtId.Text = "";
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
            viewUsers();
        }
    }
}
