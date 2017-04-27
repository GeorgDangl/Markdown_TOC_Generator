using System;
using System.Windows.Forms;

namespace GenerateMarkdownTOC
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {
            var tempOfd = new OpenFileDialog();
            if (tempOfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textBox.Text = "";
                    textBox.Text = GenerateToc.Toc(tempOfd.FileName, checkBox.Checked);
                }
                catch (Exception caughtException)
                {
                    textBox.Text = "Error in TOC generation:\n" + caughtException.Message;
                }
            }
        }

        private void button_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox.Text);
        }
    }
}
