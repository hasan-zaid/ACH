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
    public partial class mainCustomerForm : Form
    {
        string customerID = "";
        string customerName = "";

        SqlConnection con;

        List<int> service_Normal_Fees = new List<int>();
        List<int> service_Urgent_Fees = new List<int>();
        List<string> service_ids = new List<string>();

        public mainCustomerForm(string name, string id)
        {
            InitializeComponent();
            customerID = id;
            customerName = name;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mainCustomerForm_Load(object sender, EventArgs e)
        {
            welcomeLbl.Text = "Welcome " + customerName;

            con = new SqlConnection(ConfigurationManager.ConnectionStrings["ACHdb"].ToString());
            con.Open();
            string Command = "select * from services;";
            SqlCommand cmd_1 = new SqlCommand(Command, con);

            SqlDataReader reader_1 = cmd_1.ExecuteReader();

            while (reader_1.Read())
            {
                service_ids.Add(reader_1.GetString(0));
                servicesComBox.Items.Add(reader_1.GetString(1));
                service_Normal_Fees.Add(reader_1.GetInt32(2));
                service_Urgent_Fees.Add(reader_1.GetInt32(3));

            }
            reader_1.Close();
            con.Close();

            
        }

        private void servicesComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (urgentServiceRadBtn.Checked)
            {
                PriceLbl.Text = service_Urgent_Fees[servicesComBox.SelectedIndex].ToString();
            }
            else if (normalServiceRadBtn.Checked)
            {
                PriceLbl.Text = service_Normal_Fees[servicesComBox.SelectedIndex].ToString();
            }
        }

        private void normalServiceRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (servicesComBox.SelectedIndex >= 0)
            {
                PriceLbl.Text = service_Normal_Fees[servicesComBox.SelectedIndex].ToString();
            }
            else { }
        }

        private void urgentServiceRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (servicesComBox.SelectedIndex >= 0)
            {
                PriceLbl.Text = service_Urgent_Fees[servicesComBox.SelectedIndex].ToString();
            }
            else { }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm f1 = new loginForm();
            f1.ShowDialog();
            this.Close();
        }

        
        private void makePaymentBtn_Click(object sender, EventArgs e)
        {
            customerMakePayment initaite = new customerMakePayment();

            int tester;
            Int32.TryParse(PaymentTxtBox.Text, out tester);

            if (servicesComBox.SelectedIndex < 0)
            {
                errorProvider1.SetError(makePaymentBtn, "Choose a service before proceeding with your payment");
            }

            else if (string.IsNullOrWhiteSpace(PaymentTxtBox.Text) || tester == 0)
            {
                errorProvider1.SetError(makePaymentBtn, "make sure you enter your payment correctly !");
            }
            else if (normalServiceRadBtn.Checked)
            {
                initaite.processPayment(Convert.ToInt32(PaymentTxtBox.Text), customerID, service_ids[servicesComBox.SelectedIndex], "normal");
            }
            else if (urgentServiceRadBtn.Checked)
            {
                initaite.processPayment(Convert.ToInt32(PaymentTxtBox.Text), customerID, service_ids[servicesComBox.SelectedIndex], "urgent");
            }
            else
            {
                errorProvider1.SetError(makePaymentBtn, "you should specify the urgency of the service before making the payment !");
            }


                MessageBox.Show("Your transaction has been made successfully. Come later to check on the service description and collection date");
                servicesComBox.Refresh();
                PaymentTxtBox.Clear();
                PriceLbl.Text = "";
            }

        private void viewRequestedServiceBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerRequestedServices form = new customerRequestedServices(customerName, customerID);
            form.ShowDialog();
            this.Close();
        }

        private void customerUpdateProfileBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            customerUpdateProfile f = new customerUpdateProfile(customerName, customerID);
            f.ShowDialog();
            this.Close();
        }
    }
    }

