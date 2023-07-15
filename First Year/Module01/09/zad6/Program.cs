namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                int min = int.MaxValue;
                for (int i = 1; i <= n; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num < min) min = num;
                }
                Console.WriteLine(min);
            }
        }
    }
}