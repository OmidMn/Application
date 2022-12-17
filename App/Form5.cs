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
    public partial class Form5 : Form
    {
        int score = 0;
        public Form5()
        {
            InitializeComponent();
            this.Text = "Test";
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            score += 1;
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            label2.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            label2.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            label2.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            label2.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            score += 1;
            label2.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;

            label3.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;

            label3.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;

            label3.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;

            label3.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;

            label4.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            score += 1;
            label3.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;

            label4.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;

            label4.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;

            label4.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            button16.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            score += 1;
            label4.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;

            button18.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            label6.Text += score*5;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;

            button18.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            label6.Text += score*5;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;

            button18.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            label6.Text += score*5;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button16.Visible = false;

            button18.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            label6.Text += score*5;
        }


        private void button18_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}