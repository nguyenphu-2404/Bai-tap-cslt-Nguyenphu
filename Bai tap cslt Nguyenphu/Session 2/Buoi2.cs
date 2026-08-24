using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Metadata;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

class buoi2
{
    public static void Main1()
    {
        int num1 = 10;
        int num2 = 20;
        //1.to Add / Sum Two Numbers.
        Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2} ");
        //2.to Swap Values of Two Variables.
        Console.WriteLine($"Before swapping num1 is {num1}, num2 is {num2}");
        int num3 = num2;
        num2 = num1;
        num1 = num3;
        Console.WriteLine($"After swapping num1 is {num1}, num2 is {num2}");
        //3.to Multiply two Floating Point Numbers
        float f1 = 2.5f;
        float f2 = 4f;
        Console.WriteLine($"mutiply f1 and f2 equals {f1 * f2}");
        //4.to convert feet to meter
        float feet = 5f;
        float rate = 0.3048f;
        Console.WriteLine($"{feet} feet equals {feet * rate} meter");
        //5.to convert Celsius to Fahrenheit and vice versa
        float C = 0;
        Console.WriteLine($"{C} degree Celcius equals {1.8 * C + 32} Farenheit");
        //6.to find the Size of data types
        Console.WriteLine($"Size of double type = {sizeof(double)} bytes");
        //7.to Print ASCII Value(tip: read character, print number of this char)
        Char ch = 'A';
        int asciivalue = (int)ch;
        Console.WriteLine($"ASCII of {ch} is: {asciivalue}");
        //8.to Calculate Area of Circle
        float r = 4f;
        const float pi = 3.14f;
        Console.WriteLine($"Area of the cirle with {r} is {r * r * pi}");
        //9.to Calculate Area of Square
        float t = 4f;
        Console.WriteLine($"Area of the square with {t} is {t * t}");
        //10.to convert days to years, weeks and days
        int totaldays = 380;
        int years = totaldays / 365;
        int ngaydu = totaldays % 365;
        int weeks = ngaydu / 7;
        int day = ngaydu % 7;
        Console.WriteLine($"{years} year and {weeks} week and {day} days");
    }
}
