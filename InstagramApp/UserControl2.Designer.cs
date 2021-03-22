namespace InstagramApp
{
    partial class UserControl2
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl2));
            this.lblbegenme = new System.Windows.Forms.Label();
            this.lblyorum = new System.Windows.Forms.Label();
            this.lbldakika = new System.Windows.Forms.Label();
            this.lblisim = new System.Windows.Forms.Label();
            this.kalp = new System.Windows.Forms.PictureBox();
            this.pPP = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.begen = new System.Windows.Forms.PictureBox();
            this.pFoto = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kalp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.begen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbegenme
            // 
            this.lblbegenme.AutoSize = true;
            this.lblbegenme.Location = new System.Drawing.Point(17, 346);
            this.lblbegenme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbegenme.Name = "lblbegenme";
            this.lblbegenme.Size = new System.Drawing.Size(159, 23);
            this.lblbegenme.TabIndex = 1;
            this.lblbegenme.Text = "41.497 beğenme";
            // 
            // lblyorum
            // 
            this.lblyorum.AutoSize = true;
            this.lblyorum.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblyorum.Location = new System.Drawing.Point(17, 374);
            this.lblyorum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblyorum.Name = "lblyorum";
            this.lblyorum.Size = new System.Drawing.Size(249, 23);
            this.lblyorum.TabIndex = 2;
            this.lblyorum.Text = "177 yorumun tümünü gör";
            // 
            // lbldakika
            // 
            this.lbldakika.AutoSize = true;
            this.lbldakika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbldakika.Location = new System.Drawing.Point(17, 401);
            this.lbldakika.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldakika.Name = "lbldakika";
            this.lbldakika.Size = new System.Drawing.Size(148, 23);
            this.lbldakika.TabIndex = 3;
            this.lbldakika.Text = "37 dakika önce";
            // 
            // lblisim
            // 
            this.lblisim.AutoSize = true;
            this.lblisim.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblisim.ForeColor = System.Drawing.Color.Black;
            this.lblisim.Location = new System.Drawing.Point(54, 9);
            this.lblisim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblisim.Name = "lblisim";
            this.lblisim.Size = new System.Drawing.Size(132, 25);
            this.lblisim.TabIndex = 8;
            this.lblisim.Text = "galatasaray";
            // 
            // kalp
            // 
            this.kalp.BackColor = System.Drawing.Color.Transparent;
            this.kalp.Image = ((System.Drawing.Image)(resources.GetObject("kalp.Image")));
            this.kalp.Location = new System.Drawing.Point(236, 93);
            this.kalp.Name = "kalp";
            this.kalp.Size = new System.Drawing.Size(91, 71);
            this.kalp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.kalp.TabIndex = 10;
            this.kalp.TabStop = false;
            this.kalp.Visible = false;
            // 
            // pPP
            // 
            this.pPP.Image = ((System.Drawing.Image)(resources.GetObject("pPP.Image")));
            this.pPP.Location = new System.Drawing.Point(3, 7);
            this.pPP.Name = "pPP";
            this.pPP.Size = new System.Drawing.Size(37, 33);
            this.pPP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pPP.TabIndex = 9;
            this.pPP.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(534, 310);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 33);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(61, 310);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(41, 33);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(108, 310);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 33);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // begen
            // 
            this.begen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.begen.Image = ((System.Drawing.Image)(resources.GetObject("begen.Image")));
            this.begen.Location = new System.Drawing.Point(21, 310);
            this.begen.Name = "begen";
            this.begen.Size = new System.Drawing.Size(34, 33);
            this.begen.TabIndex = 4;
            this.begen.TabStop = false;
            this.begen.Click += new System.EventHandler(this.begen_Click);
            // 
            // pFoto
            // 
            this.pFoto.Image = ((System.Drawing.Image)(resources.GetObject("pFoto.Image")));
            this.pFoto.Location = new System.Drawing.Point(0, 47);
            this.pFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pFoto.Name = "pFoto";
            this.pFoto.Size = new System.Drawing.Size(574, 256);
            this.pFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pFoto.TabIndex = 0;
            this.pFoto.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kalp);
            this.Controls.Add(this.pPP);
            this.Controls.Add(this.lblisim);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.begen);
            this.Controls.Add(this.lbldakika);
            this.Controls.Add(this.lblyorum);
            this.Controls.Add(this.lblbegenme);
            this.Controls.Add(this.pFoto);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(574, 431);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kalp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.begen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox begen;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.PictureBox pFoto;
        public System.Windows.Forms.Label lblbegenme;
        public System.Windows.Forms.Label lblyorum;
        public System.Windows.Forms.Label lbldakika;
        public System.Windows.Forms.Label lblisim;
        public System.Windows.Forms.PictureBox pPP;
        private System.Windows.Forms.PictureBox kalp;
        private System.Windows.Forms.Timer timer1;
    }
}
