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
    public partial class cusChangPassForm : Form
    {
        string  cus_Name, cusID;
        public cusChangPassForm(string name, string id)
        {
            InitializeComponent();
            cus_Name = name;
            cusID = id;
        }

        private void cusChangPassForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());



            try
            {
                con.Open();
                //Trim() Removes the Blank Space Value
                //If TextBox Not Blank
                if (CurrentPasswordtxt.Text.Trim() != "" && NewPasswordtxt.Text.Trim() != "" && ConfirmPasswordtxt.Text.Trim() != "")
                {
                    SqlCommand checkPwd = new SqlCommand("SELECT * FROM customers WHERE cus_ID = " + "'" + cusID + "'", con);
                    SqlDataReader reader = checkPwd.ExecuteReader();
                    reader.Read();
                    string currentPwd = reader["cus_password"].ToString();
                    reader.Close();
                    if (ConfirmPasswordtxt.Text == NewPasswordtxt.Text && CurrentPasswordtxt.Text == currentPwd)
                    {

                        customerNumber cusfo = new customerNumber(cusID);
                        cusfo.change_password(NewPasswordtxt.Text);
                        string query = "UPDATE customers SET cus_password = " + "'" + cusfo.Cus_password + "'" + " WHERE cus_id = " + "'" + cusfo.Cus_id + "';";
                        string query_2 = "update users_login set user_password = " + "'" + cusfo.Cus_password + "'" + " Where user_id = " + "'" + cusfo.Cus_id + "';";
                        SqlCommand cmd = new SqlCommand(query + query_2, con);

                        if (cmd.ExecuteNonQuery() != 0)
                        {
                            MessageBox.Show("Changed Successfully!");
                            //new formProfile().Refresh();
                            con.Close();
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
                    MessageBox.Show("Please enter new password !");
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
