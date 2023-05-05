
namespace ACH
{
    partial class cusChangNumForm
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
            this.bntSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NewContactNumbertxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntSave
            // 
            this.bntSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntSave.Location = new System.Drawing.Point(137, 166);
            this.bntSave.Margin = new System.Windows.Forms.Padding(2);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(87, 31);
            this.bntSave.TabIndex = 0;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Contact Number:";
            // 
            // NewContactNumbertxt
            // 
            this.NewContactNumbertxt.Location = new System.Drawing.Point(95, 112);
            this.NewContactNumbertxt.Name = "NewContactNumbertxt";
            this.NewContactNumbertxt.Size = new System.Drawing.Size(178, 22);
            this.NewContactNumbertxt.TabIndex = 3;
            // 
            // cusChangNumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(372, 262);
            this.Controls.Add(this.NewContactNumbertxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntSave);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeBox = false;
            this.Name = "cusChangNumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.cusChangNumForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewContactNumbertxt;
    }
}

