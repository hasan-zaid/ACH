namespace ACH
{
    partial class formTechChgPw
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrentPw = new System.Windows.Forms.TextBox();
            this.txtNewPw1 = new System.Windows.Forms.TextBox();
            this.txtNewPw2 = new System.Windows.Forms.TextBox();
            this.btnSavePw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(80, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Re-type New Password :";
            // 
            // txtCurrentPw
            // 
            this.txtCurrentPw.Location = new System.Drawing.Point(45, 92);
            this.txtCurrentPw.Name = "txtCurrentPw";
            this.txtCurrentPw.Size = new System.Drawing.Size(212, 20);
            this.txtCurrentPw.TabIndex = 5;
            // 
            // txtNewPw1
            // 
            this.txtNewPw1.Location = new System.Drawing.Point(45, 139);
            this.txtNewPw1.Name = "txtNewPw1";
            this.txtNewPw1.Size = new System.Drawing.Size(212, 20);
            this.txtNewPw1.TabIndex = 6;
            // 
            // txtNewPw2
            // 
            this.txtNewPw2.Location = new System.Drawing.Point(45, 191);
            this.txtNewPw2.Name = "txtNewPw2";
            this.txtNewPw2.Size = new System.Drawing.Size(212, 20);
            this.txtNewPw2.TabIndex = 7;
            // 
            // btnSavePw
            // 
            this.btnSavePw.BackColor = System.Drawing.Color.Teal;
            this.btnSavePw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePw.Location = new System.Drawing.Point(103, 217);
            this.btnSavePw.Name = "btnSavePw";
            this.btnSavePw.Size = new System.Drawing.Size(97, 37);
            this.btnSavePw.TabIndex = 8;
            this.btnSavePw.Text = "Save Change";
            this.btnSavePw.UseVisualStyleBackColor = false;
            this.btnSavePw.Click += new System.EventHandler(this.btnSavePw_Click);
            // 
            // formTechChgPw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 282);
            this.Controls.Add(this.btnSavePw);
            this.Controls.Add(this.txtNewPw2);
            this.Controls.Add(this.txtNewPw1);
            this.Controls.Add(this.txtCurrentPw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formTechChgPw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentPw;
        private System.Windows.Forms.TextBox txtNewPw1;
        private System.Windows.Forms.TextBox txtNewPw2;
        private System.Windows.Forms.Button btnSavePw;
    }
}