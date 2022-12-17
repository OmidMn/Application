using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace App
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.Text = "Browser";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            webBrowser1.Url = new Uri("http://www." + textBox1.Text);
        }
    }
}
