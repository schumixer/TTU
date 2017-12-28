using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Виндовс_формс
{
    public partial class Form1 : Form
    {

        private double first;
        private bool znak;
        private int count;

        public Form1()
        { 
            InitializeComponent();
            count = 0;
            znak = true;//ITS ME
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            first = 0;
            label1.Text = "";
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && label1.Text == "")
            {
                first = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 1;
                znak = true;
                label1.Text = first.ToString() + " + ";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && label1.Text == "")
            {
                first = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 2;
                znak = true;
                label1.Text = first.ToString() + " - ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && label1.Text == "")
            {
                first = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 3;
                znak = true;
                label1.Text = first.ToString() + " : ";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && label1.Text == "")
            {
                first = double.Parse(textBox1.Text);
                textBox1.Clear();
                count = 4;
                znak = true;
                label1.Text = first.ToString() + " * ";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && label1.Text == "")
            {
                if (textBox1.Text[0] == '-')
                {
                    znak = false;
                }
                if (znak)
                {
                    textBox1.Text = "-" + textBox1.Text;
                    znak = false;
                }
                else
                {
                    textBox1.Text = textBox1.Text.Replace("-", "");
                    znak = true;
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (count == 1)
                {
                    textBox1.Text = (first + (double.Parse(textBox1.Text))).ToString();
                }
                else if (count == 2)
                {
                    textBox1.Text = (first - (double.Parse(textBox1.Text))).ToString();
                }
                else if (count == 3)
                {
                    textBox1.Text = (first / (double.Parse(textBox1.Text))).ToString();
                }
                else if (count == 4)
                {
                    textBox1.Text = (first * (double.Parse(textBox1.Text))).ToString();
                }
                label1.Text = "";
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && label1.Text == "")
            {
                
                textBox1.Text += "0,";
            }
            else
            
            if (textBox1.Text.IndexOf(",") == -1)
                {
                    textBox1.Text += ",";
                }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
