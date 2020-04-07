namespace KioskMenu.Forms
{
    partial class frmCodeSnippet
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
            this.rtbCodeSnippet = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbCodeSnippet
            // 
            this.rtbCodeSnippet.Location = new System.Drawing.Point(301, 12);
            this.rtbCodeSnippet.Name = "rtbCodeSnippet";
            this.rtbCodeSnippet.Size = new System.Drawing.Size(764, 653);
            this.rtbCodeSnippet.TabIndex = 0;
            this.rtbCodeSnippet.Text = "";
            // 
            // frmAppCodeSnippet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 677);
            this.Controls.Add(this.rtbCodeSnippet);
            this.Name = "frmAppCodeSnippet";
            this.Text = "ApplicationCode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbCodeSnippet;
    }
}