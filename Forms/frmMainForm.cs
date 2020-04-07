using KioskMenu.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskMenu.Forms
{
    public partial class frmMainForm : Form
    {
        const string password = "kioskPassword2020";
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPhotoBoothCode_Click(object sender, EventArgs e)
        {
            frmCodeSnippet code = new frmCodeSnippet();
            code.Show();
        }

        private void btnPhotoBooth_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = @"C:\KioskApps\"; // Change photo booth file location
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            ExternalProcess.Start();
            Cursor = Cursors.Arrow;
            ExternalProcess.WaitForExit();
        }

        private void btnNavigationCode_Click(object sender, EventArgs e)
        {
            frmCodeSnippet code = new frmCodeSnippet();
            code.Show();
        }

        private void btnNavigation_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = @"C:\KioskApps\"; // Change navigation file location
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            ExternalProcess.Start();
            Cursor = Cursors.Arrow;
            ExternalProcess.WaitForExit();
        }

        private void btnGameCode_Click(object sender, EventArgs e)
        {
            frmCodeSnippet code = new frmCodeSnippet();
            code.Show();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Process ExternalProcess = new Process();
            ExternalProcess.StartInfo.FileName = @"C:\KioskApps\"; // Change game file location
            ExternalProcess.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            ExternalProcess.Start();
            Cursor = Cursors.Arrow;
            ExternalProcess.WaitForExit();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                SlideShowConfig form = new SlideShowConfig();
                form.ShowDialog();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                string promptValue = Prompt.ShowDialog("Password: ", "Enter Password");
                if (promptValue == password)
                    Application.Exit();
                else
                    MessageBox.Show("Incorrect Password");
            }
        }

        private void btnSlideShow_Click(object sender, EventArgs e)
        {
            frmSlideShow slideShow = new frmSlideShow();
            slideShow.ShowDialog();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            /*
            UserActivity activity = new UserActivity();
            activity.RequestUserActivity();
            activity.UserAtivited += btnSlideShow_Click;
            */
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender.Equals(btnPhotoBooth))
                btnPhotoBooth.Image = Resources.Images.PhotoHover;
            else if (sender.Equals(btnNavigation))
                btnNavigation.Image = Resources.Images.MapHover;
            else if (sender.Equals(btnGame))
                btnGame.Image = Resources.Images.GameHover;
            else if (sender.Equals(btnPhotoBoothCode))
                btnPhotoBoothCode.Image = Resources.Images.CodeHover;
            else if (sender.Equals(btnNavigationCode))
                btnNavigationCode.Image = Resources.Images.CodeHover;
            else if (sender.Equals(btnGameCode))
                btnGameCode.Image = Resources.Images.CodeHover;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender.Equals(btnPhotoBooth))
                btnPhotoBooth.Image = Resources.Images.PhotoButton;
            else if (sender.Equals(btnNavigation))
                btnNavigation.Image = Resources.Images.MapButton;
            else if (sender.Equals(btnGame))
                btnGame.Image = Resources.Images.GameButton;
            else if (sender.Equals(btnPhotoBoothCode))
                btnPhotoBoothCode.Image = Resources.Images.CodeButton;
            else if (sender.Equals(btnNavigationCode))
                btnNavigationCode.Image = Resources.Images.CodeButton;
            else if (sender.Equals(btnGameCode))
                btnGameCode.Image = Resources.Images.CodeButton;
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender.Equals(btnPhotoBooth))
                btnPhotoBooth.Image = Resources.Images.PhotoClick;
            else if (sender.Equals(btnNavigation))
                btnNavigation.Image = Resources.Images.MapClick;
            else if (sender.Equals(btnGame))
                btnGame.Image = Resources.Images.GameClick;
            else if (sender.Equals(btnPhotoBoothCode))
                btnPhotoBoothCode.Image = Resources.Images.CodeClick;
            else if (sender.Equals(btnNavigationCode))
                btnNavigationCode.Image = Resources.Images.CodeClick;
            else if (sender.Equals(btnGameCode))
                btnGameCode.Image = Resources.Images.CodeClick;
        }
    }
}
