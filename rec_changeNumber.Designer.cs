namespace ACH
{
    partial class changeContactNumberForm
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
            this.currentNumberLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.newNumberTextBox = new System.Windows.Forms.TextBox();
            this.saveNewNumberBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(714, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Number:";
            // 
            // currentNumberLbl
            // 
            this.currentNumberLbl.BackColor = System.Drawing.Color.Transparent;
            this.currentNumberLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.currentNumberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentNumberLbl.ForeColor = System.Drawing.Color.Black;
            this.currentNumberLbl.Location = new System.Drawing.Point(802, 144);
            this.currentNumberLbl.Name = "currentNumberLbl";
            this.currentNumberLbl.Size = new System.Drawing.Size(165, 21);
            this.currentNumberLbl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(714, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Number:";
            // 
            // newNumberTextBox
            // 
            this.newNumberTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.newNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNumberTextBox.Location = new System.Drawing.Point(802, 246);
            this.newNumberTextBox.Name = "newNumberTextBox";
            this.newNumberTextBox.Size = new System.Drawing.Size(165, 27);
            this.newNumberTextBox.TabIndex = 3;
            // 
            // saveNewNumberBtn
            // 
            this.saveNewNumberBtn.BackColor = System.Drawing.Color.Teal;
            this.saveNewNumberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveNewNumberBtn.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNewNumberBtn.ForeColor = System.Drawing.Color.White;
            this.saveNewNumberBtn.Location = new System.Drawing.Point(781, 361);
            this.saveNewNumberBtn.Name = "saveNewNumberBtn";
            this.saveNewNumberBtn.Size = new System.Drawing.Size(196, 46);
            this.saveNewNumberBtn.TabIndex = 6;
            this.saveNewNumberBtn.Text = "Save New Number";
            this.saveNewNumberBtn.UseVisualStyleBackColor = false;
            this.saveNewNumberBtn.Click += new System.EventHandler(this.saveNewNumberBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ACH.Properties.Resources.this2;
            this.pictureBox1.Location = new System.Drawing.Point(0, -26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 546);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(21, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(518, 46);
            this.label4.TabIndex = 20;
            this.label4.Text = "Change Contact Number";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeContactNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 474);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.saveNewNumberBtn);
            this.Controls.Add(this.newNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentNumberLbl);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "changeContactNumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Contact Number";
            this.Load += new System.EventHandler(this.changeContactNumberForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentNumberLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newNumberTextBox;
        private System.Windows.Forms.Button saveNewNumberBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}