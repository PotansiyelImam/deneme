namespace SchoolProject
{
    partial class KullaniciGİris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGİris));
            this.JustPic = new System.Windows.Forms.Button();
            this.KullaniciSifreLabel = new System.Windows.Forms.Label();
            this.KullaniciAdiLabel = new System.Windows.Forms.Label();
            this.KullaniciSifreTextBox = new System.Windows.Forms.TextBox();
            this.KullaniciAdiTextBox = new System.Windows.Forms.TextBox();
            this.KullaniciGirisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JustPic
            // 
            this.JustPic.BackColor = System.Drawing.SystemColors.Info;
            this.JustPic.Image = ((System.Drawing.Image)(resources.GetObject("JustPic.Image")));
            this.JustPic.Location = new System.Drawing.Point(41, 15);
            this.JustPic.Name = "JustPic";
            this.JustPic.Size = new System.Drawing.Size(282, 198);
            this.JustPic.TabIndex = 11;
            this.JustPic.UseVisualStyleBackColor = false;
            // 
            // KullaniciSifreLabel
            // 
            this.KullaniciSifreLabel.AutoSize = true;
            this.KullaniciSifreLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KullaniciSifreLabel.Location = new System.Drawing.Point(37, 274);
            this.KullaniciSifreLabel.Name = "KullaniciSifreLabel";
            this.KullaniciSifreLabel.Size = new System.Drawing.Size(54, 23);
            this.KullaniciSifreLabel.TabIndex = 10;
            this.KullaniciSifreLabel.Text = "Şifre";
            // 
            // KullaniciAdiLabel
            // 
            this.KullaniciAdiLabel.AutoSize = true;
            this.KullaniciAdiLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KullaniciAdiLabel.Location = new System.Drawing.Point(37, 219);
            this.KullaniciAdiLabel.Name = "KullaniciAdiLabel";
            this.KullaniciAdiLabel.Size = new System.Drawing.Size(130, 23);
            this.KullaniciAdiLabel.TabIndex = 9;
            this.KullaniciAdiLabel.Text = "Kullanıcı Adı";
            // 
            // KullaniciSifreTextBox
            // 
            this.KullaniciSifreTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.KullaniciSifreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciSifreTextBox.Location = new System.Drawing.Point(223, 274);
            this.KullaniciSifreTextBox.Name = "KullaniciSifreTextBox";
            this.KullaniciSifreTextBox.Size = new System.Drawing.Size(100, 31);
            this.KullaniciSifreTextBox.TabIndex = 8;
            // 
            // KullaniciAdiTextBox
            // 
            this.KullaniciAdiTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.KullaniciAdiTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciAdiTextBox.Location = new System.Drawing.Point(223, 219);
            this.KullaniciAdiTextBox.Name = "KullaniciAdiTextBox";
            this.KullaniciAdiTextBox.Size = new System.Drawing.Size(100, 31);
            this.KullaniciAdiTextBox.TabIndex = 7;
            // 
            // KullaniciGirisButton
            // 
            this.KullaniciGirisButton.BackColor = System.Drawing.SystemColors.Info;
            this.KullaniciGirisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciGirisButton.Location = new System.Drawing.Point(41, 330);
            this.KullaniciGirisButton.Name = "KullaniciGirisButton";
            this.KullaniciGirisButton.Size = new System.Drawing.Size(282, 83);
            this.KullaniciGirisButton.TabIndex = 6;
            this.KullaniciGirisButton.Text = "GİRİŞ";
            this.KullaniciGirisButton.UseVisualStyleBackColor = false;
            this.KullaniciGirisButton.Click += new System.EventHandler(this.AdminGirisButton_Click);
            // 
            // KullaniciGİris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(361, 429);
            this.Controls.Add(this.JustPic);
            this.Controls.Add(this.KullaniciSifreLabel);
            this.Controls.Add(this.KullaniciAdiLabel);
            this.Controls.Add(this.KullaniciSifreTextBox);
            this.Controls.Add(this.KullaniciAdiTextBox);
            this.Controls.Add(this.KullaniciGirisButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciGİris";
            this.Text = "KullaniciGİris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button JustPic;
        private System.Windows.Forms.Label KullaniciSifreLabel;
        private System.Windows.Forms.Label KullaniciAdiLabel;
        private System.Windows.Forms.TextBox KullaniciSifreTextBox;
        private System.Windows.Forms.TextBox KullaniciAdiTextBox;
        private System.Windows.Forms.Button KullaniciGirisButton;
    }
}