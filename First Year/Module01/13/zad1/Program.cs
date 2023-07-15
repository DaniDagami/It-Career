namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0, p2 = 0, p3 = 0, p4 = 0, p5 = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());    
                if (num < 200) p1 += 1;
                if (num >= 200 && num <= 399) p2 += 1;
                if (num >= 400 && num <= 599) p3 += 1;
                if (num >= 600 && num <= 799) p4 += 1;
                if (num >= 800) p5 += 1;
            }
            Console.WriteLine($"{Math.Round(p1 / n * 100, 2):f2}%");
            Console.WriteLine($"{Math.Round(p2 / n * 100, 2):f2}%");
            Console.WriteLine($"{Math.Round(p3 / n * 100, 2):f2}%");
            Console.WriteLine($"{Math.Round(p4 / n * 100, 2):f2}%");
            Console.WriteLine($"{Math.Round(p5 / n * 100, 2):f2}%");
        }
    }
}