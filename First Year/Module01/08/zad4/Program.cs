namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vineyardArea = int.Parse(Console.ReadLine());
            double grapesPerSqKm = double.Parse(Console.ReadLine());
            int neededLitersWine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            double grapes = vineyardArea * grapesPerSqKm;
            double wine = 0.4 * grapes / 2.5;

            if (wine > neededLitersWine)
            {
                Console.WriteLine($"Good harvest year! Total wine:{Math.Floor(wine)} liters");
                Console.WriteLine($"{Math.Ceiling(wine - neededLitersWine)} liters left -> {Math.Ceiling((wine - neededLitersWine) / workers)} liters per person");
            }
            else
            {

                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededLitersWine - wine)} liters wine needed.");
            }
        }
    }
}