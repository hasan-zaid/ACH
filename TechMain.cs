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
    public partial class formTechMain : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());

        string technician_name, technician_id;
        public formTechMain()
        {
            InitializeComponent();
        }
        public formTechMain(string name, string id)
        {
            InitializeComponent();
            technician_name = name;
            technician_id = id;
        }

        private void btnTechProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            new formProfile(technician_name, technician_id).ShowDialog();
        }

        private void formTechMain_Load(object sender, EventArgs e)
        {
            lblShowName.Text = $"Welcome, {technician_name}! \n ID: {technician_id}";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT request_no, service_id, cus_id FROM requested_services WHERE payment_accepted = 1 AND service_completion = 0 ORDER BY request_no", con);
                SqlDataReader reader = cmd.ExecuteReader();

                //Add All Requested Services into ComboBox
                while (reader.Read())
                {
                    string requestNo = reader["request_no"].ToString();
                    string serId = reader["service_id"].ToString();
                    string cusId = reader["cus_id"].ToString();
                    string request_service_row = requestNo + " & " + serId + "  &  " + cusId;
                    cboxService.Items.Add(request_service_row);
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            //Prompt a Window and Give User Options to Select Yes/No
            DialogResult logOut;
            logOut = MessageBox.Show("Do you want to log out from the system?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //If User Selected "Yes", Close the Form
            if(logOut == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Return the Request_No of the Service Selected in ComboBox
        private int checkRequestNo()
        {
            //Assign Value inside ComboBox to Variable cboxInfo
            string cboxInfo = cboxService.SelectedItem.ToString();
            //Split the String cboxInfo when There is a Blank Space and Assign the Value into Array splitID
            string[] splitID = cboxInfo.Split(' ');
            //Take the First Value inside Array splitID
            int requestNo = Convert.ToInt32(splitID[0]);
            return requestNo;
        }

        //Display the Detail of (Service Selected inside ComboBox) in the Corresponding Label
        private void checkService()
        {
            string cboxInfo = cboxService.SelectedItem.ToString();
            string[] splitID = cboxInfo.Split(' ');
            string requestNo = splitID[0];
            string serviceID = splitID[2];

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT service_name FROM services WHERE service_id = " + "'" + serviceID + "'", con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                lblSName.Text = reader["service_name"].ToString();
                reader.Close();

                SqlCommand cmd2 = new SqlCommand("Select service_urgency, service_description, collection_date FROM requested_services WHERE request_no = " + "'" + requestNo + "'", con);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                reader2.Read();
                lblUrgency.Text = reader2["service_urgency"].ToString();
                if (String.IsNullOrEmpty(reader2["service_description"].ToString()))
                {
                    lblDescription.Text = "-";
                }
                else
                {
                    lblDescription.Text = reader2["service_description"].ToString();
                }
                if (String.IsNullOrEmpty(reader2["collection_date"].ToString()))
                {
                    lblCollectDate.Text = "-";
                }
                else
                {
                    lblCollectDate.Text = reader2["collection_date"].ToString();
                }
                reader2.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not establish the connection to the database!");
            }
            con.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (cboxService.SelectedItem != null)
            {
                checkService(); //Line 92
            }
            else
            {
                MessageBox.Show("Please Select a Requested Service!");
            }
        }

        //Add Description to the Service Selected
        private void btnAddDesc_Click(object sender, EventArgs e)
        {
            if (cboxService.SelectedItem != null && !String.IsNullOrEmpty(txtDesc.Text.Trim()))
            {
                int requestNo = checkRequestNo();
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE requested_services SET service_description = " + "'" + txtDesc.Text + "'" + " WHERE request_no = " + requestNo, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Description Added!");
                    txtDesc.Clear();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Could not establish the connection to the database!");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Select a Requested Service! / Fill In the TextBox!");
            }
        }

        //Mark Service as Completed
        private void btnMarkCmp_Click(object sender, EventArgs e)
        {
            if (cboxService.SelectedItem != null)
            {
                int requestNo = checkRequestNo();
                //Check if Service has All Required Data
                switch (validateServiceCompletion(requestNo))
                {
                    case true:
                        try
                        {
                            con.Open();
                            //Add the Data of Completed Service into Another Table which Stores Completed Services
                            addCompletedService(requestNo);
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Could not establish the connection to the database!");
                        }
                        break;
                    case false:
                        MessageBox.Show("The Description & CollectionDate Shouldn't Be Blank!");
                        break;
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Select a Requested Service!");
            }
        }

        //Add the Data of Completed Service into Another Table which Stores Completed Services
        private void addCompletedService(int requestNo)
        {
            SqlCommand cmd = new SqlCommand("SELECT request_no, service_id, cus_id, tech_id, service_description, collection_date, amount_paid, service_urgency, order_date FROM requested_services WHERE request_no = " + requestNo, con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //Created an Object of CompletedService
            CompletedService Service = new CompletedService(reader.GetInt32(0), reader.GetString(1), reader.GetString(4), reader.GetInt32(6), Convert.ToDateTime(reader["order_date"]), Convert.ToDateTime(reader["collection_date"]), reader.GetString(7), reader.GetString(2), technician_id);
            reader.Close();
            int validate = Service.AddCompletedService();
            if (validate != 0)
            {
                MessageBox.Show("Service Completed!");
                cboxService.Items.Remove(cboxService.SelectedItem);
                SqlCommand cmd2 = new SqlCommand("UPDATE requested_services SET service_completion = 1, tech_id = " + "'" + technician_id + "'" + " WHERE request_no = " + requestNo, con);
                cmd2.ExecuteNonQuery();

                lblSName.Text = "";
                lblUrgency.Text = "";
                lblDescription.Text = "";
                lblCollectDate.Text = "";
            }
            else
            {
                MessageBox.Show("Opps! Error Occur!");
            }
        }

        //Add Collection Date to Service Selected
        private void btnAddColDate_Click(object sender, EventArgs e)
        {
            if (cboxService.SelectedItem != null)
            {
                int requestNo = checkRequestNo();
                try
                {
                    con.Open();
                    try
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE requested_services SET collection_date = " + "'" + dtpCollectDate.Value.ToString("yyyy-MM-dd") + "'" + " WHERE request_no = " + requestNo, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Collection Date Added!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Could not establish the connection to the database!");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please Select a Requested Service!");
            }
        }

        //Check if User have Assigned Description & Collection Date for Service
        private bool validateServiceCompletion(int requestNo)
        {
            bool validate;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select service_description, collection_date FROM requested_services WHERE request_no = " + "'" + requestNo + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            //If Service doesn't have Description / Collection Date
            if (String.IsNullOrEmpty(reader["service_description"].ToString()) || String.IsNullOrEmpty(reader["collection_date"].ToString()))
            {
                validate = false;
            }
            else
            {
                validate = true;
            }
            reader.Close();
            con.Close();
            return validate;
        }
    }
}
