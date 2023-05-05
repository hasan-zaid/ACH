
namespace costomer_change_password
{
    partial class cusChangPassForm
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
            this.CurrentPassword = new System.Windows.Forms.Label();
            this.NewPassword = new System.Windows.Forms.Label();
            this.ConfirmPassword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CurrentPassword
            // 
            this.CurrentPassword.AutoSize = true;
            this.CurrentPassword.Location = new System.Drawing.Point(469, 62);
            this.CurrentPassword.Name = "CurrentPassword";
            this.CurrentPassword.Size = new System.Drawing.Size(187, 25);
            this.CurrentPassword.TabIndex = 0;
            this.CurrentPassword.Text = "Current password:";
            // 
            // NewPassword
            // 
            this.NewPassword.AutoSize = true;
            this.NewPassword.Location = new System.Drawing.Point(469, 199);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(158, 25);
            this.NewPassword.TabIndex = 1;
            this.NewPassword.Text = "New password:";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.Location = new System.Drawing.Point(455, 324);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(190, 25);
            this.ConfirmPassword.TabIndex = 2;
            this.ConfirmPassword.Text = "Confirm password:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(460, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 31);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(460, 243);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 31);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(449, 372);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 31);
            this.textBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(825, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save changes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1174, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.CurrentPassword);
            this.MinimizeBox = false;
            this.Name = "cusChangPassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer change password";
            this.Load += new System.EventHandler(this.cusChangPassForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentPassword;
        private System.Windows.Forms.Label NewPassword;
        private System.Windows.Forms.Label ConfirmPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}

