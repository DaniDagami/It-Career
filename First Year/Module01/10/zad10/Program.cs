namespace zad10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftRight = (n - 1) / 2;
            for (int i = 1; i <= (n - 1) / 2; i++)
            {
                Console.Write(new String('-', leftRight));
                Console.Write('*');
                int mid = n - 2 * leftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new String('-', mid));
                    Console.Write('*');
                }
                Console.WriteLine(new String('-', leftRight));
                leftRight--;
            }
            for (int i = 1; i <= (n + 1) / 2; i++)
            {
                Console.Write(new String('-', leftRight));
                Console.Write('*');
                int mid = n - 2 * leftRight - 2;
                if (mid >= 0)
                {
                    Console.Write(new String('-', mid));
                    Console.Write('*');
                }
                Console.WriteLine(new String('-', leftRight));
                leftRight++;
            }
        }
    }
}