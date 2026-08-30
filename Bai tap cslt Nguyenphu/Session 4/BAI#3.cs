namespace Bai_tap_cslt_Nguyenphu.Session_4;

class BAI3
{
    public static void Main(string[] args)
    {
        Bai1();
        // Bai2();
        // Bai3();
        // Bai4();
    }

    // Write a C# program to check whether a number is even or odd.
    static void Bai1()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
    }

    // Write a C# program to find the largest number among three numbers.
    static void Bai2()
    {
        Console.WriteLine("Enter a:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter b:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter c:");
        int c = int.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine("The largest number is " + a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("The largest number is " + b);
        }
        else
        {
            Console.WriteLine("The largest number is " + c);
        }
    }

    // Write a C# program to check whether a triangle is equilateral, isosceles or scalene.
    static void Bai3()
    {
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

    // Write a C# program to determine which quadrant a point (x, y) lies in.
    static void Bai4()
    {
        Console.WriteLine("Enter x:");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter y:");
        int y = int.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("The point is in Quadrant I.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("The point is in Quadrant II.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("The point is in Quadrant III.");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("The point is in Quadrant IV.");
        }
        else if (x == 0 && y == 0)
        {
            Console.WriteLine("The point is at the origin.");
        }
        else
        {
            Console.WriteLine("The point is on an axis.");
        }
    }
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
}
