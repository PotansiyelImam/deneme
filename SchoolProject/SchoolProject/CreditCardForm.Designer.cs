namespace SchoolProject
{
    partial class CreditCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditCardForm));
            this.BackButtonCC = new System.Windows.Forms.Button();
            this.PayButtonCC = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CardNumberLabel = new System.Windows.Forms.Label();
            this.CardTypeLabel = new System.Windows.Forms.Label();
            this.SKTLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalLabelCC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButtonCC
            // 
            this.BackButtonCC.BackColor = System.Drawing.SystemColors.Info;
            this.BackButtonCC.Image = ((System.Drawing.Image)(resources.GetObject("BackButtonCC.Image")));
            this.BackButtonCC.Location = new System.Drawing.Point(12, 12);
            this.BackButtonCC.Name = "BackButtonCC";
            this.BackButtonCC.Size = new System.Drawing.Size(92, 59);
            this.BackButtonCC.TabIndex = 0;
            this.BackButtonCC.UseVisualStyleBackColor = false;
            this.BackButtonCC.Click += new System.EventHandler(this.BackButtonCC_Click);
            // 
            // PayButtonCC
            // 
            this.PayButtonCC.BackColor = System.Drawing.SystemColors.Info;
            this.PayButtonCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PayButtonCC.Location = new System.Drawing.Point(463, 319);
            this.PayButtonCC.Name = "PayButtonCC";
            this.PayButtonCC.Size = new System.Drawing.Size(147, 77);
            this.PayButtonCC.TabIndex = 1;
            this.PayButtonCC.Text = "ÖDEME YAP";
            this.PayButtonCC.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(415, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 26);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(415, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(138, 26);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(415, 226);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(138, 26);
            this.textBox3.TabIndex = 4;
            // 
            // CardNumberLabel
            // 
            this.CardNumberLabel.AutoSize = true;
            this.CardNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CardNumberLabel.Location = new System.Drawing.Point(174, 88);
            this.CardNumberLabel.Name = "CardNumberLabel";
            this.CardNumberLabel.Size = new System.Drawing.Size(161, 25);
            this.CardNumberLabel.TabIndex = 5;
            this.CardNumberLabel.Text = "Kart Numarası";
            // 
            // CardTypeLabel
            // 
            this.CardTypeLabel.AutoSize = true;
            this.CardTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CardTypeLabel.Location = new System.Drawing.Point(174, 156);
            this.CardTypeLabel.Name = "CardTypeLabel";
            this.CardTypeLabel.Size = new System.Drawing.Size(101, 25);
            this.CardTypeLabel.TabIndex = 6;
            this.CardTypeLabel.Text = "Kart Tipi";
            // 
            // SKTLabel
            // 
            this.SKTLabel.AutoSize = true;
            this.SKTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SKTLabel.Location = new System.Drawing.Point(174, 227);
            this.SKTLabel.Name = "SKTLabel";
            this.SKTLabel.Size = new System.Drawing.Size(70, 25);
            this.SKTLabel.TabIndex = 7;
            this.SKTLabel.Text = "SKTT";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TotalLabel.Location = new System.Drawing.Point(82, 332);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(253, 31);
            this.TotalLabel.TabIndex = 8;
            this.TotalLabel.Text = "TOPLAM TUTAR :";
            // 
            // TotalLabelCC
            // 
            this.TotalLabelCC.AutoSize = true;
            this.TotalLabelCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TotalLabelCC.Location = new System.Drawing.Point(240, 332);
            this.TotalLabelCC.Name = "TotalLabelCC";
            this.TotalLabelCC.Size = new System.Drawing.Size(0, 31);
            this.TotalLabelCC.TabIndex = 9;
            // 
            // CreditCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalLabelCC);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.SKTLabel);
            this.Controls.Add(this.CardTypeLabel);
            this.Controls.Add(this.CardNumberLabel);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PayButtonCC);
            this.Controls.Add(this.BackButtonCC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreditCardForm";
            this.Text = "CreditCardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButtonCC;
        private System.Windows.Forms.Button PayButtonCC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label CardNumberLabel;
        private System.Windows.Forms.Label CardTypeLabel;
        private System.Windows.Forms.Label SKTLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TotalLabelCC;
    }
}