namespace SchoolProject
{
    partial class AdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGiris));
            this.AdminGirisButton = new System.Windows.Forms.Button();
            this.AdminIsimTextBox = new System.Windows.Forms.TextBox();
            this.AdminSifreTextBox = new System.Windows.Forms.TextBox();
            this.AdminIDLabel = new System.Windows.Forms.Label();
            this.AdminSifreLabel = new System.Windows.Forms.Label();
            this.JustPic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminGirisButton
            // 
            this.AdminGirisButton.BackColor = System.Drawing.SystemColors.Info;
            this.AdminGirisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminGirisButton.Location = new System.Drawing.Point(37, 327);
            this.AdminGirisButton.Name = "AdminGirisButton";
            this.AdminGirisButton.Size = new System.Drawing.Size(282, 83);
            this.AdminGirisButton.TabIndex = 0;
            this.AdminGirisButton.Text = "GİRİŞ";
            this.AdminGirisButton.UseVisualStyleBackColor = false;
            this.AdminGirisButton.Click += new System.EventHandler(this.AdminGirisButton_Click);
            // 
            // AdminIsimTextBox
            // 
            this.AdminIsimTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.AdminIsimTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminIsimTextBox.Location = new System.Drawing.Point(219, 216);
            this.AdminIsimTextBox.Name = "AdminIsimTextBox";
            this.AdminIsimTextBox.Size = new System.Drawing.Size(100, 31);
            this.AdminIsimTextBox.TabIndex = 1;
            this.AdminIsimTextBox.TextChanged += new System.EventHandler(this.AdminIsimTextBox_TextChanged);
            // 
            // AdminSifreTextBox
            // 
            this.AdminSifreTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.AdminSifreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdminSifreTextBox.Location = new System.Drawing.Point(219, 271);
            this.AdminSifreTextBox.Name = "AdminSifreTextBox";
            this.AdminSifreTextBox.Size = new System.Drawing.Size(100, 31);
            this.AdminSifreTextBox.TabIndex = 2;
            this.AdminSifreTextBox.TextChanged += new System.EventHandler(this.AdminSifreTextBox_TextChanged);
            // 
            // AdminIDLabel
            // 
            this.AdminIDLabel.AutoSize = true;
            this.AdminIDLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminIDLabel.Location = new System.Drawing.Point(33, 216);
            this.AdminIDLabel.Name = "AdminIDLabel";
            this.AdminIDLabel.Size = new System.Drawing.Size(99, 23);
            this.AdminIDLabel.TabIndex = 3;
            this.AdminIDLabel.Text = "Admin ID";
            // 
            // AdminSifreLabel
            // 
            this.AdminSifreLabel.AutoSize = true;
            this.AdminSifreLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSifreLabel.Location = new System.Drawing.Point(33, 271);
            this.AdminSifreLabel.Name = "AdminSifreLabel";
            this.AdminSifreLabel.Size = new System.Drawing.Size(122, 23);
            this.AdminSifreLabel.TabIndex = 4;
            this.AdminSifreLabel.Text = "Admin Şifre";
            // 
            // JustPic
            // 
            this.JustPic.BackColor = System.Drawing.SystemColors.Info;
            this.JustPic.Image = ((System.Drawing.Image)(resources.GetObject("JustPic.Image")));
            this.JustPic.Location = new System.Drawing.Point(37, 12);
            this.JustPic.Name = "JustPic";
            this.JustPic.Size = new System.Drawing.Size(282, 198);
            this.JustPic.TabIndex = 5;
            this.JustPic.UseVisualStyleBackColor = false;
            // 
            // AdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(361, 429);
            this.Controls.Add(this.JustPic);
            this.Controls.Add(this.AdminSifreLabel);
            this.Controls.Add(this.AdminIDLabel);
            this.Controls.Add(this.AdminSifreTextBox);
            this.Controls.Add(this.AdminIsimTextBox);
            this.Controls.Add(this.AdminGirisButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminGiris";
            this.Text = "AdminGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AdminGirisButton;
        private System.Windows.Forms.TextBox AdminIsimTextBox;
        private System.Windows.Forms.TextBox AdminSifreTextBox;
        private System.Windows.Forms.Label AdminIDLabel;
        private System.Windows.Forms.Label AdminSifreLabel;
        private System.Windows.Forms.Button JustPic;
    }
}