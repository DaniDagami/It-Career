﻿namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
                Console.WriteLine("one");
            else if (n == 2)
                Console.WriteLine("two");
            else if (n == 3)
                Console.WriteLine("three");
            else if (n == 4)
                Console.WriteLine("four");
            else if (n == 5)
                Console.WriteLine("five");
            else if (n == 6)
                Console.WriteLine("six");
            else if (n == 7)
                Console.WriteLine("seven");
            else if (n == 8)
                Console.WriteLine("eight");
            else if (n == 9)
                Console.WriteLine("nine");
            else if (n > 9)
                Console.WriteLine("number too big");
        }
    }
}