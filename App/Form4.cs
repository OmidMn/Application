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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.Text = "Exam";
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form exam = new Form5();
            exam.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = true;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = false;
            button5.Visible = false;
        }
    }
}
