namespace ACH
{
    partial class changePasswordForm
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
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.saveNewPasswordBtn = new System.Windows.Forms.Button();
            this.currentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(710, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(710, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Password:";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.newPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTextBox.Location = new System.Drawing.Point(827, 238);
            this.newPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '*';
            this.newPasswordTextBox.Size = new System.Drawing.Size(205, 27);
            this.newPasswordTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(710, 308);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm New Password:";
            // 
            // confirmNewPasswordTextBox
            // 
            this.confirmNewPasswordTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.confirmNewPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmNewPasswordTextBox.Location = new System.Drawing.Point(827, 365);
            this.confirmNewPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
            this.confirmNewPasswordTextBox.PasswordChar = '*';
            this.confirmNewPasswordTextBox.Size = new System.Drawing.Size(205, 27);
            this.confirmNewPasswordTextBox.TabIndex = 6;
            // 
            // saveNewPasswordBtn
            // 
            this.saveNewPasswordBtn.BackColor = System.Drawing.Color.Teal;
            this.saveNewPasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveNewPasswordBtn.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNewPasswordBtn.ForeColor = System.Drawing.Color.White;
            this.saveNewPasswordBtn.Location = new System.Drawing.Point(785, 455);
            this.saveNewPasswordBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveNewPasswordBtn.Name = "saveNewPasswordBtn";
            this.saveNewPasswordBtn.Size = new System.Drawing.Size(206, 41);
            this.saveNewPasswordBtn.TabIndex = 7;
            this.saveNewPasswordBtn.Text = "Save New Password";
            this.saveNewPasswordBtn.UseVisualStyleBackColor = false;
            this.saveNewPasswordBtn.Click += new System.EventHandler(this.saveNewPasswordBtn_Click);
            // 
            // currentPasswordTextBox
            // 
            this.currentPasswordTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.currentPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPasswordTextBox.Location = new System.Drawing.Point(827, 119);
            this.currentPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.currentPasswordTextBox.Name = "currentPasswordTextBox";
            this.currentPasswordTextBox.Size = new System.Drawing.Size(205, 27);
            this.currentPasswordTextBox.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ACH.Properties.Resources.this2;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 546);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(60, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 46);
            this.label4.TabIndex = 19;
            this.label4.Text = "Change Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // changePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 533);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.currentPasswordTextBox);
            this.Controls.Add(this.saveNewPasswordBtn);
            this.Controls.Add(this.confirmNewPasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newPasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "changePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.changePasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmNewPasswordTextBox;
        private System.Windows.Forms.Button saveNewPasswordBtn;
        private System.Windows.Forms.TextBox currentPasswordTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}