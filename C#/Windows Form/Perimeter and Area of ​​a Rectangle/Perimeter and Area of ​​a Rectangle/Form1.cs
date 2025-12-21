using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perimeter_and_Area_of_​​a_Rectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "the perimeter is " + (2 * (float.Parse(textBox1.Text) + float.Parse(textBox2.Text)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "the area is " + (float.Parse(textBox1.Text) * float.Parse(textBox2.Text));

        }
    }
}
