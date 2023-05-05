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


    public partial class receptionistForm : Form
    {

        private string receptionist_name = "";
        private string receptionist_id = "";

        string customer_id = "";
        string service_name = "";
        int amount_paid = 0;
        string customer_name = "";
        int request_number = 0;
        string service_urgency = "";
        string service_id = "";

        List<int> paymentAmounts = new List<int>();
        List<string> customer_ids = new List<string>();
        List<string> service_names = new List<string>();
        List<int> request_numbers = new List<int>();
        List<string> customers_names = new List<string>();
        List<string> services_urgencies = new List<string>();
        List<string> service_ids = new List<string>();


        SqlConnection con;



        public receptionistForm()
        {
            InitializeComponent();
        }
        public receptionistForm(string id)
        {
            InitializeComponent();
            receptionist_id = id;
        }

        public receptionistForm(string name, string id)
        {
            InitializeComponent();
            receptionist_name = name;
            receptionist_id = id;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void receptionistForm_Load(object sender, EventArgs e)
        {
            label5.Text = "Welcome " + receptionist_name + " !";
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());
            con.Open();
            string Command = "select service_name, requested_services.cus_id, amount_paid, request_no, cus_name, service_urgency, requested_services.service_id from requested_services, services, customers where requested_services.service_id = services.service_id and customers.cus_id = requested_services.cus_id and reviewed = 0;";
            SqlCommand cmd_1 = new SqlCommand(Command, con);

            SqlDataReader reader_1 = cmd_1.ExecuteReader();

            while (reader_1.Read())
            {
                requestedServiceComBox.Items.Add(reader_1.GetString(0) + "  requested by:  " + reader_1.GetString(1));

                paymentAmounts.Add(reader_1.GetInt32(2));
                customer_ids.Add(reader_1.GetString(1));
                service_names.Add(reader_1.GetString(0));
                request_numbers.Add(reader_1.GetInt32(3));
                customers_names.Add(reader_1.GetString(4));
                services_urgencies.Add(reader_1.GetString(5));
                service_ids.Add(reader_1.GetString(6));
            }
            reader_1.Close();
            con.Close();
            if (requestedServiceComBox.Items.Count > 0)
            {
            }
            else
            {
                requestedServiceComBox.Text = "There are not any pending service requests at the moment !";
            }


        }

        private void registerNewCustomerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            registerNewCustomerForm f3 = new registerNewCustomerForm(receptionist_id);
            f3.ShowDialog();
            this.Close();
        }

        private void updateProfileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            recUpdateProfileForm f4 = new recUpdateProfileForm(receptionist_id);
            f4.ShowDialog();
            this.Close();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm f1 = new loginForm();
            f1.ShowDialog();
            this.Close();
        }

        private void acceptPaymentBtn_Click(object sender, EventArgs e)
        {
            if (requestedServiceComBox.SelectedIndex >= 0)
            {
                acceptPayment active = new acceptPayment();
                active.accept(request_number, amount_paid, customer_id, customer_name, service_name, receptionist_id, receptionist_name, service_urgency, service_id);
                MessageBox.Show("A payment of: " + amount_paid + "RM for the following service: \n'" + service_name + "' \n was made by: " + customer_id + " | " + customer_name + "\n has been successfully accepted by receptionist: " + receptionist_id + " | " + receptionist_name + "\n on: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));

                requestedServiceComBox.Items.Remove(requestedServiceComBox.SelectedItem);
                pendingPaymentsLbl.Text = "";
                requestedServiceComBox.Refresh();
            }
            else
            {
                MessageBox.Show("Please select a payment first");
            }


        }
        public void oc(string t) { MessageBox.Show(t); }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void requestedServiceComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            service_name = service_names[requestedServiceComBox.SelectedIndex];
            customer_id = customer_ids[requestedServiceComBox.SelectedIndex];
            amount_paid = paymentAmounts[requestedServiceComBox.SelectedIndex];
            customer_name = customers_names[requestedServiceComBox.SelectedIndex];
            request_number = request_numbers[requestedServiceComBox.SelectedIndex];
            service_urgency = services_urgencies[requestedServiceComBox.SelectedIndex];
            service_id = service_ids[requestedServiceComBox.SelectedIndex];

           pendingPaymentsLbl.Text = amount_paid + "RM paid for a/an " +service_urgency+ " service";
        }

        private void declinePaymentBtn_Click(object sender, EventArgs e)
        {
            if (requestedServiceComBox.SelectedIndex >= 0)
            {
                declinePayment dec = new declinePayment();
                dec.decline(request_number);
                MessageBox.Show("The selected payment has been successfully declined");
                requestedServiceComBox.Items.Remove(requestedServiceComBox.SelectedItem);
                pendingPaymentsLbl.Text = "";
                requestedServiceComBox.Refresh(); 
            }
            else
            {
                MessageBox.Show("Please select a payment first");
                
            }
        }

        private void pendingPaymentsLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
