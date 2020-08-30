using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace EHR
{
    
    public partial class LoginForm : Telerik.WinControls.UI.RadForm
    {
        public LoginForm()
        {
            InitializeComponent();

            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            string date = thisDay.ToString("D");

            try
            {
                MySqlConnection con = new MySqlConnection("Server=localhost;Database=ehr;username=root;password=;");

                if (txtUserName.Text != "" && txtPassword.Text != "")
                {
                    try
                    {

                        string insertquery = "INSERT INTO login_attempt(`user_name`,`password`,`date`) VALUES('" + txtUserName.Text + " ' , ' " + Protect.Encrypt(txtPassword.Text) + "','" + date + "')";
                        MySqlCommand cmdin = new MySqlCommand(insertquery, con);
                        con.Open();
                        cmdin.ExecuteNonQuery();
                        con.Close();

                        String viewquery = "SELECT * FROM user WHERE user_name = '" + txtUserName.Text + "'";
                        MySqlCommand cmdout = new MySqlCommand(viewquery, con);
                        con.Open();
                        MySqlDataReader rdr = cmdout.ExecuteReader();
                        

                        if (rdr.Read())
                        {
                            string User_name = rdr.GetString(1);
                          
                            string Password = Protect.Decrypt(rdr.GetString(2));
                            
                            if (txtUserName.Text == User_name)
                            {
                                if (txtPassword.Text == Password)
                                {
                                    if (rdr.GetString(3) == "Administrator")
                                    {
                                        
                                        AdminForm frm2 = new AdminForm();
                                        frm2.Show();
                                        this.Hide();
                                    }
                                    else if (rdr.GetString(3) == "Doctor")
                                    {
                                        this.Hide();
                                        DoctorForm frm3 = new DoctorForm();
                                        frm3.Show();
                                    }
                                }
                                else
                                {
                                    lblError.Text = "Incorrect Username/Password. \n Please try again!";
                                    txtUserName.Text = null;
                                    txtPassword.Text = null;
                                }
                            }
                            else
                            {
                                lblError.Text = "Incorrect Username/Password. \n Please try again!";
                                txtUserName.Text = null;
                                txtPassword.Text = null;
                            }
                        }

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
                    lblError.Text = "Please Enter Username/Password";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
