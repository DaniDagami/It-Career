namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string currency1 = Console.ReadLine();
            string currency2 = Console.ReadLine();

            double USD = 1.79549;
            double EUR = 1.95583;
            double GBP = 2.53405;

            if (currency1 == "USD")
            {
                value *= USD;
            }
            if (currency1 == "GBP")
            {
                value *= GBP;
            }
            if (currency1 == "EUR")
            {
                value *= EUR;
            }

            if (currency2 == "USD")
            {
                value /= USD;
            }
            if (currency2 == "GBP")
            {
                value /= GBP;
            }
            if (currency2 == "EUR")
            {
                value /= EUR;
            }
            Console.WriteLine(Math.Round(value, 2));
        }
    }
}