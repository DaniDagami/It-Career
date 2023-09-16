namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            m += 15;
            if (m >= 60)
            {
                m -= 60;
                h++;
                if (h == 24)
                {
                    h = 0;
                }
            }
            Console.WriteLine($"{h:d1}:{m:d2}");
        }
    }
}