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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Home";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form game = new Form2();
            game.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form browser = new Form3();
            browser.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form test = new Form4();
            test.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form calc = new Form6();
            calc.ShowDialog();
        }
    }
}