namespace SchoolProject
{
    partial class GirisEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkran));
            this.button1 = new System.Windows.Forms.Button();
            this.girisLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.KayitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(2, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 359);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADMİN";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // girisLabel
            // 
            this.girisLabel.AutoSize = true;
            this.girisLabel.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisLabel.Location = new System.Drawing.Point(128, 9);
            this.girisLabel.Name = "girisLabel";
            this.girisLabel.Size = new System.Drawing.Size(361, 62);
            this.girisLabel.TabIndex = 1;
            this.girisLabel.Text = "Mağazamıza Hoşgeldiniz\r\nLütfen giriş yapınız \r\n";
            this.girisLabel.Click += new System.EventHandler(this.girisLabel_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(305, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(297, 359);
            this.button2.TabIndex = 2;
            this.button2.Text = "MÜŞTERİ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KayitButton
            // 
            this.KayitButton.BackColor = System.Drawing.SystemColors.Info;
            this.KayitButton.Location = new System.Drawing.Point(13, 13);
            this.KayitButton.Name = "KayitButton";
            this.KayitButton.Size = new System.Drawing.Size(77, 55);
            this.KayitButton.TabIndex = 3;
            this.KayitButton.Text = "KAYDOL";
            this.KayitButton.UseVisualStyleBackColor = false;
            this.KayitButton.Click += new System.EventHandler(this.KayitButton_Click);
            // 
            // GirisEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(602, 433);
            this.Controls.Add(this.KayitButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.girisLabel);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GirisEkran";
            this.Text = "GirisEkran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label girisLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button KayitButton;
    }
}