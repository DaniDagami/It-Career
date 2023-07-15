namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("*");
                for (int j = 1; j < n; j++)
                    Console.Write(" *");
                Console.WriteLine();
            }
        }
    }
}