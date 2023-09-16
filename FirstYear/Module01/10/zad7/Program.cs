namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                    Console.Write(' ');
                for (int k = n; k > n - i; k--)
                    Console.Write('*');
                Console.Write(" | ");
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }

        }
    }
}