namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            if (n <= 10)
                Console.WriteLine("slow");
            if (10 < n && n <= 50)
                Console.WriteLine("average");
            if (50 < n && n <= 150)
                Console.WriteLine("fast");
            if (150 < n && n <= 1000)
                Console.WriteLine("ultra fast");
            if (1000 < n )
                Console.WriteLine("extremly fast");
        }
    }
}