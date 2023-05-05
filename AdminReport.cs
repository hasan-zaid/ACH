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
    public partial class formReport : Form
    {
        public formReport()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (cboxReportType.SelectedItem != null)
            {
                switch (cboxReportType.SelectedItem.ToString())
                {
                    case "Total Income":
                        new IncomeRepForm().ShowDialog();
                        break;
                    case "Service Report":
                        new ServiceRepForm().ShowDialog();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Please Select a Report Type!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
