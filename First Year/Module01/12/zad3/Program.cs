namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool check = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    check = false;
                    break;
                }
            }
            if (check)
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not Prime");

        }
    }
}