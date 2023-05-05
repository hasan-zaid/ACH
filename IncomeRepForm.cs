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
    public partial class IncomeRepForm : Form
    {
        public IncomeRepForm()
        {
            InitializeComponent();
        }

        private void IncomeRepForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'incomeReportDataSet.income_report' table. You can move, or remove it, as needed.
            this.income_reportTableAdapter2.Fill(this.incomeReportDataSet.income_report);
            // TODO: This line of code loads data into the 'totalIncomeDataSett.Total_Income' table. You can move, or remove it, as needed.
            this.total_IncomeTableAdapter2.Fill(this.totalIncomeDataSett.Total_Income);

            this.rpIncome.RefreshReport();
        }
    }
}
