namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 1; j <= n - 2; j++) Console.Write('*');
                    Console.Write("\\ /");
                    for (int j = 1; j <= n - 2; j++) Console.Write('*');
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 1; j <= n - 2; j++) Console.Write('-');
                    Console.Write("\\ /");
                    for (int j = 1; j <= n - 2; j++) Console.Write('-');
                    Console.WriteLine();
                }
            }
            for (int k = 1; k <= n - 1; k++) Console.Write(' ');
            Console.WriteLine('@');
            for (int i = 1; i <= n - 2; i++)
            {
                if (i % 2 != 0)
                {
                    for (int j = 1; j <= n - 2; j++) Console.Write('*');
                    Console.Write("/ \\");
                    for (int j = 1; j <= n - 2; j++) Console.Write('*');
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 1; j <= n - 2; j++) Console.Write('-');
                    Console.Write("/ \\");
                    for (int j = 1; j <= n - 2; j++) Console.Write('-');
                    Console.WriteLine();
                }
            }
        }
    }
}