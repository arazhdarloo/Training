using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculating_GPA
{
    public partial class Form1 : Form
    {
        float[] GPA = new float[5];
        int number = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (number < 5)
            {
                GPA[number] = float.Parse(textBox1.Text);
                listBox1.Items.Add(textBox1.Text);
                number++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float result = 0;
            foreach (int g in GPA)
            {
                result += g;
            }
            lblresult.Text = "the result is " + (result / 5).ToString();
        }
    }
}
