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
    public partial class ServiceRepForm : Form
    {
        public ServiceRepForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'serviceRPdataset.completed_services' table. You can move, or remove it, as needed.
            this.completed_servicesTableAdapter.Fill(this.serviceRPdataset.completed_services);
            this.rpService.RefreshReport();
        }
    }
}
