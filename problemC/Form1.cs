using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problemC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            Bitmap bitmap = new Bitmap(path);
            pictureBox1.Image = bitmap;
            int pointLeftX = -1, pointLeftY = -1, pointRightX = -1, pointRightY = -1;
            for (int i = 0; i < 32 && pointLeftY == -1; i++)
            {
                for (int j = 31; j >= 0 && pointLeftX == -1; j--)
                {
                    if (bitmap.GetPixel(i, j).R == 0)
                    {
                        pointLeftX = i;
                        pointLeftY = 31-j;
                    }
                }
            }
            for (int i = 31; i >= 0 && pointRightY == -1; i--)
            {
                for (int j = 31; j >= 0 && pointRightX == -1; j--)
                {
                    if (bitmap.GetPixel(i, j).R == 0)
                    {
                        pointRightX = i;
                        pointRightY = 31-j;
                        break;
                    }
                }
            }
            label2.Text = String.Format("線段左邊端({0},{1})點座標", pointLeftX, pointLeftY);
            label3.Text = String.Format("線段右邊端({0},{1})點座標", pointRightX, pointRightY);
            double m = ((pointRightY - pointLeftY) * 1.0) / ((pointRightX - pointLeftX) * 1.0);
            label4.Text = String.Format("線段斜率 {0:0.00}", m) ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
