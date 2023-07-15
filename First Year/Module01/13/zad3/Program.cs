namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write('/');
            for (int i = 1; i <= n / 2; i++) Console.Write('^');
            Console.Write('\\');
            for (int i = 1; i <= 2 * n - 4 - n / 2 * 2; i++) Console.Write('_');
            Console.Write('/');
            for (int i = 1; i <= n / 2; i++) Console.Write('^');
            Console.Write('\\');
            Console.WriteLine();
            for (int i = 1; i <= n - 3; i++)
            {
                Console.Write('|');
                for (int j = 1; j <= 2 * n - 2; j++) Console.Write(' ');
                Console.Write('|');
                Console.WriteLine();
            }
            Console.Write('|');
            for (int i = 1; i <= n / 2 + 1; i++) Console.Write(' ');
            for (int i = 1; i <= 2 * n - 4 - n / 2 * 2; i++) Console.Write('_');
            for (int i = 1; i <= n / 2 + 1; i++) Console.Write(' ');
            Console.Write('|');
            Console.WriteLine();
            Console.Write('\\');
            for (int i = 1; i <= n / 2; i++) Console.Write('_');
            Console.Write('/');
            for (int i = 1; i <= 2 * n - 4 - n / 2 * 2; i++) Console.Write(' ');
            Console.Write('\\');
            for (int i = 1; i <= n / 2; i++) Console.Write('_');
            Console.Write('/');
            Console.WriteLine();
        }
    }
}