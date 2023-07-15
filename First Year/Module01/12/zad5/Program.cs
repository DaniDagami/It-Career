namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int f0 = 1, f1 = 1;
            for (int i = 1; i < n; i++)
            {
                int f = f0 + f1;
                f0 = f1;
                f1 = f;
            }
            Console.WriteLine(f1);
        }
    }
}