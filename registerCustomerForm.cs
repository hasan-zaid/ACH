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
    public partial class registerNewCustomerForm : Form
    {
        string receptionist_id = "";
        SqlConnection con;
        public registerNewCustomerForm(string id)
        {
            InitializeComponent();
            receptionist_id = id;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customerNameTextBox.Text) || string.IsNullOrWhiteSpace(customerNumberTextBox.Text) || string.IsNullOrWhiteSpace(accountPasswordTextBox.Text) || string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text))
            {
                errorProvider1.SetError(createAccountBtn, "All fields must not be empty");
            }
            else if  (accountPasswordTextBox.Text != confirmPasswordTextBox.Text)
            {
                errorProvider1.SetError(createAccountBtn, "The entered passwords don't match !");
            }
            else
            {
                errorProvider1.SetError(customerNameTextBox, "");

                register_cus D = new register_cus();
                D.id_generator();
                MessageBox.Show(D.registerer(customerNameTextBox.Text, customerNumberTextBox.Text, accountPasswordTextBox.Text));
                receptionistForm A = new receptionistForm(receptionist_id);
                this.Hide();
                A.ShowDialog();
                this.Close();
            }
        }

        private void registerNewCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void accountPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerNameTextBox_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
