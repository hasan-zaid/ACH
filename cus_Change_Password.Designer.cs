
namespace ACH
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
            this.SaveChangesBtn = new System.Windows.Forms.Button();
            this.CurrentPasswordtxt = new System.Windows.Forms.TextBox();
            this.NewPasswordtxt = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CurrentPassword
            // 
            this.CurrentPassword.AutoSize = true;
            this.CurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPassword.Location = new System.Drawing.Point(92, 34);
            this.CurrentPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentPassword.Name = "CurrentPassword";
            this.CurrentPassword.Size = new System.Drawing.Size(147, 20);
            this.CurrentPassword.TabIndex = 0;
            this.CurrentPassword.Text = "Current password:";
            // 
            // NewPassword
            // 
            this.NewPassword.AutoSize = true;
            this.NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassword.Location = new System.Drawing.Point(92, 121);
            this.NewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(124, 20);
            this.NewPassword.TabIndex = 1;
            this.NewPassword.Text = "New password:";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.AutoSize = true;
            this.ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.Location = new System.Drawing.Point(82, 201);
            this.ConfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.Size = new System.Drawing.Size(150, 20);
            this.ConfirmPassword.TabIndex = 2;
            this.ConfirmPassword.Text = "Confirm password:";
            // 
            // SaveChangesBtn
            // 
            this.SaveChangesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChangesBtn.Location = new System.Drawing.Point(79, 293);
            this.SaveChangesBtn.Name = "SaveChangesBtn";
            this.SaveChangesBtn.Size = new System.Drawing.Size(153, 37);
            this.SaveChangesBtn.TabIndex = 7;
            this.SaveChangesBtn.Text = "Save Changes";
            this.SaveChangesBtn.UseVisualStyleBackColor = true;
            this.SaveChangesBtn.Click += new System.EventHandler(this.SaveChangesBtn_Click);
            // 
            // CurrentPasswordtxt
            // 
            this.CurrentPasswordtxt.Location = new System.Drawing.Point(95, 64);
            this.CurrentPasswordtxt.Name = "CurrentPasswordtxt";
            this.CurrentPasswordtxt.Size = new System.Drawing.Size(111, 22);
            this.CurrentPasswordtxt.TabIndex = 8;
            // 
            // NewPasswordtxt
            // 
            this.NewPasswordtxt.Location = new System.Drawing.Point(95, 154);
            this.NewPasswordtxt.Name = "NewPasswordtxt";
            this.NewPasswordtxt.Size = new System.Drawing.Size(111, 22);
            this.NewPasswordtxt.TabIndex = 9;
            // 
            // ConfirmPasswordtxt
            // 
            this.ConfirmPasswordtxt.Location = new System.Drawing.Point(96, 232);
            this.ConfirmPasswordtxt.Name = "ConfirmPasswordtxt";
            this.ConfirmPasswordtxt.Size = new System.Drawing.Size(111, 22);
            this.ConfirmPasswordtxt.TabIndex = 10;
            // 
            // cusChangPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(343, 391);
            this.Controls.Add(this.ConfirmPasswordtxt);
            this.Controls.Add(this.NewPasswordtxt);
            this.Controls.Add(this.CurrentPasswordtxt);
            this.Controls.Add(this.SaveChangesBtn);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.CurrentPassword);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button SaveChangesBtn;
        private System.Windows.Forms.TextBox CurrentPasswordtxt;
        private System.Windows.Forms.TextBox NewPasswordtxt;
        private System.Windows.Forms.TextBox ConfirmPasswordtxt;
    }
}

