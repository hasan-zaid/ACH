using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACH
{
    public partial class changeContactNumberForm : Form
    {
        public changeContactNumberForm()
        {
            InitializeComponent();
        }

        string ID = "";
        string Phone = "";
        public changeContactNumberForm(string id, string phone)
        {
            InitializeComponent();
            ID = id;
            Phone = phone;
        }

        private void saveNewNumberBtn_Click(object sender, EventArgs e)
        {
            int tester;
            Int32.TryParse(newNumberTextBox.Text, out tester);
            if (tester == 0)
            {
                MessageBox.Show("Make sure your number doesn't contain any letters");
            }
            else if (tester > 0)
            {
                recChangeContact changer = new recChangeContact(ID, newNumberTextBox.Text);
                MessageBox.Show(changer.changeContact());
                this.Hide();
                recUpdateProfileForm f4 = new recUpdateProfileForm(ID);
                f4.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Make sure you enter a valid phone number");
            }
        }

        private void changeContactNumberForm_Load(object sender, EventArgs e)
        {
            currentNumberLbl.Text = Phone;
        }
    }
}
