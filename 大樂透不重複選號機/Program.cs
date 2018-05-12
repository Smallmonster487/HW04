using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 大樂透不重複選號機
{
    class Program
    {
        static void Main(string[] args)
        {
            //更改背景和字體的顏色
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;

            //讓使用者輸入要幾組號碼
            Console.Write("請輸入要產生幾組號碼:");
            int total = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //計數器
            int time = 1;

            //設置一個亂數產生器
            Random rand = new Random();

            //產生number的list
            List<int> number = new List<int>();

             //在list中加入1~43的數字
             for (int i = 1; i <= 43; i++)
                {
                    number.Add(i);
                }

            //迴圈判斷需要幾組數字   
            while (time <= total)
            {
                //產生一組不重複的號碼
                for (int i = 1; i <= 6; i++)
                {
                    int Rand = rand.Next(1, number.Count);
                    Console.Write(number[Rand] + " ");
                   
                }
                //為了排版好看~
                Console.WriteLine();
                Console.WriteLine();
                time += 1;
            }
            //結束
            Console.ReadLine();
        }
    }
}
