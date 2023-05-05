namespace ACH
{
    partial class receptionistForm
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
            this.acceptPaymentBtn = new System.Windows.Forms.Button();
            this.updateProfileBtn = new System.Windows.Forms.Button();
            this.registerNewCustomerBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.declinePaymentBtn = new System.Windows.Forms.Button();
            this.pendingPaymentsLbl = new System.Windows.Forms.Label();
            this.requestedServiceComBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(640, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Requested Services: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(640, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pending Payments:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // acceptPaymentBtn
            // 
            this.acceptPaymentBtn.BackColor = System.Drawing.Color.Teal;
            this.acceptPaymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.acceptPaymentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptPaymentBtn.ForeColor = System.Drawing.Color.White;
            this.acceptPaymentBtn.Location = new System.Drawing.Point(1082, 282);
            this.acceptPaymentBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.acceptPaymentBtn.Name = "acceptPaymentBtn";
            this.acceptPaymentBtn.Size = new System.Drawing.Size(241, 71);
            this.acceptPaymentBtn.TabIndex = 6;
            this.acceptPaymentBtn.Text = "Accpet Payment + Generate Reciept";
            this.acceptPaymentBtn.UseVisualStyleBackColor = false;
            this.acceptPaymentBtn.Click += new System.EventHandler(this.acceptPaymentBtn_Click);
            // 
            // updateProfileBtn
            // 
            this.updateProfileBtn.BackColor = System.Drawing.Color.Teal;
            this.updateProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateProfileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProfileBtn.ForeColor = System.Drawing.Color.White;
            this.updateProfileBtn.Location = new System.Drawing.Point(668, 393);
            this.updateProfileBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.updateProfileBtn.Name = "updateProfileBtn";
            this.updateProfileBtn.Size = new System.Drawing.Size(281, 60);
            this.updateProfileBtn.TabIndex = 7;
            this.updateProfileBtn.Text = "Update my Profile";
            this.updateProfileBtn.UseVisualStyleBackColor = false;
            this.updateProfileBtn.Click += new System.EventHandler(this.updateProfileBtn_Click);
            // 
            // registerNewCustomerBtn
            // 
            this.registerNewCustomerBtn.BackColor = System.Drawing.Color.Teal;
            this.registerNewCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerNewCustomerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerNewCustomerBtn.ForeColor = System.Drawing.Color.White;
            this.registerNewCustomerBtn.Location = new System.Drawing.Point(668, 482);
            this.registerNewCustomerBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.registerNewCustomerBtn.Name = "registerNewCustomerBtn";
            this.registerNewCustomerBtn.Size = new System.Drawing.Size(330, 65);
            this.registerNewCustomerBtn.TabIndex = 8;
            this.registerNewCustomerBtn.Text = "Register New Customer";
            this.registerNewCustomerBtn.UseVisualStyleBackColor = false;
            this.registerNewCustomerBtn.Click += new System.EventHandler(this.registerNewCustomerBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(639, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select...";
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.Teal;
            this.logOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.ForeColor = System.Drawing.Color.White;
            this.logOutBtn.Location = new System.Drawing.Point(1139, 436);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(216, 65);
            this.logOutBtn.TabIndex = 13;
            this.logOutBtn.Text = "Log out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ACH.Properties.Resources.this2;
            this.pictureBox1.Location = new System.Drawing.Point(-118, -11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(740, 682);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(13, 212);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(585, 141);
            this.label5.TabIndex = 15;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // declinePaymentBtn
            // 
            this.declinePaymentBtn.BackColor = System.Drawing.Color.Gray;
            this.declinePaymentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.declinePaymentBtn.Location = new System.Drawing.Point(858, 282);
            this.declinePaymentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.declinePaymentBtn.Name = "declinePaymentBtn";
            this.declinePaymentBtn.Size = new System.Drawing.Size(144, 71);
            this.declinePaymentBtn.TabIndex = 16;
            this.declinePaymentBtn.Text = "Decline Payment";
            this.declinePaymentBtn.UseVisualStyleBackColor = false;
            this.declinePaymentBtn.Click += new System.EventHandler(this.declinePaymentBtn_Click);
            // 
            // pendingPaymentsLbl
            // 
            this.pendingPaymentsLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pendingPaymentsLbl.Location = new System.Drawing.Point(858, 197);
            this.pendingPaymentsLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pendingPaymentsLbl.Name = "pendingPaymentsLbl";
            this.pendingPaymentsLbl.Size = new System.Drawing.Size(300, 29);
            this.pendingPaymentsLbl.TabIndex = 17;
            this.pendingPaymentsLbl.Click += new System.EventHandler(this.pendingPaymentsLbl_Click);
            // 
            // requestedServiceComBox
            // 
            this.requestedServiceComBox.FormattingEnabled = true;
            this.requestedServiceComBox.Location = new System.Drawing.Point(858, 113);
            this.requestedServiceComBox.Name = "requestedServiceComBox";
            this.requestedServiceComBox.Size = new System.Drawing.Size(497, 28);
            this.requestedServiceComBox.TabIndex = 18;
            this.requestedServiceComBox.SelectedIndexChanged += new System.EventHandler(this.requestedServiceComBox_SelectedIndexChanged);
            // 
            // receptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1411, 533);
            this.Controls.Add(this.pendingPaymentsLbl);
            this.Controls.Add(this.declinePaymentBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.registerNewCustomerBtn);
            this.Controls.Add(this.updateProfileBtn);
            this.Controls.Add(this.acceptPaymentBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.requestedServiceComBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "receptionistForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receptionist";
            this.Load += new System.EventHandler(this.receptionistForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button acceptPaymentBtn;
        private System.Windows.Forms.Button updateProfileBtn;
        private System.Windows.Forms.Button registerNewCustomerBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button declinePaymentBtn;
        private System.Windows.Forms.Label pendingPaymentsLbl;
        private System.Windows.Forms.ComboBox requestedServiceComBox;
    }
}