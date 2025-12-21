using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quadratic_Equation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            float c = float.Parse(textBox3.Text);

            float d = (b * b) - (4 * a * c);
            
            if (d > 0)
            {
                label4.Text = ((-b + Math.Sqrt(d)) / (2 * a)).ToString() + '\n' + ((-b - Math.Sqrt(d)) / (2 * a)).ToString();
            }
            else if (d == 0)
            {
                label4.Text = (-b / (2 * a)).ToString();
            }
            else
            {
                label4.Text = "It has no roots";
            }

        }
    }
}
