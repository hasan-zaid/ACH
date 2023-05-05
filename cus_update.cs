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
    public partial class customerUpdateProfile : Form
    {
        string cus_Name, cus_id;
        public customerUpdateProfile(string name, string id)
        {
            InitializeComponent();
            cus_Name = name;          
            cus_id = id;
          

        }

        private void label6_Click(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());

            //Fill in the Personal Detail of customer into Labels
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM customers WHERE cus_id = " + "'" + cus_id + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int cusPwdLength = reader["cus_password"].ToString().Length;

                labelID.Text = cus_id;
                labelName.Text = reader["cus_name"].ToString();
                //Repeat "*" for a Specific Number of Time (Int techPwdLength)
                labelPass.Text = new string('*', cusPwdLength);
                labelNum.Text = reader["cus_phone_number"].ToString();
                reader.Close();
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not establish the connection to the database!");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            new cusChangPassForm(cus_Name, cus_id).ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void customerChangeNumberBtn_Click(object sender, EventArgs e)
        {
            new cusChangNumForm(cus_Name, cus_id).ShowDialog();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            new mainCustomerForm(cus_Name, cus_id).ShowDialog();
        }
    }
}
