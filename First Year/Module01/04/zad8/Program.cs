namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceVegetables = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            int kgVegetables = int.Parse(Console.ReadLine());
            int kgFruits = int.Parse(Console.ReadLine());

            double cost = (priceFruits * kgFruits + priceVegetables * kgVegetables) / 1.94;
            Console.WriteLine($"{cost:f2}");
        }
    }
}