namespace zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;
            if (n % 2 == 0) stars++;
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                int pad = (n - stars) / 2;
                for (int j = 1; j <= pad; j++) Console.Write('-');
                for (int j = 1; j <= stars; j++) Console.Write('*');
                for (int j = 1; j <= pad; j++) Console.Write('-');
                stars += 2;
                Console.WriteLine();
            }
            for (int i = 1; i <= n / 2; i++)
            {
                Console.Write('|');
                for (int j = 1; j <= n - 2; j++) Console.Write('*');
                Console.WriteLine('|');
            }
        }
    }
}