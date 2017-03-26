using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MaxCut
{
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
           
            prompt.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            prompt.Width = 250;
            prompt.Height = 150;
            prompt.Text = caption;
            Label textLabel = new Label() { Left = 50,Width=110, Top = 10, Text = text };
            TextBox textBox = new TextBox() { Left = 70,TabIndex=0,TabStop=true, Top = 40, Width = 70 };
            Button confirmation = new Button() { Text = "Ok", Left = 80, Width = 60, Top = 75 };
            prompt.AcceptButton = confirmation;
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            textBox.TabIndex = 0;
            textBox.TabStop = true;
            prompt.ShowDialog();
            textBox.Focus();

            return textBox.Text;
        }

    }
}
