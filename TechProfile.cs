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
    public partial class formProfile : Form
    {
        string tech_name, tech_id;
        public formProfile(string name, string id)
        {
            InitializeComponent();
            tech_name = name;
            tech_id = id;
        }

        private void btnEditPwd_Click(object sender, EventArgs e)
        {
            new formTechChgPw(tech_name, tech_id).ShowDialog();
        }

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            new formTechChangeContact(tech_name, tech_id).ShowDialog();
        }

        private void formProfile_Activated(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());

            //Fill in the Personal Detail of Technician into Labels
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM technicians WHERE tech_id = " + "'" + tech_id + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int techPwdLength = reader["tech_password"].ToString().Length;

                lblStaffID.Text = tech_id;
                lblName.Text = reader["tech_name"].ToString();
                //Repeat "*" for a Specific Number of Time (Int techPwdLength)
                lblPassword.Text = new string('*', techPwdLength);
                lblContact.Text = reader["tech_phone_number"].ToString();
                lblBDate.Text = Convert.ToDateTime(reader["birthday"]).ToShortDateString();
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not establish the connection to the database!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formTechMain(tech_name, tech_id).ShowDialog();
        }
    }
}
