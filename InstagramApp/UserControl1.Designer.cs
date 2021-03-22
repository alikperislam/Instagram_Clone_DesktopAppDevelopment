namespace InstagramApp
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.p1 = new System.Windows.Forms.PictureBox();
            this.l1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.p1.Image = ((System.Drawing.Image)(resources.GetObject("p1.Image")));
            this.p1.Location = new System.Drawing.Point(3, 3);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(73, 50);
            this.p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p1.TabIndex = 0;
            this.p1.TabStop = false;
            this.p1.UseWaitCursor = true;
            this.p1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p1_MouseClick);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.l1.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l1.Location = new System.Drawing.Point(4, 54);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(89, 23);
            this.l1.TabIndex = 1;
            this.l1.Text = "Hikayen";
            this.l1.UseWaitCursor = true;
            this.l1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p1_MouseClick);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.l1);
            this.Controls.Add(this.p1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(110, 90);
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox p1;
        public System.Windows.Forms.Label l1;
    }
}
