using System;
class Program
{
    static int GetSumOfOddDigits(int num)
    {
        int oddsum = 0;
        while (num > 0)
        {
            int nextnum = num % 10;
            if (nextnum % 2 != 0)
            {
                oddsum+=nextnum;
            }
            num /= 10;
        }
        return oddsum;
    }
    static int GetSumOfEvenDigits(int num)
    {
        int evensum = 0;
        while (num > 0)
        {
            int nextnum = num % 10;
            if (nextnum % 2 == 0)
            {
                evensum += nextnum;
            }
            num /= 10;
        }
        return evensum;
    }
    static int ProductOfEvenAndOdd(int num)
    {
        int result = GetSumOfEvenDigits(num)*GetSumOfOddDigits(num);
        return result;
    }
    static void Main()
    {
        int n = Math.Abs(int.Parse(Console.ReadLine()));
        Console.WriteLine(ProductOfEvenAndOdd(n));
    }
}
