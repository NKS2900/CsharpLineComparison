﻿using System;

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
            double x1= Number.Next(0, 5);
            double x2= Number.Next(0, 5);
            double x3 = Number.Next(0, 5);
            double x4 = Number.Next(0, 5);
            double y1= Number.Next(0, 5);
            double y2= Number.Next(0, 5);
            double y3 = Number.Next(0, 5);
            double y4 = Number.Next(0, 5);
            length1 = (Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1))));
            length2 = (Math.Sqrt(((x4 - x3) * (x4 - x3)) + ((y4 - y3) * (y4 - y3))));
            Console.WriteLine(" 1st Line Length is : " + length1);
            Console.WriteLine(" 2nd Line Length is : " + length2);
            double line1 = length1;
            double line2 = length2;
            if (line1 == line2)
            {
                Console.WriteLine("Both Lines are Equal.");
            }
            else
            {
                int compare = line1.CompareTo(line2);
                if (compare > 0)
                    Console.WriteLine("Line 1 is larger");

                else
                    Console.WriteLine("Line 2 is larger");
            }
        }
    }
}
