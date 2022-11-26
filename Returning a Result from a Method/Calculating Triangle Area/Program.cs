using System;
class Program
{
    static double Input(double a,double ha)
    {
        return (a * ha / 2);
    }
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double ha = double.Parse(Console.ReadLine());
        double area = Input(a, ha);
        Console.WriteLine(area);
    }
}