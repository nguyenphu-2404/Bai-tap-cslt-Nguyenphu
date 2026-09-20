using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_tap_cslt_Nguyenphu.Session_6
{
    internal class _20Baitap
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine($"{intTinhTong(5, 6)}");
            /* Console.Write("Nhap so");
             int c = int.Parse(Console.ReadLine());
             if (kiemtrachan(c) == true)
             { Console.WriteLine($"{c} la so chan");

             }
             else
             {
                 Console.WriteLine($"{c} la so le");
             }*/

            /* Console.Write("Nhap so dau tien");
             int a = int.Parse(Console.ReadLine());
             Console.Write("Nhap so thu hai");
             int b = int.Parse(Console.ReadLine());
             Console.Write("Nhap so thu ba");
             int c = int.Parse(Console.ReadLine());
             Console.Write($"So lon nhat la {(TimMax(a, b, c))}"); */
            /* Console.WriteLine("Nhap so");
            int n = int.Parse(Console.ReadLine()); 
             Console.WriteLine($"Giai thua cua {n} la {TinhGiaithua( n)} ");*/
            /*Console.Write("Insert chuoi: ");
            string input = Console.ReadLine();
            Console.Write($"Chuoi moi la {DaoNguocChuoi(input)}");*/
            /*Console.Write("Nhap so: ");
            int e = int.Parse(Console.ReadLine());
            if (IsPrime(e))
            {
                Console.WriteLine($"{e} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{e} khong phai la so nguyen to.");
            }*/
            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"Day Fibonacci la: ");
            InFibonacci(n);
        }
        public static int intTinhTong(int a, int b)
        {
            return a + b;
        }
        public static bool kiemtrachan(int c)
        {
            if (c % 2 == 0) return true;
            else return false;
        }
        public static int TimMax(int a, int b, int c)
        {
            int max = a;
            if (b > a)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            return max;
        }
        public static long TinhGiaithua(int n)
        {

            int giaithua = 1;
            for (int i = 1; i <= n; i++)
            {
                giaithua = giaithua * i;
            }
            return giaithua;    

        }

        public static string DaoNguocChuoi(string input)
        {
            char[] tenmang = input.ToCharArray();
            Array.Reverse(tenmang);
            string chuoimoi = new string(tenmang);
            return( chuoimoi);
        }
        public static bool IsPrime(int e)
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
        public static void InFibonacci(int n)
        {
            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");

                int next = a + b;
                a = b;
                b = next;
            }
            
        }



    }
}
