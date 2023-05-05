namespace ACH
{
    partial class IncomeRepForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.totalIncomeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.totalIncomeDataSett = new ACH.TotalIncomeDataSett();
            this.incomereportBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.incomeReportDataSet = new ACH.IncomeReportDataSet();
            this.totalIncomeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.incomereportBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.totalIncomeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomereportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.incomeReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpIncome = new Microsoft.Reporting.WinForms.ReportViewer();
            this.total_IncomeTableAdapter2 = new ACH.TotalIncomeDataSettTableAdapters.Total_IncomeTableAdapter();
            this.income_reportTableAdapter2 = new ACH.IncomeReportDataSetTableAdapters.income_reportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.totalIncomeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalIncomeDataSett)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomereportBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalIncomeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomereportBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalIncomeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomereportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // totalIncomeBindingSource2
            // 
            this.totalIncomeBindingSource2.DataMember = "Total_Income";
            this.totalIncomeBindingSource2.DataSource = this.totalIncomeDataSett;
            // 
            // totalIncomeDataSett
            // 
            this.totalIncomeDataSett.DataSetName = "TotalIncomeDataSett";
            this.totalIncomeDataSett.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incomereportBindingSource3
            // 
            this.incomereportBindingSource3.DataMember = "income_report";
            this.incomereportBindingSource3.DataSource = this.incomeReportDataSet;
            // 
            // incomeReportDataSet
            // 
            this.incomeReportDataSet.DataSetName = "IncomeReportDataSet";
            this.incomeReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalIncomeBindingSource1
            // 
            this.totalIncomeBindingSource1.DataMember = "Total_Income";
            // 
            // totalIncomeDataSet
            // 
            // 
            // incomereportBindingSource2
            // 
            this.incomereportBindingSource2.DataMember = "income_report";
            // 
            // incomeRPDataSet
            // 
            // 
            // totalIncomeBindingSource
            // 
            this.totalIncomeBindingSource.DataMember = "Total_Income";
            // 
            // incomereportBindingSource1
            // 
            this.incomereportBindingSource1.DataMember = "income_report";
            // 
            // incomeReportBindingSource
            // 
            this.incomeReportBindingSource.DataMember = "Income_Report";
            // 
            // rpIncome
            // 
            this.rpIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsetTotalIncome";
            reportDataSource1.Value = this.totalIncomeBindingSource2;
            reportDataSource2.Name = "dsetIncomeReport";
            reportDataSource2.Value = this.incomereportBindingSource3;
            this.rpIncome.LocalReport.DataSources.Add(reportDataSource1);
            this.rpIncome.LocalReport.DataSources.Add(reportDataSource2);
            this.rpIncome.LocalReport.ReportEmbeddedResource = "ACH.Report2.rdlc";
            this.rpIncome.Location = new System.Drawing.Point(0, 0);
            this.rpIncome.Name = "rpIncome";
            this.rpIncome.ServerReport.BearerToken = null;
            this.rpIncome.Size = new System.Drawing.Size(684, 609);
            this.rpIncome.TabIndex = 0;
            // 
            // total_IncomeTableAdapter1
            // 
            // 
            // income_reportTableAdapter1
            // 
            // 
            // total_IncomeTableAdapter2
            // 
            this.total_IncomeTableAdapter2.ClearBeforeFill = true;
            // 
            // income_reportTableAdapter2
            // 
            this.income_reportTableAdapter2.ClearBeforeFill = true;
            // 
            // IncomeRepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 609);
            this.Controls.Add(this.rpIncome);
            this.Name = "IncomeRepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Income Report";
            this.Load += new System.EventHandler(this.IncomeRepForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.totalIncomeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalIncomeDataSett)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomereportBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalIncomeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomereportBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalIncomeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomereportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomeReportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpIncome;
        private System.Windows.Forms.BindingSource incomeReportBindingSource;
        private System.Windows.Forms.BindingSource totalIncomeBindingSource;
        private System.Windows.Forms.BindingSource incomereportBindingSource1;
        private System.Windows.Forms.BindingSource totalIncomeBindingSource1;
        private System.Windows.Forms.BindingSource incomereportBindingSource2;
        private TotalIncomeDataSett totalIncomeDataSett;
        private System.Windows.Forms.BindingSource totalIncomeBindingSource2;
        private TotalIncomeDataSettTableAdapters.Total_IncomeTableAdapter total_IncomeTableAdapter2;
        private IncomeReportDataSet incomeReportDataSet;
        private System.Windows.Forms.BindingSource incomereportBindingSource3;
        private IncomeReportDataSetTableAdapters.income_reportTableAdapter income_reportTableAdapter2;
    }
}