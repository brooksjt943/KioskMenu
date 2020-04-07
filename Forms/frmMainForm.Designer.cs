namespace KioskMenu.Forms
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.picFooter = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPhotoBoothCode = new System.Windows.Forms.PictureBox();
            this.btnPhotoBooth = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNavigationCode = new System.Windows.Forms.PictureBox();
            this.btnNavigation = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGameCode = new System.Windows.Forms.PictureBox();
            this.btnGame = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFooter)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPhotoBoothCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPhotoBooth)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNavigationCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNavigation)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGameCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGame)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(452, 220);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(1025, 360);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // picHeader
            // 
            this.picHeader.BackColor = System.Drawing.Color.Transparent;
            this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.picHeader.Image = ((System.Drawing.Image)(resources.GetObject("picHeader.Image")));
            this.picHeader.Location = new System.Drawing.Point(0, 0);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(1904, 151);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 4;
            this.picHeader.TabStop = false;
            // 
            // picFooter
            // 
            this.picFooter.BackColor = System.Drawing.Color.Transparent;
            this.picFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picFooter.Image = ((System.Drawing.Image)(resources.GetObject("picFooter.Image")));
            this.picFooter.Location = new System.Drawing.Point(0, 890);
            this.picFooter.Name = "picFooter";
            this.picFooter.Size = new System.Drawing.Size(1904, 151);
            this.picFooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFooter.TabIndex = 5;
            this.picFooter.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPhotoBoothCode);
            this.panel1.Controls.Add(this.btnPhotoBooth);
            this.panel1.Location = new System.Drawing.Point(308, 633);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 200);
            this.panel1.TabIndex = 6;
            // 
            // btnPhotoBoothCode
            // 
            this.btnPhotoBoothCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPhotoBoothCode.Image = ((System.Drawing.Image)(resources.GetObject("btnPhotoBoothCode.Image")));
            this.btnPhotoBoothCode.Location = new System.Drawing.Point(200, 0);
            this.btnPhotoBoothCode.Margin = new System.Windows.Forms.Padding(0);
            this.btnPhotoBoothCode.Name = "btnPhotoBoothCode";
            this.btnPhotoBoothCode.Size = new System.Drawing.Size(200, 200);
            this.btnPhotoBoothCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPhotoBoothCode.TabIndex = 3;
            this.btnPhotoBoothCode.TabStop = false;
            this.btnPhotoBoothCode.Click += new System.EventHandler(this.btnPhotoBoothCode_Click);
            this.btnPhotoBoothCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.btnPhotoBoothCode.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnPhotoBoothCode.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnPhotoBooth
            // 
            this.btnPhotoBooth.BackColor = System.Drawing.Color.Transparent;
            this.btnPhotoBooth.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPhotoBooth.Image = ((System.Drawing.Image)(resources.GetObject("btnPhotoBooth.Image")));
            this.btnPhotoBooth.Location = new System.Drawing.Point(0, 0);
            this.btnPhotoBooth.Margin = new System.Windows.Forms.Padding(0);
            this.btnPhotoBooth.Name = "btnPhotoBooth";
            this.btnPhotoBooth.Size = new System.Drawing.Size(200, 200);
            this.btnPhotoBooth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPhotoBooth.TabIndex = 2;
            this.btnPhotoBooth.TabStop = false;
            this.btnPhotoBooth.Click += new System.EventHandler(this.btnPhotoBooth_Click);
            this.btnPhotoBooth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.btnPhotoBooth.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnPhotoBooth.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnNavigationCode);
            this.panel2.Controls.Add(this.btnNavigation);
            this.panel2.Location = new System.Drawing.Point(752, 633);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 200);
            this.panel2.TabIndex = 7;
            // 
            // btnNavigationCode
            // 
            this.btnNavigationCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNavigationCode.Image = ((System.Drawing.Image)(resources.GetObject("btnNavigationCode.Image")));
            this.btnNavigationCode.Location = new System.Drawing.Point(200, 0);
            this.btnNavigationCode.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavigationCode.Name = "btnNavigationCode";
            this.btnNavigationCode.Size = new System.Drawing.Size(200, 200);
            this.btnNavigationCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNavigationCode.TabIndex = 3;
            this.btnNavigationCode.TabStop = false;
            this.btnNavigationCode.Click += new System.EventHandler(this.btnNavigationCode_Click);
            this.btnNavigationCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.btnNavigationCode.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnNavigationCode.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnNavigation
            // 
            this.btnNavigation.BackColor = System.Drawing.Color.Transparent;
            this.btnNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNavigation.Image = ((System.Drawing.Image)(resources.GetObject("btnNavigation.Image")));
            this.btnNavigation.Location = new System.Drawing.Point(0, 0);
            this.btnNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavigation.Name = "btnNavigation";
            this.btnNavigation.Size = new System.Drawing.Size(200, 200);
            this.btnNavigation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNavigation.TabIndex = 2;
            this.btnNavigation.TabStop = false;
            this.btnNavigation.Click += new System.EventHandler(this.btnNavigation_Click);
            this.btnNavigation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.btnNavigation.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnNavigation.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnGameCode);
            this.panel3.Controls.Add(this.btnGame);
            this.panel3.Location = new System.Drawing.Point(1196, 633);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 200);
            this.panel3.TabIndex = 8;
            // 
            // btnGameCode
            // 
            this.btnGameCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGameCode.Image = ((System.Drawing.Image)(resources.GetObject("btnGameCode.Image")));
            this.btnGameCode.Location = new System.Drawing.Point(200, 0);
            this.btnGameCode.Margin = new System.Windows.Forms.Padding(0);
            this.btnGameCode.Name = "btnGameCode";
            this.btnGameCode.Size = new System.Drawing.Size(200, 200);
            this.btnGameCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGameCode.TabIndex = 3;
            this.btnGameCode.TabStop = false;
            this.btnGameCode.Click += new System.EventHandler(this.btnGameCode_Click);
            this.btnGameCode.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.btnGameCode.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnGameCode.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.Transparent;
            this.btnGame.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGame.Image = ((System.Drawing.Image)(resources.GetObject("btnGame.Image")));
            this.btnGame.Location = new System.Drawing.Point(0, 0);
            this.btnGame.Margin = new System.Windows.Forms.Padding(0);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(200, 200);
            this.btnGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGame.TabIndex = 2;
            this.btnGame.TabStop = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            this.btnGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_MouseDown);
            this.btnGame.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.btnGame.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picHeader);
            this.Controls.Add(this.picFooter);
            this.Controls.Add(this.picLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmMainForm";
            this.Text = "Kiosk Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFooter)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPhotoBoothCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPhotoBooth)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNavigationCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNavigation)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnGameCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.PictureBox picFooter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnPhotoBoothCode;
        private System.Windows.Forms.PictureBox btnPhotoBooth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnNavigationCode;
        private System.Windows.Forms.PictureBox btnNavigation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnGameCode;
        private System.Windows.Forms.PictureBox btnGame;
    }
}