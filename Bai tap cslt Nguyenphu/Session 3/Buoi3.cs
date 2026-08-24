using System;
namespace cslt_session3
{
    internal class Session3
    {
        public static void Main2(string[] args)
        {
            //▸The Celsius scale is centigrade, 100 divisions separate the freezing point
            //from the boiling point of water. On the Fahrenheit scale of Anglo-Saxons,
            //these two points are 180 degrees apart. The Kelvin scale is an absolute
            //scale used in science.
            //▸Create a C# program to convert from degrees Celsius to Kelvin and
            //Fahrenheit. Request the user the number of degrees celsius to convert
            //them using the following conversion tables:
            //-kelvin = celsius + 273
            //-fahrenheit = celsius x 18 / 10 + 32
            //-Input
            //• 33
            //-Output
            //• kelvin = 306
            //• fahrenheit = 91*/
            Console.Write("Celcius: ");
            int celcius = int.Parse(Console.ReadLine());
            int Kelvin = celcius + 273;
            float Farenheit = celcius * 1.8f + 32f;

            Console.WriteLine($"Kelvin ={Kelvin}");
            Console.WriteLine($"Farenheit ={Farenheit}");

            /*▸Create a program in C# for calculate the surface and volume of a sphere, given its
            radius.
            - surface= 4 * pi * radius squared
            - volume= 4 / 3 * pi * radius cubed
            - Input
            • 60
            - Output
            • Surface: 45238,93
            • Volume: 678584,1
             */

            Console.WriteLine("Enter the R: ");
            double R = double.Parse(Console.ReadLine());
            float pi = 3.14f;
            double S = 4 * R * R * pi;
            double V = 4 / 3 * R * R * R * pi;
            Console.WriteLine($"Surface is {S}");
            Console.WriteLine($"Volume is {V}");
            /* ▸Write a program in C# that calculates the result of adding, subtracting,
            multiplying and dividing two numbers entered by the user.
            -In addition you should also calculate the rest of the division on the last line.
            -Input
            • 12
            • 3
            - Output
            • 12 + 3 = 15
            • 12 - 3 = 9
            • 12 x 3 = 36
            • 12 / 3 = 4
            • 12 mod 3 = 0 */
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int sum = a + b;
            int subtract = a - b;
            int multiply = a * b;
            int divide = a / b;
            int mod = a % b;
            Console.WriteLine($"{a}+{b}={a + b}, {a}-{b}= {a - b}, {a}x{b}={a * b}, {a}/{b}={a / b}, {a} mod {b} = {a % b}");
        }
    }
}
