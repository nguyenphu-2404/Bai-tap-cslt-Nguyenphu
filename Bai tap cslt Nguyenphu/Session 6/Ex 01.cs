using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bai_tap_cslt_Nguyenphu.Session_6
{
    internal class Ex_01
    {
        public static void Main5(string[] args)
        {
            
            Console.Write("Nhap so 1");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so 2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so 3");
            int c = int.Parse(Console.ReadLine());
            maxNum( a, b, c);
           /* if (IsPrime(e))
            {
                Console.WriteLine($"{e} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{e} khong phai la so nguyen to.");
            }*/
        }
        public static void maxNum( int a, int b , int c )
        {
            int max = a;
            if ( b > a)
            {
                max = b;
            }
            if ( c > max)
            {
                max = c;
            }
            Console.WriteLine($"So lon nhat la {max}");

        }

        public static void Factorial(int a)
        {
            
            int b = 1;
            for (int i = 1; i <= a; i++)
            {
                b = b * i;
            }
            Console.WriteLine($"Factorial of {a} is {b}");
        }
            
            static bool IsPrime(int e)
            {
                if (e <= 1) return false;
                if (e == 2) return true;
                if (e % 2 == 0) return false;
                for (int i = 3; i <= Math.Sqrt(e); i += 2)
                {
                    if (e % i == 0)
                        return false;
                }

                return true;
            }
        
    }
}
