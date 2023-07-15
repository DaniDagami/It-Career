namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 7 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}