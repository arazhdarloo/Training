using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Training___windowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle();
            triangle.a = int.Parse(textBox1.Text);
            triangle.b = int.Parse(textBox2.Text);
            triangle.c = int.Parse(textBox3.Text);

            label1.Text = triangle.calc().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            factorial factorial = new factorial();
            factorial.number = int.Parse(textBox4.Text);
            factorial.calc();
        }
    }
    public class Triangle
    {
        public int a;
        public int b;
        public int c;

        public bool calc()
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            else { return false; }
        }
    }
    public class factorial
    {
        public int number;

        public void calc()
        {
            int res = 1;
            for (int i = 1; i <= number; i++)
            {
                res = res * i;
            }
            MessageBox.Show(res.ToString());
        }
    }
}
