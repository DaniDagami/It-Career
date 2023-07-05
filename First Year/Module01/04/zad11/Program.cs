namespace zad11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int workDays = int.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            double dollar = double.Parse(Console.ReadLine());

            double a = workDays * money;
            double b = a*12 + a*2.5;
            double clean = (b - b * 0.25) * dollar;
            Console.WriteLine($"{clean / 365:f2}");

        }
    }
}