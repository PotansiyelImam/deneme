namespace SchoolProject
{
    partial class CashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashForm));
            this.SumLabel = new System.Windows.Forms.Label();
            this.TextLabelSum = new System.Windows.Forms.Label();
            this.ReceivedLabel = new System.Windows.Forms.Label();
            this.PayButton = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.ReceivedTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SumLabel
            // 
            this.SumLabel.AutoSize = true;
            this.SumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SumLabel.Location = new System.Drawing.Point(365, 158);
            this.SumLabel.Name = "SumLabel";
            this.SumLabel.Size = new System.Drawing.Size(0, 31);
            this.SumLabel.TabIndex = 3;
            // 
            // TextLabelSum
            // 
            this.TextLabelSum.AutoSize = true;
            this.TextLabelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextLabelSum.Location = new System.Drawing.Point(146, 158);
            this.TextLabelSum.Name = "TextLabelSum";
            this.TextLabelSum.Size = new System.Drawing.Size(253, 31);
            this.TextLabelSum.TabIndex = 4;
            this.TextLabelSum.Text = "TOPLAM TUTAR :";
            this.TextLabelSum.Click += new System.EventHandler(this.TextLabelSum_Click);
            // 
            // ReceivedLabel
            // 
            this.ReceivedLabel.AutoSize = true;
            this.ReceivedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ReceivedLabel.Location = new System.Drawing.Point(147, 68);
            this.ReceivedLabel.Name = "ReceivedLabel";
            this.ReceivedLabel.Size = new System.Drawing.Size(94, 25);
            this.ReceivedLabel.TabIndex = 7;
            this.ReceivedLabel.Text = "Ödenen";
            // 
            // PayButton
            // 
            this.PayButton.BackColor = System.Drawing.SystemColors.Info;
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PayButton.Location = new System.Drawing.Point(258, 267);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(164, 47);
            this.PayButton.TabIndex = 10;
            this.PayButton.Text = "Pay";
            this.PayButton.UseVisualStyleBackColor = false;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.BackColor = System.Drawing.SystemColors.Info;
            this.GoBackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GoBackButton.BackgroundImage")));
            this.GoBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GoBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GoBackButton.Location = new System.Drawing.Point(12, 12);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(93, 53);
            this.GoBackButton.TabIndex = 11;
            this.GoBackButton.UseVisualStyleBackColor = false;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // ReceivedTextBox
            // 
            this.ReceivedTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.ReceivedTextBox.Location = new System.Drawing.Point(382, 72);
            this.ReceivedTextBox.Name = "ReceivedTextBox";
            this.ReceivedTextBox.Size = new System.Drawing.Size(100, 20);
            this.ReceivedTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(252, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "İade Tutarı :";
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ChangeLabel.Location = new System.Drawing.Point(443, 359);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(0, 31);
            this.ChangeLabel.TabIndex = 14;
            // 
            // CashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChangeLabel);
            this.Controls.Add(this.ReceivedTextBox);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.ReceivedLabel);
            this.Controls.Add(this.TextLabelSum);
            this.Controls.Add(this.SumLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashForm";
            this.Text = "CashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SumLabel;
        private System.Windows.Forms.Label TextLabelSum;
        private System.Windows.Forms.Label ReceivedLabel;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.TextBox ReceivedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ChangeLabel;
    }
}