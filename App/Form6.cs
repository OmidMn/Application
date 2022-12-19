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
    public partial class Form6 : Form
    {
        float a = 0, b = 0, c = 0;
        string first, second, operato;
        public Form6()
        {
            InitializeComponent();
            this.Text = "Calculator";
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e){
            textBox1.Text += 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            first = textBox1.Text;
            textBox1.Text = "";
            operato = "/";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            first = textBox1.Text;
            textBox1.Text = "";
            operato = "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            first = textBox1.Text;
            textBox1.Text = "";
            operato = "+";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            first = textBox1.Text;
            textBox1.Text = "";
            operato = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            second = textBox1.Text;
            a = Convert.ToInt32(first);
            b = Convert.ToInt32(second);
            textBox1.Text = "";

            if (operato == "+") textBox1.Text += a + b;
            if (operato == "-") textBox1.Text += a - b;
            if (operato == "/") textBox1.Text += a / b;
            if (operato == "*") textBox1.Text += a * b;
        }
    }
}