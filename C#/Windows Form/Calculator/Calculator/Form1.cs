using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int operate;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            operate = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operate = 1;
            label1.Text = "+";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operate = 2;
            label1.Text = "-";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            operate = 3;
            label1.Text = "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operate = 4;
            label1.Text = "/";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            float result;
            switch (operate)
            {
                case 1:
                    result = float.Parse(textBox1.Text) + float.Parse(textBox2.Text); 
                    break;
                case 2:
                    result = float.Parse(textBox1.Text) - float.Parse(textBox2.Text);
                    break;
                case 3:
                    result = float.Parse(textBox1.Text) * float.Parse(textBox2.Text);
                    break;
                case 4:
                    result = float.Parse(textBox1.Text) / float.Parse(textBox2.Text);
                    break;
                default:
                    result = 0;
                    break;
            }

            resultlbl.Text = result.ToString();
        }
    }
}
