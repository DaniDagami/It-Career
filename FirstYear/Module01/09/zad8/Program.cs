namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenSum = 0, oddSum = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                    evenSum += num;
                else
                    oddSum += num;
            }
            if (evenSum == oddSum)
                Console.WriteLine($@"Yes
Sum = {evenSum}");
            else
                Console.WriteLine($@"No
Diff = {Math.Abs(oddSum-evenSum)}");
        }
    }
}