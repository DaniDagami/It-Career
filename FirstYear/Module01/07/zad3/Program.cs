﻿namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if ((x1 <= x && x <= x2) && (y1 <= y && y <= y2))
                Console.WriteLine("Inside");
            else Console.WriteLine("Ouside");
        }
    }
}