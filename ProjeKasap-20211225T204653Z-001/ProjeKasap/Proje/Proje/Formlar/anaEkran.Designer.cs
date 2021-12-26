
namespace Proje
{
    partial class anaEkran
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kAYITOLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mÜŞTERİGİRİŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kONTROLPANELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kAYITOLToolStripMenuItem,
            this.mÜŞTERİGİRİŞToolStripMenuItem,
            this.kONTROLPANELToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // kAYITOLToolStripMenuItem
            // 
            this.kAYITOLToolStripMenuItem.Name = "kAYITOLToolStripMenuItem";
            this.kAYITOLToolStripMenuItem.Size = new System.Drawing.Size(94, 21);
            this.kAYITOLToolStripMenuItem.Text = "KAYIT OL";
            this.kAYITOLToolStripMenuItem.Click += new System.EventHandler(this.kAYITOLToolStripMenuItem_Click);
            // 
            // mÜŞTERİGİRİŞToolStripMenuItem
            // 
            this.mÜŞTERİGİRİŞToolStripMenuItem.Name = "mÜŞTERİGİRİŞToolStripMenuItem";
            this.mÜŞTERİGİRİŞToolStripMenuItem.Size = new System.Drawing.Size(137, 21);
            this.mÜŞTERİGİRİŞToolStripMenuItem.Text = "MÜŞTERİ GİRİŞ";
            this.mÜŞTERİGİRİŞToolStripMenuItem.Click += new System.EventHandler(this.mÜŞTERİGİRİŞToolStripMenuItem_Click);
            // 
            // kONTROLPANELToolStripMenuItem
            // 
            this.kONTROLPANELToolStripMenuItem.Name = "kONTROLPANELToolStripMenuItem";
            this.kONTROLPANELToolStripMenuItem.Size = new System.Drawing.Size(151, 21);
            this.kONTROLPANELToolStripMenuItem.Text = "KONTROL PANEL";
            this.kONTROLPANELToolStripMenuItem.Click += new System.EventHandler(this.kONTROLPANELToolStripMenuItem_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proje.Properties.Resources.Black_Emblem_Badge_Vintage_Retro_Livestock_Farm_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-26, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(576, 486);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // anaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(531, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "anaEkran";
            this.Text = "ANA EKRAN";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kAYITOLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mÜŞTERİGİRİŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kONTROLPANELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
    }
}

