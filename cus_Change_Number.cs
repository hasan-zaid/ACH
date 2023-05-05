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
    public partial class cusChangNumForm : Form
    {
        string cus_Name, cusID;
        public cusChangNumForm(string name, string id)
        {
            InitializeComponent();
            cus_Name = name;
            cusID = id;
        }

        private void cusChangNumForm_Load(object sender, EventArgs e)
        {

        }

        private void bntSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());


            try
            {
                con.Open();
                //Trim() Removes the Blank Space Value
                //If TextBox Not Blank AND TextBox Does Not Contain Any Alphabet
                if (NewContactNumbertxt.Text.Trim() != "" && !NewContactNumbertxt.Text.Any(Char.IsLetter))
                {

                        //Created an Object of customerNumber
                        customerNumber cusinfo = new customerNumber(cusID);
                       //Change the Value of Attribute of the Object
                        cusinfo.change_contact(NewContactNumbertxt.Text);
                        string query = "UPDATE customers SET cus_phone_number = " + "'" + cusinfo.Cus_contact + "'" + " WHERE cus_id = " + "'" + cusinfo.Cus_id + "'";
                        SqlCommand cmd = new SqlCommand(query, con);

                        if (cmd.ExecuteNonQuery() != 0)
                        {
                            MessageBox.Show("Changed Successfully!");
                            //new formProfile().Refresh();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Opps! Error Occurs!");
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
