namespace ACH
{
    partial class formTechMain
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.cboxService = new System.Windows.Forms.ComboBox();
            this.lblUrgency = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnMarkCmp = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnAddDesc = new System.Windows.Forms.Button();
            this.btnAddColDate = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnTechProfile = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblShowName = new System.Windows.Forms.Label();
            this.dtpCollectDate = new System.Windows.Forms.DateTimePicker();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCollectDate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 462);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 53);
            this.label1.TabIndex = 13;
            this.label1.Text = "Technician Main Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(494, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Service Urgency :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(509, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Service Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Requested Service :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(524, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Description :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(501, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Collection Date :";
            // 
            // lblSName
            // 
            this.lblSName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSName.Location = new System.Drawing.Point(609, 58);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(238, 22);
            this.lblSName.TabIndex = 19;
            // 
            // cboxService
            // 
            this.cboxService.FormattingEnabled = true;
            this.cboxService.Location = new System.Drawing.Point(609, 23);
            this.cboxService.Name = "cboxService";
            this.cboxService.Size = new System.Drawing.Size(238, 21);
            this.cboxService.TabIndex = 21;
            this.cboxService.Text = "RequestNo. & ServiceID & CustomerID";
            // 
            // lblUrgency
            // 
            this.lblUrgency.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUrgency.Location = new System.Drawing.Point(609, 93);
            this.lblUrgency.Name = "lblUrgency";
            this.lblUrgency.Size = new System.Drawing.Size(238, 22);
            this.lblUrgency.TabIndex = 22;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Teal;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(653, 202);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(85, 32);
            this.btnCheck.TabIndex = 23;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnMarkCmp
            // 
            this.btnMarkCmp.BackColor = System.Drawing.Color.Teal;
            this.btnMarkCmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarkCmp.Location = new System.Drawing.Point(609, 243);
            this.btnMarkCmp.Name = "btnMarkCmp";
            this.btnMarkCmp.Size = new System.Drawing.Size(169, 32);
            this.btnMarkCmp.TabIndex = 28;
            this.btnMarkCmp.Text = "Mark Service Completed";
            this.btnMarkCmp.UseVisualStyleBackColor = false;
            this.btnMarkCmp.Click += new System.EventHandler(this.btnMarkCmp_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(609, 297);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(198, 20);
            this.txtDesc.TabIndex = 29;
            // 
            // btnAddDesc
            // 
            this.btnAddDesc.BackColor = System.Drawing.Color.Teal;
            this.btnAddDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDesc.Location = new System.Drawing.Point(816, 292);
            this.btnAddDesc.Name = "btnAddDesc";
            this.btnAddDesc.Size = new System.Drawing.Size(53, 32);
            this.btnAddDesc.TabIndex = 31;
            this.btnAddDesc.Text = "Add";
            this.btnAddDesc.UseVisualStyleBackColor = false;
            this.btnAddDesc.Click += new System.EventHandler(this.btnAddDesc_Click);
            // 
            // btnAddColDate
            // 
            this.btnAddColDate.BackColor = System.Drawing.Color.Teal;
            this.btnAddColDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddColDate.Location = new System.Drawing.Point(816, 339);
            this.btnAddColDate.Name = "btnAddColDate";
            this.btnAddColDate.Size = new System.Drawing.Size(53, 32);
            this.btnAddColDate.TabIndex = 32;
            this.btnAddColDate.Text = "Add";
            this.btnAddColDate.UseVisualStyleBackColor = false;
            this.btnAddColDate.Click += new System.EventHandler(this.btnAddColDate_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Teal;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(807, 414);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 35);
            this.btnLogOut.TabIndex = 33;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnTechProfile
            // 
            this.btnTechProfile.BackColor = System.Drawing.Color.Teal;
            this.btnTechProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechProfile.ForeColor = System.Drawing.Color.White;
            this.btnTechProfile.Location = new System.Drawing.Point(483, 414);
            this.btnTechProfile.Name = "btnTechProfile";
            this.btnTechProfile.Size = new System.Drawing.Size(75, 35);
            this.btnTechProfile.TabIndex = 34;
            this.btnTechProfile.Text = "Profile";
            this.btnTechProfile.UseVisualStyleBackColor = false;
            this.btnTechProfile.Click += new System.EventHandler(this.btnTechProfile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 27);
            this.label7.TabIndex = 35;
            // 
            // lblShowName
            // 
            this.lblShowName.BackColor = System.Drawing.Color.Teal;
            this.lblShowName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShowName.Font = new System.Drawing.Font("Segoe Script", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowName.ForeColor = System.Drawing.Color.White;
            this.lblShowName.Location = new System.Drawing.Point(8, 384);
            this.lblShowName.Name = "lblShowName";
            this.lblShowName.Size = new System.Drawing.Size(440, 65);
            this.lblShowName.TabIndex = 36;
            // 
            // dtpCollectDate
            // 
            this.dtpCollectDate.Location = new System.Drawing.Point(610, 343);
            this.dtpCollectDate.Name = "dtpCollectDate";
            this.dtpCollectDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCollectDate.TabIndex = 37;
            // 
            // lblDescription
            // 
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDescription.Location = new System.Drawing.Point(609, 130);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(238, 22);
            this.lblDescription.TabIndex = 38;
            // 
            // lblCollectDate
            // 
            this.lblCollectDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCollectDate.Location = new System.Drawing.Point(610, 171);
            this.lblCollectDate.Name = "lblCollectDate";
            this.lblCollectDate.Size = new System.Drawing.Size(238, 22);
            this.lblCollectDate.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(477, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Service Description :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(501, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Collection Date :";
            // 
            // formTechMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 461);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblCollectDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.dtpCollectDate);
            this.Controls.Add(this.lblShowName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTechProfile);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnAddColDate);
            this.Controls.Add(this.btnAddDesc);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnMarkCmp);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblUrgency);
            this.Controls.Add(this.cboxService);
            this.Controls.Add(this.lblSName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formTechMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechMain";
            this.Load += new System.EventHandler(this.formTechMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.ComboBox cboxService;
        private System.Windows.Forms.Label lblUrgency;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnMarkCmp;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnAddDesc;
        private System.Windows.Forms.Button btnAddColDate;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnTechProfile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblShowName;
        private System.Windows.Forms.DateTimePicker dtpCollectDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCollectDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}