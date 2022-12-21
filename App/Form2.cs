using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace App
{
    public partial class Form2 : Form
    {
        int second = 0, res = 0;

        public Form2()
        {
            InitializeComponent();
            this.Text = "Game";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer1.Start();
            res += 1;
            button7.Visible = false;
            button4.BackColor = Color.FromArgb(255,255,255);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (second <= 99)
            {
                second += 1;
                progressBar1.Value = second;
            }

            else
            {
                timer1.Stop();
                MessageBox.Show("Time's up");
                Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button7.Visible == false)
            {
                res += 1;
                button4.Visible = false;
                button9.BackColor = Color.FromArgb(255, 255, 255);
            }
            else 
            {
                MessageBox.Show("Wrong Button");
                timer1.Stop();
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button14.Visible == false)
            {
                res += 1;
                button3.Visible = false;
                button15.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                MessageBox.Show("Wrong Button");
                timer1.Stop();
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button8.Visible == false)
            {
                res += 1;
                button2.Visible = false;
                button10.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                MessageBox.Show("Wrong Button");
                timer1.Stop();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button12.Visible == false)
            {
                res += 1;
                button1.Visible = false;
                button6.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                MessageBox.Show("Wrong Button");
                timer1.Stop();
                Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button13.Visible == false)
            {
                res += 1;
                button5.Visible = false;
                button8.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                MessageBox.Show("Wrong Button");
                timer1.Stop();
                Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button1.Visible == false)
            {
                res += 1;
                button6.Visible = false;
                timer1.Stop();
                if (res == 16) MessageBox.Show("You won");
                Close();
            }
            else
            {
                MessageBox.Show("Wrong Button");
                timer1.Stop();
                Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button5.Visible == false)
            {
                res += 1;
                button8.Visible = false;
                button2.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                MessageBox.Show("Wrong Button");
                timer1.Stop();
                Close();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button11.Visible == false)
            {
                res += 1;
                button12.Visible = false;
                button1.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                MessageBox.Show("Wrong Button");
                timer1.Stop();
                Close();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button15.Visible == false)
            {
                res += 1;
                button11.Visible = false;
                button12.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                MessageBox.Show("Wrong Button");
                timer1.Stop();
                Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button2.Visible == false)
            {
                res += 1;
                button10.Visible = false;
                button16.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                MessageBox.Show("Wrong Button");
                timer1.Stop();
                Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button4.Visible == false)
            {
                res += 1;
                button9.Visible = false;
                button13.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                MessageBox.Show("Wrong Button");
                timer1.Stop();
                Close();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button9.Visible == false)
            {
                res += 1;
                button13.Visible = false;
                button5.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                MessageBox.Show("Wrong Button");
                timer1.Stop();
                Close();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button16.Visible == false)
            {
                res += 1;
                button14.Visible = false;
                button3.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                MessageBox.Show("Wrong Button");
                timer1.Stop();
                Close();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button3.Visible == false)
            {
                res += 1;
                button15.Visible = false;
                button11.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                MessageBox.Show("Wrong Button");
                timer1.Stop();
                Close();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button10.Visible == false)
            {
                res += 1;
                button16.Visible = false;
                button14.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                MessageBox.Show("Wrong Button");
                timer1.Stop();
                Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
