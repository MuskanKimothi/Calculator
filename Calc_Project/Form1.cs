using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num1, ans;
        int count;

        private void button8_Click(object sender, EventArgs e)
        {
            button15.Text = button15.Text + 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button15.Text = button15.Text + 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button15.Text = button15.Text + 3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button15.Text = button15.Text + 6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button15.Text = button15.Text + 5;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button15.Text = button15.Text + 4;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button15.Text = button15.Text + 9;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button15.Text = button15.Text + 8;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button15.Text = button15.Text + 7;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button15.Text = button15.Text + 0;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button15.Text = button15.Text + 0 + 0;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(button15.Text);
            button15.Clear();
            button15.Focus();
            count = 2;

        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            if (button15.Text != "")
            {
                num1 = float.Parse(button15.Text);
                button15.Clear();
                button15.Focus();
                count = 1;
            }
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(button15.Text);
            button15.Clear();
            button15.Focus();
            count = 3;
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(button15.Text);
            button15.Clear();
            button15.Focus();
            count = 4;
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            compute(count);
        }
        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(button15.Text);
                    button15.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(button15.Text);
                    button15.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(button15.Text);
                    button15.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(button15.Text);
                    button15.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            button15.Clear();
            count = 0;
        }

        private void btndivide_Click_1(object sender, EventArgs e)
        {
            num1 = float.Parse(button15.Text);
            button15.Clear();
            button15.Focus();
            count = 4;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            int c = button15.TextLength;
            int flag = 0;
            string text = button15.Text;
            for (int i = 0; i < c; i++)
            {
                if (text[i].ToString() == ".")
                {
                    flag = 1; break;
                }
                else
                {
                    flag = 0;
                }
            }
            if (flag == 0)
            {
                button15.Text = button15.Text + ".";
            }
        }





    }
    }

