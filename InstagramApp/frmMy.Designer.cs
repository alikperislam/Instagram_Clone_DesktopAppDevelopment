namespace InstagramApp
{
    partial class frmMy
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
            this.story1 = new InstagramApp.story();
            this.SuspendLayout();
            // 
            // story1
            // 
            this.story1.Location = new System.Drawing.Point(0, -1);
            this.story1.Name = "story1";
            this.story1.Size = new System.Drawing.Size(293, 473);
            this.story1.TabIndex = 0;
            this.story1.Load += new System.EventHandler(this.story1_Load);
            // 
            // frmMy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 470);
            this.Controls.Add(this.story1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMy";
            this.ResumeLayout(false);

        }

        #endregion

        private story story1;
    }
}