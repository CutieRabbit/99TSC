using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problemA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "a";
            textBox2.Text = "b";
            textBox3.Text = "c";
            textBox4.Text = "d";
            label1.Text = "";

            int aplusb = Convert.ToInt16(textBox6.Text); //a+b的那一格
            int aplusc = Convert.ToInt16(textBox10.Text); //a+c的那一格
            int bplusd = Convert.ToInt16(textBox9.Text); //b+d的那一格
            int aplusd = Convert.ToInt16(textBox8.Text); //a+d的那一格
            int cplusd = Convert.ToInt16(textBox7.Text); //c+d的那一格
            int cplusb = Convert.ToInt16(textBox5.Text); //c+b的那一格

            int two_aplusbplusc = (aplusb + cplusb + aplusc);

            int[] check_array = { aplusb, aplusc, bplusd, aplusd, cplusd, cplusb };
            bool find = false;

            for(int i = 0; i < check_array.Length; i++)
            {
                if(check_array[i] > 20 || check_array[i] < -20)
                {
                    find = true;
                    break;
                }
            }

            if(find == true)
            {
                label1.Text = "數字超過範圍";
                return;
            }

            if(two_aplusbplusc % 2 != 0)
            {
                label1.Text = "無解";
                return;
            }

            int aplusbplusc = two_aplusbplusc / 2;
            int a = aplusbplusc - cplusb;
            int b = aplusbplusc - aplusc;
            int c = aplusbplusc - aplusb;
            int d = bplusd - b;

            textBox1.Text = a + "";
            textBox2.Text = b + "";
            textBox3.Text = c + "";
            textBox4.Text = d + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
    
}
