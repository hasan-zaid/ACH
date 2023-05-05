using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Microsoft.VisualBasic;


namespace ACH
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void userIDtxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(userIDtxtBox.Text) || string.IsNullOrWhiteSpace(userPasswordtxtBox.Text))
            {
                errorProvider1.SetError(loginBtn, "Both fields are required to be filled correctly");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());
                    con.Open();

                    string command_1 = "select * from users_login where user_id =@ID and user_password =@PW";
                    SqlCommand cmd_1 = new SqlCommand(command_1, con);
                    cmd_1.Parameters.AddWithValue("@ID", userIDtxtBox.Text);
                    cmd_1.Parameters.AddWithValue("@PW", userPasswordtxtBox.Text);
                    SqlDataReader credintials = cmd_1.ExecuteReader();

                    credintials.Read();

                    if (credintials.HasRows == true)
                    {
                        string real_id = credintials.GetString(0);
                        string real_password = credintials.GetString(1);
                        string real_role = credintials.GetString(2);
                        string real_name = credintials.GetString(3);

                        if (real_id.ToLower() == userIDtxtBox.Text.ToLower() && real_password == userPasswordtxtBox.Text)
                        {
                            if (real_role == "admin")
                            {
                                MessageBox.Show("You have been logged in successfully :)");
                                this.Hide();
                                formAdminMain r = new formAdminMain();
                                r.ShowDialog();
                                this.Close();
                            }

                            else if (real_role == "receptionist")
                            {
                                MessageBox.Show("You have been logged in successfully :)");
                                this.Hide();
                                receptionistForm frm = new receptionistForm(real_name, real_id);
                                frm.ShowDialog();
                                this.Close();
                            }

                            else if (real_role == "technician")
                            {
                                MessageBox.Show("You have been logged in successfully :)");
                                this.Hide();
                                formTechMain frm = new formTechMain(real_name, real_id);
                                frm.ShowDialog();
                                this.Close();
                            }

                            else if (real_role == "customer")
                            {
                                MessageBox.Show("You have been logged in successfully :)");
                                this.Hide();
                                mainCustomerForm r = new mainCustomerForm(real_name, real_id);
                                r.ShowDialog();
                                this.Close();
                            }
                        }

                    }

                    else
                    {
                        MessageBox.Show("Incorrect username or password ! Please try a again");
                    }
                }

               catch (SqlException ex)
                {
                    MessageBox.Show("There was an error connecting to the database, please contact the system administrator");
                }
            }
            

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginForm_Load(object sender, EventArgs e)
        {
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
