namespace zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double O = double.Parse(Console.ReadLine());

            double neededTiles = (N * N - M * O) / (W * L);
            double neededTime = neededTiles * 0.2;
            Console.WriteLine($"{neededTiles:f2}");
            Console.WriteLine($"{neededTime:f2}");
        }
    }
}