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
    public partial class formAdminMain : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());
        public formAdminMain()
        {
            InitializeComponent();
        }

        private void btnRegisterAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formAdminRegister().ShowDialog();
        }

        private void btnViewRep_Click(object sender, EventArgs e)
        {
            
            new formReport().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult logOut;
            //Show Message Box and Give User Options to Select Yes/No
            logOut = MessageBox.Show("Do you want to Log Out from the system?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //If User Selected "Yes", Close the Form
            if (logOut == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void fill_ListBox(string query, string accid, string accname, string accphone)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                //Created a List of Objects
                List<StaffInfo> staffs = new List<StaffInfo>();
                
                while (reader.Read())
                {
                    //Deleted Accounts Have ID like "[DEL]RE001", We Don't Show Those Accounts in ListBox
                    if (!reader[accid].ToString().StartsWith("[DEL]"))
                    {
                        //Add an Object to the List of Objects (staffs) using Object Initialiser
                        staffs.Add(new StaffInfo()
                        {
                            Staff_id = reader[accid].ToString(),
                            Staff_name = reader[accname].ToString(),
                            Staff_contact = reader[accphone].ToString()
                        });
                    }
                }
                reader.Close();
                //Show All Objects Inside List of Objects (staffs) to the ListBox
                for (int i = 0; i < staffs.Count; i++)
                {
                    listAcc.Items.Add(staffs[i].ToString());
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not establish the connection to the database!");
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query;
            //If User have Selected Items in the ComboBox
            if (cboxSchAccType.SelectedItem != null)
            {
                //Clear All the Records in the ListBox
                clearListAcc();
                //If the Search Bar is Empty
                if (txtSchAccName.Text == "")
                {
                    switch (cboxSchAccType.SelectedItem.ToString())
                    {
                        case "Technician":
                            query = "SELECT tech_id, tech_name, tech_phone_number FROM technicians";
                            fill_ListBox(query, "tech_id", "tech_name", "tech_phone_number");
                            break;
                        case "Receptionist":
                            query = "SELECT rec_id, rec_name, rec_phone_number FROM receptionists";
                            fill_ListBox(query, "rec_id", "rec_name", "rec_phone_number");
                            break;
                    }
                }
                //If the Search Bar Have Value
                else
                {
                    string name = "'%" + txtSchAccName.Text + "%'";
                    switch (cboxSchAccType.SelectedItem.ToString())
                    {
                        case "Technician":
                            query = "SELECT tech_id, tech_name, tech_phone_number FROM technicians WHERE tech_name LIKE " + name;
                            fill_ListBox(query, "tech_id", "tech_name", "tech_phone_number");
                            break;
                        case "Receptionist":
                            query = "SELECT rec_id, rec_name, rec_phone_number FROM receptionists WHERE rec_name LIKE " + name;
                            fill_ListBox(query, "rec_id", "rec_name", "rec_phone_number");
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an Account Type to Search!");
            }
        }
        
        //Function that Clear All the Records inside ListBox and Add a Column Header
        private void clearListAcc()
        {
            listAcc.Items.Clear();
            listAcc.Items.Add("Staff ID" + "\t\t" + "Name" + "\t\t\t" + "Contact");
        }

        private void btnDeleteAcc_Click(object sender, EventArgs e)
        {
            //If User have Selected an Account Inside the ListBox
            if (listAcc.SelectedItem != null && listAcc.SelectedIndex != 0)
            {
                //Prompt a Window and Give User Options to Select Yes/No
                DialogResult delete;
                delete = MessageBox.Show("Confirm delete account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //If User Selected "Yes"
                if (delete == DialogResult.Yes)
                {
                    string query;
                    string accInfo = listAcc.SelectedItem.ToString();
                    string accID = "";
                    //Extract the ID of Account from the String accInfo
                    for (int i = 0; i < 5; i++)
                    {
                        accID = accID + accInfo[i].ToString();
                    }

                    switch (accID[0].ToString())
                    {
                        //ID for Technician Start With "T"
                        case "T":
                            query = "UPDATE technicians SET tech_id = " + "'[DEL]" + accID + "'" + " WHERE tech_id = " + "'" + accID + "'";
                            delAcc(query);
                            break;
                        //ID for Receptionist Start With "R"
                        case "R":
                            query = "UPDATE receptionists SET rec_id = " + "'[DEL]" + accID + "'" + " WHERE rec_id = " + "'" + accID + "'";
                            delAcc(query);
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("You didn't select any account!");
            }
            
        }

        //Do the Actual Deleting and Remove Item Selected at ListBox
        private void delAcc(string query)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int i = cmd.ExecuteNonQuery();
                if (i != 0)
                {
                    MessageBox.Show("Account has been Successfully Deleted!");
                    listAcc.Items.Remove(listAcc.SelectedItem);
                }
                else
                {
                    MessageBox.Show("Opps! Error Occurs!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not establish the connection to the database!");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
