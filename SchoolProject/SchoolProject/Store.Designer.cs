namespace SchoolProject
{
    partial class Store
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store));
            this.DATA = new System.Windows.Forms.DataGridView();
            this.DataPic = new System.Windows.Forms.PictureBox();
            this.urunAdıLabel = new System.Windows.Forms.Label();
            this.urundatalabel = new System.Windows.Forms.Label();
            this.urunfiyatdatalabel = new System.Windows.Forms.Label();
            this.urunFiyatiLabel = new System.Windows.Forms.Label();
            this.urunstokdatalabel = new System.Windows.Forms.Label();
            this.StokDurumuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPic)).BeginInit();
            this.SuspendLayout();
            // 
            // DATA
            // 
            this.DATA.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA.GridColor = System.Drawing.SystemColors.Menu;
            this.DATA.Location = new System.Drawing.Point(438, 361);
            this.DATA.Name = "DATA";
            this.DATA.Size = new System.Drawing.Size(543, 294);
            this.DATA.TabIndex = 0;
            this.DATA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DATA_CellClick);
            // 
            // DataPic
            // 
            this.DataPic.Location = new System.Drawing.Point(610, 73);
            this.DataPic.Name = "DataPic";
            this.DataPic.Size = new System.Drawing.Size(373, 282);
            this.DataPic.TabIndex = 1;
            this.DataPic.TabStop = false;
            // 
            // urunAdıLabel
            // 
            this.urunAdıLabel.AutoSize = true;
            this.urunAdıLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunAdıLabel.Location = new System.Drawing.Point(225, 117);
            this.urunAdıLabel.Name = "urunAdıLabel";
            this.urunAdıLabel.Size = new System.Drawing.Size(108, 25);
            this.urunAdıLabel.TabIndex = 2;
            this.urunAdıLabel.Text = "Ürün Adı:";
            // 
            // urundatalabel
            // 
            this.urundatalabel.AutoSize = true;
            this.urundatalabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urundatalabel.Location = new System.Drawing.Point(402, 117);
            this.urundatalabel.Name = "urundatalabel";
            this.urundatalabel.Size = new System.Drawing.Size(0, 25);
            this.urundatalabel.TabIndex = 3;
            // 
            // urunfiyatdatalabel
            // 
            this.urunfiyatdatalabel.AutoSize = true;
            this.urunfiyatdatalabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunfiyatdatalabel.Location = new System.Drawing.Point(402, 185);
            this.urunfiyatdatalabel.Name = "urunfiyatdatalabel";
            this.urunfiyatdatalabel.Size = new System.Drawing.Size(0, 25);
            this.urunfiyatdatalabel.TabIndex = 5;
            // 
            // urunFiyatiLabel
            // 
            this.urunFiyatiLabel.AutoSize = true;
            this.urunFiyatiLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunFiyatiLabel.Location = new System.Drawing.Point(225, 185);
            this.urunFiyatiLabel.Name = "urunFiyatiLabel";
            this.urunFiyatiLabel.Size = new System.Drawing.Size(125, 25);
            this.urunFiyatiLabel.TabIndex = 4;
            this.urunFiyatiLabel.Text = "Ürün Fiyatı";
            // 
            // urunstokdatalabel
            // 
            this.urunstokdatalabel.AutoSize = true;
            this.urunstokdatalabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urunstokdatalabel.Location = new System.Drawing.Point(402, 243);
            this.urunstokdatalabel.Name = "urunstokdatalabel";
            this.urunstokdatalabel.Size = new System.Drawing.Size(0, 25);
            this.urunstokdatalabel.TabIndex = 7;
            // 
            // StokDurumuLabel
            // 
            this.StokDurumuLabel.AutoSize = true;
            this.StokDurumuLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StokDurumuLabel.Location = new System.Drawing.Point(225, 243);
            this.StokDurumuLabel.Name = "StokDurumuLabel";
            this.StokDurumuLabel.Size = new System.Drawing.Size(147, 25);
            this.StokDurumuLabel.TabIndex = 6;
            this.StokDurumuLabel.Text = "Stok Durumu";
            // 
            // Store
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(998, 667);
            this.Controls.Add(this.urunstokdatalabel);
            this.Controls.Add(this.StokDurumuLabel);
            this.Controls.Add(this.urunfiyatdatalabel);
            this.Controls.Add(this.urunFiyatiLabel);
            this.Controls.Add(this.urundatalabel);
            this.Controls.Add(this.urunAdıLabel);
            this.Controls.Add(this.DataPic);
            this.Controls.Add(this.DATA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Store";
            this.Text = "Store";
            this.Load += new System.EventHandler(this.Store_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DATA;
        private System.Windows.Forms.PictureBox DataPic;
        private System.Windows.Forms.Label urunAdıLabel;
        private System.Windows.Forms.Label urundatalabel;
        private System.Windows.Forms.Label urunfiyatdatalabel;
        private System.Windows.Forms.Label urunFiyatiLabel;
        private System.Windows.Forms.Label urunstokdatalabel;
        private System.Windows.Forms.Label StokDurumuLabel;
    }
}