namespace ACH
{
    partial class formTechChangeContact
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
            this.txtNewContact = new System.Windows.Forms.TextBox();
            this.btnSaveContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Contact No.";
            // 
            // txtNewContact
            // 
            this.txtNewContact.Location = new System.Drawing.Point(34, 67);
            this.txtNewContact.Name = "txtNewContact";
            this.txtNewContact.Size = new System.Drawing.Size(172, 20);
            this.txtNewContact.TabIndex = 1;
            // 
            // btnSaveContact
            // 
            this.btnSaveContact.BackColor = System.Drawing.Color.Teal;
            this.btnSaveContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveContact.Location = new System.Drawing.Point(72, 116);
            this.btnSaveContact.Name = "btnSaveContact";
            this.btnSaveContact.Size = new System.Drawing.Size(103, 33);
            this.btnSaveContact.TabIndex = 2;
            this.btnSaveContact.Text = "Save Change";
            this.btnSaveContact.UseVisualStyleBackColor = false;
            this.btnSaveContact.Click += new System.EventHandler(this.btnSaveContact_Click);
            // 
            // formTechChangeContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 174);
            this.Controls.Add(this.btnSaveContact);
            this.Controls.Add(this.txtNewContact);
            this.Controls.Add(this.label1);
            this.Name = "formTechChangeContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewContact;
        private System.Windows.Forms.Button btnSaveContact;
    }
}