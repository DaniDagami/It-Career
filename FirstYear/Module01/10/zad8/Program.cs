namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 2 * n; i++) Console.Write('*');
            for (int i = 1; i <= n; i++) Console.Write(' ');
            for (int i = 1; i <= 2 * n; i++) Console.Write('*');
            Console.WriteLine();
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write('*');
                for (int k = 1; k <= 2 * n - 2; k++) Console.Write('/');
                Console.Write('*');
                if (i == (n - 1) / 2) for (int j = 1; j <= n; j++) Console.Write('|');
                else for (int j = 1; j <= n; j++) Console.Write(' ');
                Console.Write('*');
                for (int h = 1; h <= 2 * n - 2; h++) Console.Write('/');
                Console.Write('*');
                Console.WriteLine();
            }
            for (int i = 1; i <= 2 * n; i++) Console.Write('*');
            for (int i = 1; i <= n; i++) Console.Write(' ');
            for (int i = 1; i <= 2 * n; i++) Console.Write('*');
        }
    }
}