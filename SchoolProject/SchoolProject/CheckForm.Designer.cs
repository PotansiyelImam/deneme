namespace SchoolProject
{
    partial class CheckForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckForm));
            this.BackButtonCheck = new System.Windows.Forms.Button();
            this.PayButtonCheck = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BankIDLabel = new System.Windows.Forms.Label();
            this.TotalLabelch = new System.Windows.Forms.Label();
            this.TotalLabelCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButtonCheck
            // 
            this.BackButtonCheck.BackColor = System.Drawing.SystemColors.Info;
            this.BackButtonCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackButtonCheck.BackgroundImage")));
            this.BackButtonCheck.Location = new System.Drawing.Point(12, 12);
            this.BackButtonCheck.Name = "BackButtonCheck";
            this.BackButtonCheck.Size = new System.Drawing.Size(87, 50);
            this.BackButtonCheck.TabIndex = 0;
            this.BackButtonCheck.UseVisualStyleBackColor = false;
            this.BackButtonCheck.Click += new System.EventHandler(this.BackButtonCheck_Click);
            // 
            // PayButtonCheck
            // 
            this.PayButtonCheck.BackColor = System.Drawing.SystemColors.Info;
            this.PayButtonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PayButtonCheck.Location = new System.Drawing.Point(468, 332);
            this.PayButtonCheck.Name = "PayButtonCheck";
            this.PayButtonCheck.Size = new System.Drawing.Size(169, 79);
            this.PayButtonCheck.TabIndex = 1;
            this.PayButtonCheck.Text = "ÖDEME YAP";
            this.PayButtonCheck.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(425, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(425, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 26);
            this.textBox2.TabIndex = 3;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NameLabel.Location = new System.Drawing.Point(227, 81);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(54, 25);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "İsim";
            // 
            // BankIDLabel
            // 
            this.BankIDLabel.AutoSize = true;
            this.BankIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BankIDLabel.Location = new System.Drawing.Point(227, 166);
            this.BankIDLabel.Name = "BankIDLabel";
            this.BankIDLabel.Size = new System.Drawing.Size(94, 25);
            this.BankIDLabel.TabIndex = 5;
            this.BankIDLabel.Text = "Bank ID";
            // 
            // TotalLabelch
            // 
            this.TotalLabelch.AutoSize = true;
            this.TotalLabelch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TotalLabelch.Location = new System.Drawing.Point(85, 310);
            this.TotalLabelch.Name = "TotalLabelch";
            this.TotalLabelch.Size = new System.Drawing.Size(253, 31);
            this.TotalLabelch.TabIndex = 6;
            this.TotalLabelch.Text = "TOPLAM TUTAR :";
            // 
            // TotalLabelCheck
            // 
            this.TotalLabelCheck.AutoSize = true;
            this.TotalLabelCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TotalLabelCheck.Location = new System.Drawing.Point(278, 310);
            this.TotalLabelCheck.Name = "TotalLabelCheck";
            this.TotalLabelCheck.Size = new System.Drawing.Size(0, 31);
            this.TotalLabelCheck.TabIndex = 7;
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalLabelCheck);
            this.Controls.Add(this.TotalLabelch);
            this.Controls.Add(this.BankIDLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PayButtonCheck);
            this.Controls.Add(this.BackButtonCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckForm";
            this.Text = "CheckForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButtonCheck;
        private System.Windows.Forms.Button PayButtonCheck;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label BankIDLabel;
        private System.Windows.Forms.Label TotalLabelch;
        private System.Windows.Forms.Label TotalLabelCheck;
    }
}