using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            OpenFileDialog TempOFD = new OpenFileDialog();
            if (TempOFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    textBox.Text = "";
                    textBox.Text = GenerateTOC.TOC(TempOFD.FileName, checkBox.Checked);
                }
                catch (Exception CaughtException)
                {
                    textBox.Text = "Error in TOC generation:\n" + CaughtException.Message;
                }
            }
        }

        private void button_Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox.Text);
        }
    }
}
