using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_tap_cslt_Nguyenphu.Session_5
{
    internal class Ex01
    {
        public static void Main5(string[] args)
        {
            bangcuuchuong();
        }
        static void bangcuuchuong()
        {
            for (int i= 1; i <= 9; i++)
            {
                for(int j=1; j <= 10; j++)
                {
                    Console.WriteLine($"{i}x{j}={i*j}");
                }
                Console.WriteLine();
                
            }
        }
    }
}
