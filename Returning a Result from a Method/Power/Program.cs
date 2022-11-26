using System;
class Program
{
    static double Power(double n, double p)
    {
        double n1=1;
        for (int i = 1; i <= p; i++)
        {
            n1 *= n;
        }
        return n1;
    }
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        Console.WriteLine(Power(n, p));
    }
}