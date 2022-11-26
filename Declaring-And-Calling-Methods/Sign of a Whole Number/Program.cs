using System;
class Sign_of_a_Whole_Number
{
    static void PrintSign(int n)
    {
        if (n > 0) Console.WriteLine($"The number {n} is positive.");
        else if (n < 0) Console.WriteLine($"The number {n} is negative.");
        else if (n == 0) Console.WriteLine($"The number {n} is zero.");
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintSign(n);
        
    }
}