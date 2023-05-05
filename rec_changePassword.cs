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
    public partial class changePasswordForm : Form
    {

        string ID = "";
        public changePasswordForm()
        {
            InitializeComponent();
        }
        public changePasswordForm(string id)
        {
            InitializeComponent();
            ID = id;
        }
        

        private void changePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void saveNewPasswordBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(currentPasswordTextBox.Text) || string.IsNullOrWhiteSpace(newPasswordTextBox.Text) || string.IsNullOrWhiteSpace(confirmNewPasswordTextBox.Text))
            {
                errorProvider1.SetError(saveNewPasswordBtn, "All fields must be filled properly !");
            }
            else if (newPasswordTextBox.Text == confirmNewPasswordTextBox.Text)
            {
                errorProvider1.SetError(saveNewPasswordBtn, "");
                recChangePass P = new recChangePass(ID);
                MessageBox.Show(P.changePassword(currentPasswordTextBox.Text, newPasswordTextBox.Text));
                this.Hide();
                recUpdateProfileForm f = new recUpdateProfileForm(ID);
                f.ShowDialog();
                this.Close();
            }
            else if (confirmNewPasswordTextBox.Text != newPasswordTextBox.Text)
            {
                errorProvider1.SetError(saveNewPasswordBtn, "The new passwords you entered don't match, try again");
            }
        }
    }
}
