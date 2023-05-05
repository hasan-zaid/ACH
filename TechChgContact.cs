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
    public partial class formTechChangeContact : Form
    {
        string techName, techID;
        public formTechChangeContact(string name, string id)
        {
            InitializeComponent();
            techName = name;
            techID = id;
        }

        private void btnSaveContact_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());

            try
            {
                con.Open();
                //Trim() Removes the Blank Space Value
                //If TextBox Not Blank AND TextBox Does Not Contain Any Alphabet
                if (txtNewContact.Text.Trim() != "" && !txtNewContact.Text.Any(Char.IsLetter))
                {
                    //Created an Object of StaffInfo
                    StaffInfo techinfo = new StaffInfo(techID);
                    //Change the Value of Attribute of the Object
                    techinfo.change_contact(txtNewContact.Text);
                    string query = "UPDATE technicians SET tech_phone_number = " + "'" + techinfo.Staff_contact + "'" + " WHERE tech_id = " + "'" + techinfo.Staff_id + "'";
                    SqlCommand cmd = new SqlCommand(query, con);

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
