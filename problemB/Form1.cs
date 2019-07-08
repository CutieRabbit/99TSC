using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace problemB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string fileName = ofd.FileName;
            if (fileName.Equals(""))
            {
                return;
            }
            string data;
            using (StreamReader fs = new StreamReader(fileName))
            {
                while ((data = fs.ReadLine()) != null)
                {
                    string[] dataArray = data.Split(' ');
                    int[] dataIntegerArray = new int[dataArray.Length];
                    for (int i = 0; i < dataArray.Length; i++)
                    {
                        dataIntegerArray[i] = Convert.ToInt32(dataArray[i]);
                    }
                    for (int i = 0; i < dataIntegerArray[1]; i++)
                    {
                        int x = dataIntegerArray[2 + i * 3];
                        int y = dataIntegerArray[2 + i * 3 + 1];
                        int group = dataIntegerArray[2 + i * 3 + 2];
                        if (group == 0)
                        {
                            chart1.Series[0].Points.AddXY(x, y);
                        }
                        else if (group == 1)
                        {
                            chart1.Series[1].Points.AddXY(x, y);
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }
    }
}
