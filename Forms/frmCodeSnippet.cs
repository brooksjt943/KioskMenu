using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KioskMenu.Forms
{
    public partial class frmCodeSnippet : Form
    {
        private int index = 0;
        private Image[] imageList;
        public frmCodeSnippet()
        {
            InitializeComponent();
        }

        public void CodeSnippets(string snippetLocation)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            var images = Directory.GetFiles(projectDirectory + snippetLocation, "*.png").ToList();
            imageList = new Image[images.Count];

            for (var i = 0; i < images.Count; i++)
            {
                imageList[i] = Image.FromFile(images[i]);
            }

            picCode.Image = imageList[index];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index < imageList.Length - 1)
            {
                index++;
                picCode.Image = imageList[index];
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                picCode.Image = imageList[index];
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
