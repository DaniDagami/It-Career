namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("+");
            for (int i = 1; i <= n - 2; i++) Console.Write(" -");
            Console.WriteLine(" +");
            for (int j = 1; j <= n - 2; j++)
            {
                Console.Write("|");
                for (int i = 1; i <= n - 2; i++) Console.Write(" -");
                Console.WriteLine(" |");
            }
            Console.Write("+");
            for (int i = 1; i <= n - 2; i++) Console.Write(" -");
            Console.WriteLine(" +");
        }
    }
}