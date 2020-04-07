namespace KioskMenu.Forms
{
    partial class frmSlideShow
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
            this.components = new System.ComponentModel.Container();
            this.picSlideShow = new System.Windows.Forms.PictureBox();
            this.SlideShowTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSlideShow)).BeginInit();
            this.SuspendLayout();
            // 
            // picSlideShow
            // 
            this.picSlideShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSlideShow.Location = new System.Drawing.Point(0, 0);
            this.picSlideShow.Name = "picSlideShow";
            this.picSlideShow.Size = new System.Drawing.Size(1264, 681);
            this.picSlideShow.TabIndex = 0;
            this.picSlideShow.TabStop = false;
            this.picSlideShow.Click += new System.EventHandler(this.picSlideShow_Click);
            // 
            // SlideShowTimer
            // 
            this.SlideShowTimer.Interval = 5000;
            this.SlideShowTimer.Tick += new System.EventHandler(this.SlideShowTimer_Tick);
            // 
            // SlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.picSlideShow);
            this.Name = "SlideShow";
            this.Text = "Slide Show";
            this.Load += new System.EventHandler(this.SlideShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSlideShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSlideShow;
        private System.Windows.Forms.Timer SlideShowTimer;
    }
}