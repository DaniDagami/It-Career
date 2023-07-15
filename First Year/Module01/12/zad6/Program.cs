namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(a + " ");
                    a++;
                    if (a > n) return;
                }
                Console.WriteLine();
            }
        }
    }
}