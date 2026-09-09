using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Bai_tap_cslt_Nguyenphu.Session_5
{
    internal class Ex02
    {
        public static void Main(string[] args)
        {
            Bai7();
        }
        static void Bai1()
        {
            // Write a C# program to check whether a triangle is equilateral, isosceles or scalene.
            Console.WriteLine("Enter side a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter side b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter side c:");
            int c = int.Parse(Console.ReadLine());

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("These sides cannot form a triangle.");
            }
            else if (a == b && b == c)
            {
                Console.WriteLine("Equilateral triangle");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("Isosceles triangle");
            }
            else
            {
                Console.WriteLine("Scalene triangle");
            }
            
       
        }
        static void Bai2()
        {
            // Write a program to read 10 numbers and find their average and sum.
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                
                Console.WriteLine($"Dien so thu {i}");
                int b = int.Parse(Console.ReadLine());
                sum = sum + b;
            }
            Console.WriteLine($"Tong 10 so la {sum}");
            Console.WriteLine($"Average la {sum / 10}");
        }
        
        static void Bai3()
        {
            //Write a program to display the multiplication table of a given integer
            Console.Write("Nhap so nguyen");
            int a=int.Parse(Console.ReadLine());
            for (int i = 1;i <= 10;i++)
            {
                Console.WriteLine($"{a}x{i}={a * i}");

            }
        }
        static void Bai4()
        {
            //Write a program to display a pattern like triangles with a number.
            Console.WriteLine("Chon kieu tam giac (1-3)");
            int b=int.Parse(Console.ReadLine());
            if (b == 1)
            {
                Console.Write("Nhap chieu cao tam giac: ");
                int a = int.Parse(Console.ReadLine());
                for (int i = 1; i <= a; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write($"{j}");
                    }
                    Console.WriteLine();
                }
            }
            else if (b == 2)
            {
                int counter = 1;
                Console.Write("Nhap chieu cao tam giac: ");
                int a = int.Parse(Console.ReadLine());
                for (int i = 1; i <= a; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(counter + " ");
                        counter++;
                    }
                    Console.WriteLine();
                }
            }
            else if (b == 3)
            {
                Console.Write("Nhap chieu cao tam giac: ");
                int a=int.Parse(Console.ReadLine());
                int count = 1;
                for(int i = 1; i<=a; i++)
                {
                    for (int space = 1; space <= a-i; space++)
                    {
                        Console.Write(" ");
                    }
                    for (int j =1; j<=i; j++)
                    {
                        Console.Write(count + " ");
                        count++;
                    }
                    Console.WriteLine();
                }   
            }


        }
        static void Bai5()
        {
            //Write a program to display the n terms of harmonic series and their
            //sum. 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5... 1 / n terms
            Console.Write("Nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
                Console.Write($"1/{i}");
                if (i < n)
                    Console.Write(" + ");
            }
            Console.WriteLine($" = {sum}");
            
        }
        static void Bai6()
        {
            //Write a program to find the ‘perfect’ numbers within a given number
            //range.
            Console.Write("Nhap range tren");
            int b=int.Parse(Console.ReadLine());
            Console.Write("Nhap range duoi");
            int a = int.Parse(Console.ReadLine());
            Console.Write($"Cac so hoan hao trong khoang {a} va {b} la ");
            for (int i = a; i<=b; i++)
            {
                int sum = 0;
                for (int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    
                        sum += j;
                    
                }
                if (sum == i && i > 0)
                
                    Console.Write($"{i} ");
                
                
                
            }
            Console.WriteLine();


        }
        static void Bai7()
        {
            //Write a program to determine whether a given number is prime or not.
            Console.Write("Nhap mot so: ");
            int.TryParse(Console.ReadLine(), out int number);
             if (IsPrime(number))
             {
                Console.WriteLine($"{number} la so nguyen to.");
             }
             else
             {
                Console.WriteLine($"{number} khong phai la so nguyen to.");
             }
            static bool IsPrime(int n)
            {
                if (n <= 1) return false;
                if (n == 2) return true;
                if (n % 2 == 0) return false; 
                for (int i = 3; i <= Math.Sqrt(n); i += 2)
                {
                    if (n % i == 0)
                        return false;
                }

                return true;
            }
        }
    }

    

}
