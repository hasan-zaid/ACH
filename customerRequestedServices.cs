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
    public partial class customerRequestedServices : Form
    {
        string customer_id = "";
        string customer_name = "";

        SqlConnection con;

        int request_number = 0;
        List<int> request_numbers = new List<int>();
        public customerRequestedServices(string name, string id)
        {
            InitializeComponent();
            customer_name = name;
            customer_id = id;
        }

        private void customerRequestedServices_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());
            con.Open();
            string Command = "select requested_services.service_id, service_name, order_date, request_no from requested_services, services where requested_services.service_id = services.service_id and requested_services.cus_id = @id ;";
            SqlCommand cmd_1 = new SqlCommand(Command, con);
            cmd_1.Parameters.AddWithValue("@id", customer_id);

            SqlDataReader reader_1 = cmd_1.ExecuteReader();

            while (reader_1.Read())
            {
                requestedServicesComBox.Items.Add(reader_1.GetString(0) + "  -  " + reader_1.GetString(1) + " - Ordered on: " + reader_1.GetDateTime(2).ToShortDateString() + ";");
                request_numbers.Add(reader_1.GetInt32(3));
            }
            reader_1.Close();
            con.Close();
            if (requestedServicesComBox.Items.Count > 0)
            {
            }
            else
            {
                requestedServicesComBox.Text = "There are not any ordered services at the moment !";
            }
        }
        private void requestedServicesComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            request_number = request_numbers[requestedServicesComBox.SelectedIndex];
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());
            con.Open();
            string command_2 = "select collection_date, service_description, payment_accepted, service_completion from requested_services where request_no = @number ;";
            SqlCommand cmd_2 = new SqlCommand(command_2, con);
            cmd_2.Parameters.AddWithValue("@number", request_number);

            SqlDataReader reader_2 = cmd_2.ExecuteReader();
            if(reader_2.Read())
            {
                try
                {
                    DateTime collection_date = Convert.ToDateTime(reader_2["collection_date"]);
                    collectionDateLbl.Text = collection_date.ToShortDateString();
                }
                catch (Exception ex)
                {
                    collectionDateLbl.Text = "Not determined yet";
                }
                try
                {
                    string description = reader_2.GetString(1);
                    descriptionLbl.Text = description;
                }
                catch (Exception ex)
                {
                    descriptionLbl.Text = "This service doesn't have any description";
                }

                try
                {
                    Boolean status = reader_2.GetBoolean(2);
                    string status_2 = reader_2.GetString(3);
                    if (status == false)
                    {
                        statusLbl.Text = "Payment was rejected !";
                    }
                    else if (status == true)
                    {
                        if (status_2 == "0")
                        {
                            statusLbl.Text = "Payment accepted and service is in progress";
                        }
                        else
                        {
                            statusLbl.Text = "Service is completed :)";
                        }
                    }
                }
                catch (Exception ex)
                {
                    statusLbl.Text = "Status is not available !";
                }

            }
            else
            {
                MessageBox.Show("Couldn't fetch data from the database !");
            }
        }

        private void returnMainPageBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainCustomerForm f3 = new mainCustomerForm(customer_name, customer_id);
            f3.ShowDialog();
            this.Close();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm f = new loginForm();
            f.ShowDialog();
            this.Close();
        }
    }
}
