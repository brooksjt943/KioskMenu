using KioskMenu.Resources;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace KioskMenu.Forms
{
    public partial class frmSlideShow : Form
    {
        private int _imageLocation = 0;
        private List<Bitmap> imgFiles;

        public frmSlideShow()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void SlideShow_Load(object sender, EventArgs e)
        {
            SlideShowTimer.Enabled = true;
            imgFiles = new List<Bitmap>();

            ResourceSet rsrcSet = SlideShowResources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true);

            foreach (DictionaryEntry entry in rsrcSet)
            {
                imgFiles.Add((Bitmap)entry.Value);
            }
            DisplayNextImage();
        }

        private void picSlideShow_Click(object sender, EventArgs e)
        {
            frmMainForm.ActiveForm.Activate();
            DialogResult = DialogResult.OK;
        }

        private void SlideShowTimer_Tick(object sender, EventArgs e)
        {
            DisplayNextImage();
        }

        private void DisplayNextImage()
        {
            if (_imageLocation == imgFiles.Count - 1)
            {
                _imageLocation = 0;
                picSlideShow.Image = imgFiles[_imageLocation];
            }
            else
            {
                _imageLocation++;
                picSlideShow.Image = imgFiles[_imageLocation];
            }
        }
    }
}
