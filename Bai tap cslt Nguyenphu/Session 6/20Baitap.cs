using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
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
            /*Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"Day Fibonacci la: ");
            InFibonacci(n);*/
            /*Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();
            Console.Write($"Chuoi co {DemNguyenAm(s)} nguyen am");*/
            /*Console.Write("Nhap so x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Nhap so y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write($"Ket qua x mu y la {Tinhluythua(x, y)}");*/
            /*Console.Write("Nhap so luong phan tu: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write($"Trung binh la {Tinhtrungbinh(arr)}  ");*/
            /*Console.Write("Nhap chuoi de kiem tra: ");
            string s = Console.ReadLine();
            if(KiemTraDoiXung(s) == true)
            {
                Console.Write("True");
            }
            if (KiemTraDoiXung(s) == false)
            {
                Console.Write(false);
            }*/
            /*Console.Write("Nhiet do theo do C la: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write($"Nhiet do theo do F {CelciusToFarenheit(c)} F ");*/
            /*int[] arr = { 9, 8, 7, 6, 2, 50, 1, 3 };
            Console.Write($"Min cua mang la {TimMin(arr)}");*/
            /*Console.Write("Nhap so: ");
            int n= int.Parse(Console.ReadLine());
            Console.Write($"Tong cua cac so la: {TongCacChuSo(n)}");*/
            /*int[] arr = { 1, 2, 5, 8, 7, 6 };
            SapXepMang(arr);*/
            /*Console.Write("Nhap chuoi: ");
            string s= Console.ReadLine();
            Console.Write($"Chuoi khong trung lap la: {XoaTrungLap(s)}");*/
            Console.Write("Nhap a: ");
            int a = int.Parse



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
        public static int DemNguyenAm(string s)
        {
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        count++;
                        break;
                }
            }
            return count;
        }
        public static double Tinhluythua(double x, int y)
        {
            double result = 1;
            for(int i = 1; i <= y;  i++)
            {
                result = result * x;
            }
            return(result);

        }
        public static double Tinhtrungbinh(int[] arr)
        {
            double sum = 0;
            int soluong = arr.Length;
            for (int i = 0;i < arr.Length;i++)
            {
                sum += arr[i];
            }
            return (sum / soluong );
        }
        public static bool KiemTraDoiXung(string s)
        {
            if (s == DaoNguocChuoi(s))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double CelciusToFarenheit(double c)
        {
            double conver = 1.8 * c + 32;
            return (conver);

        }
        public static int TimMin(int[]arr)
        {
            int min = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] < min)
                {
                    min=arr[i];
                }
                else
                {
                    min = min;
                }
            }
            return (min);
        }
        
        public static int TongCacChuSo(int n)
        { 
            string chuoi = n.ToString();
            char[] tachchuoi = chuoi.ToCharArray();
            int sum = 0;
            for(int i = 0; i < tachchuoi.Length; i++)
            {
                sum += tachchuoi[i] - '0';
            }
            return(sum);
        }
        public static void SapXepMang(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            
        }
        public static string XoaTrungLap(string s)
        {
            string chuoitam = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (!chuoitam.Contains(s[i]))
                {
                    chuoitam += s[i];
                }
            }
            return(chuoitam);
        }
        public static int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }

}
