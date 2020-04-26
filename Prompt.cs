using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace KioskMenu
{
    
    public static class Prompt
    {// Just a prompt form to get the email address from the user.
        public static bool ShowDialog(string text, string caption, string value, string error)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 40, Text = text, Font = new Font("Segoe UI", 12) };
            TextBox textBox = new TextBox() { Left = 135, Top = 38, Width = 200, Font = new Font("Segoe UI", 12) };
            Button confirmation = new Button() { Text = "OK", Left = 345, AutoSize = true, Top = 37, Font = new Font("Segoe UI", 12) };
            //confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            textBox.PasswordChar = '*';
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            bool textMatch = false;
            prompt.ShowDialog();
            if (textBox.Text == value)
            {
                textMatch = true;
                prompt.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(error, "SCC Kiosk", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return textMatch;
        }
    }
}
