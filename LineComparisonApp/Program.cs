using System;

namespace LineComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************Welcome To Line Comparison*******");
            double length1;
            double length2;
            Random Number = new Random();
            double x1= Number.Next(0, 3);
            double x2= Number.Next(0, 3);
            double x3 = Number.Next(0, 3);
            double x4 = Number.Next(0, 3);
            double y1= Number.Next(0, 3);
            double y2= Number.Next(0, 3);
            double y3 = Number.Next(0, 3);
            double y4 = Number.Next(0, 3);
            length1 = (Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1))));
            length2 = (Math.Sqrt(((x4 - x3) * (x4 - x3)) + ((y4 - y3) * (y4 - y3))));
            Console.WriteLine(" 1st Line Length is : " + length1);
            Console.WriteLine(" 2nd Line Length is : " + length2);
            if (length1 == length2)
            {
                Console.WriteLine("Lines are Equal");
            }
            else
            {
                Console.WriteLine("Line is Not Equal");
            }
        }
    }
}
