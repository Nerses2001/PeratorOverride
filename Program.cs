using System;


namespace PeratorOverride
{
    internal class Program
    {
        static void Main()
        {
            Point point2 = new Point(10, 20);
            Point point1 = new Point(30, 40);

            Point point3 = point1 + point2;
            Point point4 = point1 - point2;
            Point point5 = point1 * point2;
            Point point6 = point1 / point2;
            Point point7 = point1++;
            Point point8 = point1--;
            Point point9 = --point2;
            Point point10 = ++point1;
            Point point11 = new Point(5, 5);
            Point point12 = new Point(5, 5);

            Console.WriteLine(point3);
            Console.WriteLine(point4);
            Console.WriteLine(point5);
            Console.WriteLine(point6);
            Console.WriteLine(point7);
            Console.WriteLine(point8);
            Console.WriteLine(point9);
            Console.WriteLine(point10);
            Console.WriteLine(point11 == point12);
            Console.WriteLine(point11 == point1);
            Console.WriteLine(point11 != point12);
            Console.WriteLine(point11 != point1);
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(point1 < point11);
            Console.WriteLine(point1 > point11);
            Console.WriteLine(point2 > point1);
            Console.WriteLine(point2 < point1);

            byte vDigit = 1;
            Digit digit1 = vDigit;

            Console.ReadKey();
        }
    }
}
