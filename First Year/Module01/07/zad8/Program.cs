﻿namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "dog") Console.WriteLine("mammal");
            else if (type == "crocodile" || type == "tortoise" || type == "snake")
                Console.WriteLine("reptile");
            else Console.WriteLine("Unknown");
        }
    }
}