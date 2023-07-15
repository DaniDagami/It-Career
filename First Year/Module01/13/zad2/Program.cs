namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0, p2 = 0, p3 = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0) p1 += 1;
                if (num % 3 == 0) p2 += 1;
                if (num % 4 == 0) p3 += 1;
            }
            Console.WriteLine($"{Math.Round(p1 / n * 100, 2):f2}%");
            Console.WriteLine($"{Math.Round(p2 / n * 100, 2):f2}%");
            Console.WriteLine($"{Math.Round(p3 / n * 100, 2):f2}%");
        }
    }
}