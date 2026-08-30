using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;

namespace Bai_tap_cslt_Nguyenphu.Session_4
{
    internal class Buoi4
    {
        public static void Main1(string[] args)
        {


            static void Bai1()
            //Write a C# Sharp program that takes two numbers as input and
            // performs an operation(+,-,*, x,/) on them and displays the result of that
            // operation.
            {
                Console.WriteLine("Nhap so a");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so b");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a}+{b}={a + b}");
                Console.WriteLine($"{a}-{b}={a - b}");
                Console.WriteLine($"{a}*{b}={a * b}");
                Console.WriteLine($"{a}/{b}={a / b}");
                Console.WriteLine($"{a}%{b}={a % b}");

            }
            static void Bai2()
            //Write a C# Sharp program to display certain values of the function x = y2
            // + 2y + 1 (using integer numbers for y, ranging from -5 to +5)
            {
                for (int y = -5; y <= 5; y++)
                {
                    int x = y * y + 2 * y + 1;
                    Console.WriteLine($"Bieu thuc x= y2+2y+1 voi y= {y} la {x}");
                }
            }
            static void Bai3()
            //Write a C# Sharp program that takes distance and time (hours, minutes,
            //seconds) as input and displays speed in kilometers per hour(km / h) and
            //miles per hour(miles/h).
            {
                Console.WriteLine("Input distance in kilometers");
                float distance = float.Parse(Console.ReadLine());
                Console.WriteLine("Input hours");
                float hours = float.Parse(Console.ReadLine());
                Console.WriteLine("Input minutes");
                float minutes = float.Parse(Console.ReadLine());
                Console.WriteLine("Input seconds");
                float seconds = float.Parse(Console.ReadLine());
                float time = hours + minutes / 60 + seconds / 3600;
                float kmh = distance / time;
                float miles = distance * 0.62f;
                float mph = miles / time;
                Console.WriteLine($"{kmh}kmh, {mph}mph");
            }
            static void Bai4() { }
            static void GiaiPT()
            { 
                    Console.WriteLine("Nhap so a");
                    float a = float.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap so b");
                    float b = float.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap so c");
                    float c = float.Parse(Console.ReadLine());
                    if (a == 0)
                    {
                        if (b == 0)
                        {
                            if (c == 0)
                            {
                                Console.WriteLine("vo so nghiem");
                            }
                            else
                            {
                                Console.WriteLine("vo nghiem");
                            }
                        }
                        else
                        {
                            float x = -c / b;
                            Console.WriteLine($"Nghiem la x = {x}");
                        }
                    }
                    else
                    {
                        float delta = (float)Math.Pow(b, 2) - 4 * a * c;
                        if (delta < 0)
                        {
                            Console.WriteLine("Phuong trinh vo nghiem");
                        }
                        else if (delta == 0)
                        {
                            Console.WriteLine($"Phuong trinh co nghiem kep x={-b / 2 * a}");
                        }
                        else
                        {
                            float Squrt = (float)Math.Sqrt(delta);
                            Console.WriteLine($"Phuong trinh co 2 nghiem");
                            Console.WriteLine($"x1= {-(b + Squrt) / 2 * a}, {-(b + Squrt) / 2 * a}");
                        }
                    }
            }
            GiaiPT();
        }
    }
}
