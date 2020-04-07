using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace KioskMenu
{
    public partial class SlideShowConfig : Form
    {
        string DirPath;
        int ImgIndex;
        public SlideShowConfig()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                tscbSeconds.Items.Add(i);
            }
            tscbSeconds.SelectedIndex = 0;
        }

        private void tsbLoad_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            DirPath = folderBrowserDialog1.SelectedPath;
            string[] files = Directory.GetFiles(DirPath, "*.jpg");
            foreach (string file in files)
            {
                int pos = file.LastIndexOf("||");
                string FName = file.Substring(pos + 1);
                lstImagePaths.Items.Add(FName);
            }
            lstImagePaths.SelectedIndex = ImgIndex = 0;
            tsbPrevious.Enabled = true;
            tsbNext.Enabled = true;
            tsbSetScreenSaver.Enabled = true;
        }

        private void lstImagePaths_SelectedIndexChanged(object sender, EventArgs e)
        {
            mainPictureBox.ImageLocation = lstImagePaths.SelectedItem.ToString();
        }

        private void tsbPrevious_Click(object sender, EventArgs e)
        {
            if (ImgIndex > 0)
            {
                ImgIndex -= 1;
                if (ImgIndex == 0)
                {
                    tsbPrevious.Enabled = false;
                }
                if (ImgIndex < lstImagePaths.Items.Count - 1)
                    tsbNext.Enabled = true;
                lstImagePaths.SelectedIndex = ImgIndex;
            }
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            if (ImgIndex < lstImagePaths.Items.Count - 1)
            {
                ImgIndex += 1;
                if (ImgIndex == lstImagePaths.Items.Count - 1)
                    tsbNext.Enabled = false;
                if (ImgIndex > 0)
                    tsbPrevious.Enabled = true;
                lstImagePaths.SelectedIndex = ImgIndex;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsbNext.PerformClick();
        }

        private void tsbSetScreenSaver_Click(object sender, EventArgs e)
        {
            using (ResXResourceWriter resx = new ResXResourceWriter(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\Resources\SlideShowResources.resx"))
            {
                for (int i = 0; i < lstImagePaths.Items.Count; i++)
                {
                    resx.AddResource("Image" + i, new Bitmap(lstImagePaths.Items[i].ToString()));
                }
                resx.Generate();
            }
        }
    }
}
