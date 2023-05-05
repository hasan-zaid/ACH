
namespace ACH
{
    partial class mainCustomerForm
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
            this.makePaymentBtn = new System.Windows.Forms.Button();
            this.servicesComBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PaymentTxtBox = new System.Windows.Forms.TextBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.urgentServiceRadBtn = new System.Windows.Forms.RadioButton();
            this.normalServiceRadBtn = new System.Windows.Forms.RadioButton();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.viewRequestedServiceBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.customerUpdateProfileBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcomeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // makePaymentBtn
            // 
            this.makePaymentBtn.BackColor = System.Drawing.Color.Teal;
            this.makePaymentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makePaymentBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.makePaymentBtn.Location = new System.Drawing.Point(960, 310);
            this.makePaymentBtn.Margin = new System.Windows.Forms.Padding(2);
            this.makePaymentBtn.Name = "makePaymentBtn";
            this.makePaymentBtn.Size = new System.Drawing.Size(123, 54);
            this.makePaymentBtn.TabIndex = 1;
            this.makePaymentBtn.Text = "Confirm Payment";
            this.makePaymentBtn.UseVisualStyleBackColor = false;
            this.makePaymentBtn.Click += new System.EventHandler(this.makePaymentBtn_Click);
            // 
            // servicesComBox
            // 
            this.servicesComBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesComBox.FormattingEnabled = true;
            this.servicesComBox.Location = new System.Drawing.Point(599, 75);
            this.servicesComBox.Margin = new System.Windows.Forms.Padding(2);
            this.servicesComBox.Name = "servicesComBox";
            this.servicesComBox.Size = new System.Drawing.Size(484, 28);
            this.servicesComBox.TabIndex = 2;
            this.servicesComBox.Text = "Service type";
            this.servicesComBox.SelectedIndexChanged += new System.EventHandler(this.servicesComBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(801, 195);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Service price:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(802, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Make Payment:";
            // 
            // PaymentTxtBox
            // 
            this.PaymentTxtBox.Location = new System.Drawing.Point(960, 246);
            this.PaymentTxtBox.Margin = new System.Windows.Forms.Padding(2);
            this.PaymentTxtBox.Name = "PaymentTxtBox";
            this.PaymentTxtBox.Size = new System.Drawing.Size(123, 22);
            this.PaymentTxtBox.TabIndex = 7;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Teal;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutBtn.Location = new System.Drawing.Point(576, 399);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(150, 54);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // urgentServiceRadBtn
            // 
            this.urgentServiceRadBtn.AutoSize = true;
            this.urgentServiceRadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urgentServiceRadBtn.Location = new System.Drawing.Point(932, 132);
            this.urgentServiceRadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.urgentServiceRadBtn.Name = "urgentServiceRadBtn";
            this.urgentServiceRadBtn.Size = new System.Drawing.Size(80, 24);
            this.urgentServiceRadBtn.TabIndex = 11;
            this.urgentServiceRadBtn.TabStop = true;
            this.urgentServiceRadBtn.Text = "Urgent";
            this.urgentServiceRadBtn.UseVisualStyleBackColor = true;
            this.urgentServiceRadBtn.CheckedChanged += new System.EventHandler(this.urgentServiceRadBtn_CheckedChanged);
            // 
            // normalServiceRadBtn
            // 
            this.normalServiceRadBtn.AutoSize = true;
            this.normalServiceRadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.normalServiceRadBtn.Location = new System.Drawing.Point(830, 132);
            this.normalServiceRadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.normalServiceRadBtn.Name = "normalServiceRadBtn";
            this.normalServiceRadBtn.Size = new System.Drawing.Size(84, 24);
            this.normalServiceRadBtn.TabIndex = 12;
            this.normalServiceRadBtn.TabStop = true;
            this.normalServiceRadBtn.Text = "Normal";
            this.normalServiceRadBtn.UseVisualStyleBackColor = true;
            this.normalServiceRadBtn.CheckedChanged += new System.EventHandler(this.normalServiceRadBtn_CheckedChanged);
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.BackColor = System.Drawing.Color.Honeydew;
            this.PriceLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.Location = new System.Drawing.Point(960, 195);
            this.PriceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(2, 22);
            this.PriceLbl.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(698, 330);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 15;
            // 
            // viewRequestedServiceBtn
            // 
            this.viewRequestedServiceBtn.BackColor = System.Drawing.Color.Teal;
            this.viewRequestedServiceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRequestedServiceBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.viewRequestedServiceBtn.Location = new System.Drawing.Point(576, 310);
            this.viewRequestedServiceBtn.Margin = new System.Windows.Forms.Padding(2);
            this.viewRequestedServiceBtn.Name = "viewRequestedServiceBtn";
            this.viewRequestedServiceBtn.Size = new System.Drawing.Size(203, 54);
            this.viewRequestedServiceBtn.TabIndex = 16;
            this.viewRequestedServiceBtn.Text = "View Status of Requested Services";
            this.viewRequestedServiceBtn.UseVisualStyleBackColor = false;
            this.viewRequestedServiceBtn.Click += new System.EventHandler(this.viewRequestedServiceBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // customerUpdateProfileBtn
            // 
            this.customerUpdateProfileBtn.BackColor = System.Drawing.Color.Teal;
            this.customerUpdateProfileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerUpdateProfileBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.customerUpdateProfileBtn.Location = new System.Drawing.Point(960, 399);
            this.customerUpdateProfileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.customerUpdateProfileBtn.Name = "customerUpdateProfileBtn";
            this.customerUpdateProfileBtn.Size = new System.Drawing.Size(123, 54);
            this.customerUpdateProfileBtn.TabIndex = 18;
            this.customerUpdateProfileBtn.Text = "Update Profile";
            this.customerUpdateProfileBtn.UseVisualStyleBackColor = false;
            this.customerUpdateProfileBtn.Click += new System.EventHandler(this.customerUpdateProfileBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ACH.Properties.Resources.this2;
            this.pictureBox1.Location = new System.Drawing.Point(-183, -119);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(740, 682);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.BackColor = System.Drawing.Color.Teal;
            this.welcomeLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.welcomeLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.welcomeLbl.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.welcomeLbl.Location = new System.Drawing.Point(25, 195);
            this.welcomeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(448, 73);
            this.welcomeLbl.TabIndex = 20;
            // 
            // mainCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1134, 469);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customerUpdateProfileBtn);
            this.Controls.Add(this.viewRequestedServiceBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.normalServiceRadBtn);
            this.Controls.Add(this.urgentServiceRadBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.PaymentTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.servicesComBox);
            this.Controls.Add(this.makePaymentBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "mainCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Costomer Page";
            this.Load += new System.EventHandler(this.mainCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button makePaymentBtn;
        private System.Windows.Forms.ComboBox servicesComBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PaymentTxtBox;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.RadioButton urgentServiceRadBtn;
        private System.Windows.Forms.RadioButton normalServiceRadBtn;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button viewRequestedServiceBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button customerUpdateProfileBtn;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

