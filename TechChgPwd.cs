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

namespace ACH
{
    public partial class formTechChgPw : Form
    {
        string techName, techID;
        public formTechChgPw(string name, string id)
        {
            InitializeComponent();
            techName = name;
            techID = id;
        }

        private void btnSavePw_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());

            try
            {
                con.Open();
                //Trim() Removes the Blank Space Value
                //If TextBox Not Blank
                if (txtCurrentPw.Text.Trim() != "" && txtNewPw1.Text.Trim() != "" && txtNewPw2.Text.Trim() != "")
                {
                    SqlCommand checkPwd = new SqlCommand("SELECT * FROM technicians WHERE tech_id = " + "'" + techID + "'", con);
                    SqlDataReader reader = checkPwd.ExecuteReader();
                    reader.Read();
                    string currentPwd = reader["tech_password"].ToString();
                    reader.Close();
                    if (txtNewPw1.Text == txtNewPw2.Text && txtCurrentPw.Text == currentPwd)
                    {
                        //Created an Object of StaffInfo
                        StaffInfo techinfo = new StaffInfo(techID);
                        //Change the Value of Attribute of the Object
                        techinfo.change_password(txtNewPw1.Text);
                        string query = "UPDATE technicians SET tech_password = " + "'" + techinfo.Staff_password + "'" + " WHERE tech_id = " + "'" + techinfo.Staff_id + "';";
                        string query2 = "UPDATE users_login SET user_password = " + "'" + techinfo.Staff_password + "'" + " WHERE user_id = " + "'" + techinfo.Staff_id + "';";
                        SqlCommand cmd = new SqlCommand(query + query2, con);

                        if (cmd.ExecuteNonQuery() != 0)
                        {
                            MessageBox.Show("Changed Successfully!");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Opps! Error Occurs!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Input Incorrect!");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter new contact number!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
