using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Season_Finder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (int.Parse(textBox1.Text))
            {
                case 1:
                    label2.Text = "spring";
                    break;
                case 2:
                    label2.Text = "summer";
                    break;
                case 3:
                    label2.Text = "fall";
                    break;
                case 4:
                    label2.Text = "winter";
                    break;
                default:
                    label2.Text = "its wrong number";
                    break;
            }
        }
    }
}
