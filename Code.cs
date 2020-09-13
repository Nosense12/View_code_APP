using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View_Site_Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            richTextBox1.Text = wc.DownloadString(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            if(richTextBox1.Text == "")
            {
                richTextBox1.Text = "Nothing here";
            }
            else
            {
                richTextBox1.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
            richTextBox1.Text = "";

            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "Nothing here";
            }
            else
            {
                richTextBox1.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Example: C:/Users /*user*/Downloads/runner.bat or C:/site.html or http://www.google.com/ ** dont use exe archive local **", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
        }
    }
}
