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
    public partial class formAdminRegister : Form
    {
        public formAdminRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());
            string query;
            string query2;
            int validate;

            try
            {
                con.Open();
                //Check if All Inputs Have Done
                if (cboxRegAccType.SelectedItem != null && cboxRegBDay.SelectedItem != null && cboxRegBMonth.SelectedItem != null && cboxRegBYear.SelectedItem != null && txtRegName.Text.Trim() != "" && txtRegContact.Text.Trim() != "")
                {
                    switch (cboxRegAccType.SelectedItem.ToString())
                    {
                        case "Technician":
                            int TechCount = 1;
                            string Tech = "TC";
                            string TechID;
                            SqlCommand TechCountCmd = new SqlCommand("SELECT tech_id FROM technicians", con);
                            SqlDataReader TechCountRdr = TechCountCmd.ExecuteReader();
                            //Count the Number of Technician Inside the Table
                            while (TechCountRdr.Read())
                            {
                                TechCount++;
                            }
                            TechCountRdr.Close();
                            //Generate ID for New Technician
                            TechID = idGenerator(Tech, TechCount);

                            //Created an Object of StaffInfo
                            StaffInfo techData = new StaffInfo(TechID, txtRegName.Text, txtRegContact.Text, TechID + "@" + cboxRegBMonth.Text + cboxRegBDay.Text, cboxRegBYear.Text + "-" + cboxRegBMonth.Text + "-" + cboxRegBDay.Text);
                            query = "INSERT INTO technicians VALUES (@id, @name, @contact, @password, @bdate);";
                            query2 = "INSERT INTO users_login VALUES (@id, @password, 'technician', @name);";
                            validate = techData.CreateStaff(query, query2);
                            if (validate != 0)
                            {
                                MessageBox.Show("Successfully Registered!");
                            }
                            else
                            {
                                MessageBox.Show("Opps! Error Occurs!");
                            }
                            break;

                        case "Receptionist":
                            int ReceptCount = 1;
                            string Recept = "RE";
                            string ReceptID;
                            SqlCommand ReceptCountCmd = new SqlCommand("SELECT rec_id FROM receptionists", con);
                            SqlDataReader ReceptCountRdr = ReceptCountCmd.ExecuteReader();
                            //Count the Number of Receptionist Inside the Table
                            while (ReceptCountRdr.Read())
                            {
                                ReceptCount++;
                            }
                            ReceptCountRdr.Close();
                            //Generate ID for New Receptionist
                            ReceptID = idGenerator(Recept, ReceptCount);

                            //Created an Object of StaffInfo
                            StaffInfo recData = new StaffInfo(ReceptID, txtRegName.Text, txtRegContact.Text, ReceptID + "@" + cboxRegBMonth.Text + cboxRegBDay.Text, cboxRegBYear.Text + "-" + cboxRegBMonth.Text + "-" + cboxRegBDay.Text);
                            query = "INSERT INTO receptionists VALUES (@id, @name, @contact, @password, @bdate);";
                            query2 = "INSERT INTO users_login VALUES (@id, @password, 'receptionist', @name);";
                            validate = recData.CreateStaff(query, query2);
                            if (validate != 0)
                            {
                                MessageBox.Show("Successfully Registered!");
                            }
                            else
                            {
                                MessageBox.Show("Opps! Error Occurs!");
                            }
                            break;
                    }
                    txtRegName.Clear();
                    txtRegContact.Clear();
                    cboxRegBDay.ResetText();
                    cboxRegBMonth.ResetText();
                    cboxRegBYear.ResetText();
                }
                else
                {
                    MessageBox.Show("You haven't complete the form yet!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not establish the connection to the database!");
            }
            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formAdminMain().ShowDialog();
        }

        //Generate ID for New Staff
        private string idGenerator(string left_id, int staff_count)
        {
            string full_id;

            if (staff_count < 10)
            {
                full_id = left_id + "00" + staff_count.ToString();
            }
            else if (staff_count < 100)
            {
                full_id = left_id + "0" + staff_count.ToString();
            }
            else
            {
                full_id = left_id + staff_count.ToString();
            }

            return full_id;
        }
    }
}
