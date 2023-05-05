namespace ACH
{
    partial class registerNewCustomerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerNumberTextBox = new System.Windows.Forms.TextBox();
            this.accountPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(653, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(653, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Number:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(653, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(653, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirms Password:";
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.BackColor = System.Drawing.Color.Teal;
            this.createAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createAccountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountBtn.ForeColor = System.Drawing.Color.White;
            this.createAccountBtn.Location = new System.Drawing.Point(831, 370);
            this.createAccountBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(180, 49);
            this.createAccountBtn.TabIndex = 4;
            this.createAccountBtn.Text = "Create Account";
            this.createAccountBtn.UseVisualStyleBackColor = false;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(831, 121);
            this.customerNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(255, 27);
            this.customerNameTextBox.TabIndex = 5;
            this.customerNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.customerNameTextBox_Validating);
            // 
            // customerNumberTextBox
            // 
            this.customerNumberTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.customerNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNumberTextBox.Location = new System.Drawing.Point(831, 180);
            this.customerNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerNumberTextBox.Name = "customerNumberTextBox";
            this.customerNumberTextBox.Size = new System.Drawing.Size(255, 27);
            this.customerNumberTextBox.TabIndex = 6;
            // 
            // accountPasswordTextBox
            // 
            this.accountPasswordTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.accountPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountPasswordTextBox.Location = new System.Drawing.Point(831, 241);
            this.accountPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountPasswordTextBox.Name = "accountPasswordTextBox";
            this.accountPasswordTextBox.Size = new System.Drawing.Size(255, 27);
            this.accountPasswordTextBox.TabIndex = 7;
            this.accountPasswordTextBox.TextChanged += new System.EventHandler(this.accountPasswordTextBox_TextChanged);
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(831, 306);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(255, 27);
            this.confirmPasswordTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(616, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "Enter details...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ACH.Properties.Resources.this2;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 546);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(15, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(502, 46);
            this.label7.TabIndex = 19;
            this.label7.Text = "Register New Customer";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // registerNewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1181, 533);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.accountPasswordTextBox);
            this.Controls.Add(this.customerNumberTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "registerNewCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Register New Customer";
            this.Load += new System.EventHandler(this.registerNewCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox customerNumberTextBox;
        private System.Windows.Forms.TextBox accountPasswordTextBox;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}