namespace ACH
{
    partial class formAdminMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listAcc = new System.Windows.Forms.ListBox();
            this.txtSchAccName = new System.Windows.Forms.TextBox();
            this.cboxSchAccType = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRegisterAcc = new System.Windows.Forms.Button();
            this.btnDeleteAcc = new System.Windows.Forms.Button();
            this.btnViewRep = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(491, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(491, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account List";
            // 
            // listAcc
            // 
            this.listAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAcc.FormattingEnabled = true;
            this.listAcc.ItemHeight = 15;
            this.listAcc.Items.AddRange(new object[] {
            "Staff ID\t\tName\t\t\tContact"});
            this.listAcc.Location = new System.Drawing.Point(461, 143);
            this.listAcc.Name = "listAcc";
            this.listAcc.Size = new System.Drawing.Size(428, 154);
            this.listAcc.TabIndex = 3;
            // 
            // txtSchAccName
            // 
            this.txtSchAccName.Location = new System.Drawing.Point(611, 51);
            this.txtSchAccName.Name = "txtSchAccName";
            this.txtSchAccName.Size = new System.Drawing.Size(163, 20);
            this.txtSchAccName.TabIndex = 4;
            // 
            // cboxSchAccType
            // 
            this.cboxSchAccType.FormattingEnabled = true;
            this.cboxSchAccType.Items.AddRange(new object[] {
            "Technician",
            "Receptionist"});
            this.cboxSchAccType.Location = new System.Drawing.Point(611, 81);
            this.cboxSchAccType.Name = "cboxSchAccType";
            this.cboxSchAccType.Size = new System.Drawing.Size(163, 21);
            this.cboxSchAccType.TabIndex = 5;
            this.cboxSchAccType.Text = "<Select an Account Type>";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSearch.Location = new System.Drawing.Point(780, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRegisterAcc
            // 
            this.btnRegisterAcc.BackColor = System.Drawing.Color.Teal;
            this.btnRegisterAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterAcc.Location = new System.Drawing.Point(522, 322);
            this.btnRegisterAcc.Name = "btnRegisterAcc";
            this.btnRegisterAcc.Size = new System.Drawing.Size(145, 35);
            this.btnRegisterAcc.TabIndex = 7;
            this.btnRegisterAcc.Text = "Register New Account";
            this.btnRegisterAcc.UseVisualStyleBackColor = false;
            this.btnRegisterAcc.Click += new System.EventHandler(this.btnRegisterAcc_Click);
            // 
            // btnDeleteAcc
            // 
            this.btnDeleteAcc.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAcc.Location = new System.Drawing.Point(694, 322);
            this.btnDeleteAcc.Name = "btnDeleteAcc";
            this.btnDeleteAcc.Size = new System.Drawing.Size(145, 35);
            this.btnDeleteAcc.TabIndex = 8;
            this.btnDeleteAcc.Text = "Delete Account";
            this.btnDeleteAcc.UseVisualStyleBackColor = false;
            this.btnDeleteAcc.Click += new System.EventHandler(this.btnDeleteAcc_Click);
            // 
            // btnViewRep
            // 
            this.btnViewRep.BackColor = System.Drawing.Color.Teal;
            this.btnViewRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRep.Location = new System.Drawing.Point(611, 371);
            this.btnViewRep.Name = "btnViewRep";
            this.btnViewRep.Size = new System.Drawing.Size(145, 35);
            this.btnViewRep.TabIndex = 9;
            this.btnViewRep.Text = "View Monthly Report";
            this.btnViewRep.UseVisualStyleBackColor = false;
            this.btnViewRep.Click += new System.EventHandler(this.btnViewRep_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Teal;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(808, 414);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 35);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Teal;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 462);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(390, 61);
            this.label4.TabIndex = 12;
            this.label4.Text = "Admin Main Page";
            // 
            // formAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(894, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewRep);
            this.Controls.Add(this.btnDeleteAcc);
            this.Controls.Add(this.btnRegisterAcc);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cboxSchAccType);
            this.Controls.Add(this.txtSchAccName);
            this.Controls.Add(this.listAcc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "formAdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page (Admin)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listAcc;
        private System.Windows.Forms.TextBox txtSchAccName;
        private System.Windows.Forms.ComboBox cboxSchAccType;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRegisterAcc;
        private System.Windows.Forms.Button btnDeleteAcc;
        private System.Windows.Forms.Button btnViewRep;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

