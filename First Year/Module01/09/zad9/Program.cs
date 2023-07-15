namespace zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue, min = int.MaxValue, sum = 0;
            bool check = true;

            for (int i = 1; i <= n; i++)
            {
                int c = int.Parse(Console.ReadLine());
                int d = int.Parse(Console.ReadLine());
                check = sum == c + d ? true : false;
                sum = c + d;
                max = sum > max ? sum : max;
                min = sum < min ? sum : min;
            }

            if (check)
                Console.WriteLine($"Yes, value = {sum}");
            else
                Console.WriteLine($"No, maxdiff = {Math.Abs(max - min)}");
        }
    }
}