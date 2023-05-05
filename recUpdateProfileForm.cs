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
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using System.Configuration;

namespace ACH
{
    public partial class recUpdateProfileForm : Form
    {
        string receptionist_id = "";
        rec_profile show = new rec_profile();

        public recUpdateProfileForm()
        {
            InitializeComponent();
        }
        public recUpdateProfileForm(string rec_id)
        {
            InitializeComponent();
            receptionist_id = rec_id;
        }

        private void receptionistContactNumberLbl_Click(object sender, EventArgs e)
        {

        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            receptionistForm f2 = new receptionistForm(receptionist_id);
            f2.ShowDialog();
            this.Close();
        }

        private void changeContactNumberBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            changeContactNumberForm f5 = new changeContactNumberForm(receptionist_id, show.PhoneNumber);
            f5.ShowDialog();
            this.Close();
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            changePasswordForm f6 = new changePasswordForm(receptionist_id);
            f6.ShowDialog();
            this.Close();
        }

        private void updateMyProfileForm_Load(object sender, EventArgs e)
        {
            show.fetch(receptionist_id);

            receptionistIDLbl.Text = receptionist_id;
            receptionistNameLbl.Text = show.Name;
            receptionistContactNumberLbl.Text = show.PhoneNumber;

            

        }
    }
}
