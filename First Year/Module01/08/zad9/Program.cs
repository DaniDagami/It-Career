namespace zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            if (month == "May" || month == "Octomber")
            {
                if (nights <= 7)
                {
                    Console.WriteLine($"Apartment: {nights * 65:f2} lv.");
                    Console.WriteLine($"Studio: {nights * 50:f2} lv.");
                }
                if (nights > 7 && nights <= 14)
                {
                    Console.WriteLine($"Apartment: {nights * 65:f2} lv.");
                    Console.WriteLine($"Studio: {nights * 50 * 0.95:f2} lv.");
                }
                if (nights > 14)
                {
                    Console.WriteLine($"Apartment: {nights * 65 * 0.90:f2} lv.");
                    Console.WriteLine($"Studio: {nights * 50 * 0.70:f2} lv.");
                }
            }
            if (month == "June" || month == "September")
            {
                if (nights >= 0 && nights <= 14)
                {
                    Console.WriteLine($"Apartment: {nights * 68.7:f2} lv.");
                    Console.WriteLine($"Studio: {nights * 75.2:f2} lv.");
                }
                if (nights > 14)
                {
                    Console.WriteLine($"Apartment: {nights * 68.7 * 0.90:f2} lv.");
                    Console.WriteLine($"Studio: {nights * 75.2 * 0.80:f2} lv.");
                }
            }
            if (month == "July" || month == "August")
            {
                if (nights > 14)
                {
                    Console.WriteLine($"Apartment: {nights * 77 * 0.9:f2} lv.");
                    Console.WriteLine($"Studio: {nights * 76:f2} lv.");
                }
                else
                {
                    Console.WriteLine($"Apartment: {nights * 77:f2} lv.");
                    Console.WriteLine($"Studio: {nights * 76:f2} lv.");
                }
            }
        }
    }
}