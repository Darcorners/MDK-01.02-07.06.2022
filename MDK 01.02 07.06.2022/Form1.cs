using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDK_01._02_07._06._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tb1 = textBox1.Text;
            string tb2 = textBox2.Text;
            string tb3 = textBox3.Text;
            string tb4 = textBox4.Text;
            string tb5 = textBox5.Text;
            string tb6 = textBox6.Text;
            string tb7 = textBox7.Text;
            string tb8 = textBox8.Text;
            string tb9 = textBox9.Text;

            Form2 f2 = new Form2(tb1, tb2, tb3, tb4, tb5, tb6, tb7, tb8, tb9);

            f2.Show();
        }
    }
}
