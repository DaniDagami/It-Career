namespace zad10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue, sum =0;
            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sum += a;
                max = a > max ? a : max;
            }
            if (sum - max * 2 == 0)
                Console.WriteLine($"Yes, Sum = {max}");
            else
                Console.WriteLine($"No, Diff = {Math.Abs(sum - max * 2)}");
        }
    }
}