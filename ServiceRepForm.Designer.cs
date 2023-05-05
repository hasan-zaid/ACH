namespace ACH
{
    partial class ServiceRepForm
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
            this.completedservicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.serviceRPdataset = new ACH.ServiceReportDataSet();
            this.completedservicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceRPdatasetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Service_ReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceReportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rpService = new Microsoft.Reporting.WinForms.ReportViewer();
            this.completed_servicesTableAdapter = new ACH.ServiceReportDataSetTableAdapters.completed_servicesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.completedservicesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRPdataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.completedservicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRPdatasetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Service_ReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // completedservicesBindingSource1
            // 
            this.completedservicesBindingSource1.DataMember = "completed_services";
            this.completedservicesBindingSource1.DataSource = this.serviceRPdataset;
            // 
            // serviceRPdataset
            // 
            this.serviceRPdataset.DataSetName = "ServiceRPdataset";
            this.serviceRPdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // completedservicesBindingSource
            // 
            this.completedservicesBindingSource.DataMember = "completed_services";
            this.completedservicesBindingSource.DataSource = this.serviceRPdatasetBindingSource;
            // 
            // serviceRPdatasetBindingSource
            // 
            this.serviceRPdatasetBindingSource.DataSource = this.serviceRPdataset;
            this.serviceRPdatasetBindingSource.Position = 0;
            // 
            // rpService
            // 
            this.rpService.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsetServiceReport";
            reportDataSource1.Value = this.completedservicesBindingSource1;
            this.rpService.LocalReport.DataSources.Add(reportDataSource1);
            this.rpService.LocalReport.ReportEmbeddedResource = "ACH.Report1.rdlc";
            this.rpService.Location = new System.Drawing.Point(0, 0);
            this.rpService.Name = "rpService";
            this.rpService.ServerReport.BearerToken = null;
            this.rpService.Size = new System.Drawing.Size(684, 609);
            this.rpService.TabIndex = 0;
            // 
            // completed_servicesTableAdapter
            // 
            this.completed_servicesTableAdapter.ClearBeforeFill = true;
            // 
            // ServiceRepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 609);
            this.Controls.Add(this.rpService);
            this.Name = "ServiceRepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Report";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.completedservicesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRPdataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.completedservicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceRPdatasetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Service_ReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceReportBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpService;
        private System.Windows.Forms.BindingSource Service_ReportBindingSource;
        private System.Windows.Forms.BindingSource serviceReportBindingSource;
        private System.Windows.Forms.BindingSource serviceReportBindingSource1;
        private ServiceReportDataSet serviceRPdataset;
        private System.Windows.Forms.BindingSource serviceRPdatasetBindingSource;
        private System.Windows.Forms.BindingSource completedservicesBindingSource;
        private ServiceReportDataSetTableAdapters.completed_servicesTableAdapter completed_servicesTableAdapter;
        private System.Windows.Forms.BindingSource completedservicesBindingSource1;
    }
}