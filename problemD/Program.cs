using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemD
{
    class Program
    {
        static void Main(string[] args)
        {
            String data = Console.ReadLine();
            string[] split = data.Split(',');
            int[] integerData = new int[split.Length];
            for (int i = 0; i < split.Length; i++)
            {
                integerData[i] = Convert.ToInt16(split[i].Trim());
            }
            if (integerData[0] > integerData[1] || integerData[2] == 0 && integerData[5] == 0 || integerData[3] > integerData[4] || integerData[2] == 1 && integerData[5] == 1)
            {
                Console.WriteLine("違反題意。");
                return;
            }
            int[,] status = {
                {3,3,1,0,0,0},
                {1,3,0,2,0,1},
                {2,3,1,1,0,0},
                {0,3,0,3,0,1},
                {1,3,1,2,0,0},
                {1,1,0,2,2,1},
                {2,2,1,1,1,0},
                {2,0,0,1,3,1},
                {3,0,1,0,3,0},
                {1,0,0,2,3,1},
                {2,0,1,1,3,0},
                {0,0,0,3,3,1}
            };
            int index = -1;
            for(int i = 0; i < status.Length; i++)
            {
                bool find = false;
                for (int j = 0; j < 6; j++)
                {
                    find = false;
                    if(integerData[j] != status[i,j])
                    {
                        find = true;
                    }
                }
                if(find == false)
                {
                    index = i;
                    break;
                }
            }
            if(index == -1)
            {
                Console.WriteLine("違反題意。");
                return;
            }
            for(int i = index; i < 12; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(status[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
