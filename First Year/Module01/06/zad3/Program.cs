namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int s = a + b + c;
            int m = s / 60;
            s -=  m * 60 ;
            Console.WriteLine($"{m}:{s:d2}");
        }
    }
}