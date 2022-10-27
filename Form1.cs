using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F1 f = new F1();
            if (f.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F2 f = new F2();
            if (f.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            F3 f = new F3();
            if (f.ShowDialog() == DialogResult.OK)
            {
            }
        }
    }
}
