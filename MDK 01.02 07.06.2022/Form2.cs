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
    public partial class Form2 : Form
    {
        public Form2(string tb1, string tb2, string tb3, string tb4, string tb5, string tb6, string tb7, string tb8, string tb9)
        {
            InitializeComponent();
            int s1 = Convert.ToInt32(tb1);
            int s2 = Convert.ToInt32(tb2);
            int s3 = Convert.ToInt32(tb3);
            int s4 = Convert.ToInt32(tb4);
            int s5 = Convert.ToInt32(tb5);
            int s6 = Convert.ToInt32(tb6);
            int s7 = Convert.ToInt32(tb7);
            int s8 = Convert.ToInt32(tb8);
            int s9 = Convert.ToInt32(tb9);

            int sum = 0;
            int min = 7;
            int max = 0;
            int[] mass = new int[9];
            mass[0] = s1; mass[1] = s2; mass[2] = s3; mass[3] = s4; mass[4] = s5; mass[5] = s6; mass[6] = s7; mass[7] = s8; mass[8] = s9;

            for (int i = 0; i < 9; i++)
            {
                sum = sum + mass[i];
                if(mass[i] > max)
                {
                    max = mass[i];
                }
                if (mass[i] < min)
                {
                    min = mass[i];
                }
            }
            if (max == 6 && min == 1)
            {
                sum = (sum - 6) - 1;
                Convert.ToDouble(sum);
                sum = sum / 7;
            }
            else if(max == 6 && min > 1)
            {
                sum = sum - 6;
                Convert.ToDouble(sum);
                sum = sum / 8;
            }
            else if (max < 6 && min == 1)
            {
                sum = sum - 1;
                Convert.ToDouble(sum);
                sum = sum / 8;
            }
            else if (max < 6 && min > 1)
            {
                Convert.ToDouble(sum);
                sum = sum / 9;
            }

            String sMax = max.ToString();
            label4.Text = sMax;
            String sMin = min.ToString();
            label5.Text = sMin;
            String sSum = sum.ToString();
            label6.Text = sSum;
        }
    }
}
