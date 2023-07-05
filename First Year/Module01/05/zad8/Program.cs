namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            if (n == m && m == k)
                Console.WriteLine("yes");
            else Console.WriteLine("no");
        }
    }
}