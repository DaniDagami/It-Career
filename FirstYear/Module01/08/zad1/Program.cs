namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            if (n < 20)
            {
                if (time == "day") Console.WriteLine($"{0.7 + n * 0.79:f2}");
                else if (time == "night") Console.WriteLine($"{0.7 + n * 0.9:f2}");
            }
            if (n >= 20 && n < 100)
                Console.WriteLine($"{0.09 * n:f2}");
            if (n >= 100)
                Console.WriteLine($"{n * 0.06:f2}");
        }
    }
}