using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Even_or_Odd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(int.Parse(textBox1.Text) % 2 == 0) {
                label2.Text = "this is even";
            }
            else
            {
                label2.Text = "this is odd";
            }
        }
    }
}
