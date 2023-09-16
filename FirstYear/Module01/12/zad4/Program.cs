﻿namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0) break;
                    Console.WriteLine("The number is not even.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            Console.WriteLine($"Even number entered: {n}");
        }
    }
}