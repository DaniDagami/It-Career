using System;
class Program
{
    static void PrintHeaderFooter(int n)
    {
        for (int i = 1; i <= 2 * n; i++) Console.Write('-');
        Console.WriteLine();
    }
    static void PrintBody(int n)
    {
        for (int i = 1; i <= n-2 ; i++)
        {
            Console.Write('-');
            for (int j = 1; j <= n - 1; j++) Console.Write("\\/");
            Console.Write('-');
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintHeaderFooter(n);
        PrintBody(n);
        PrintHeaderFooter(n);
    }
}