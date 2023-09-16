namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string catergory = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());

            if (catergory == "Normal")
            {
                if (people >= 1 && people <= 4)
                {
                    double left = budget - budget * 0.75;
                    if (left > 249.99 * people) Console.WriteLine($"Yes You have {left - 249.99 * people:f2} leva left.");
                    else Console.WriteLine($"Not enough money! You need {249.99 * people - left:f2} leva.");
                }
                else if (people >= 5 && people <= 9)
                {
                    double left = budget - budget * 0.6;
                    if (left > 249.99 * people) Console.WriteLine($"Yes You have {left - 249.99 * people:f2} leva left.");
                    else Console.WriteLine($"Not enough money! You need {249.99 * people - left:f2} leva.");
                }
                else if (people >= 10 && people <= 24)
                {
                    double left = budget - budget * 0.5;
                    if (left > 249.99 * people) Console.WriteLine($"Yes You have {left - 249.99 * people:f2} leva left.");
                    else Console.WriteLine($"Not enough money! You need {249.99 * people - left:f2} leva.");
                }
                else if (people >= 25 && people <= 49)
                {
                    double left = budget - budget * 0.4;
                    if (left > 249.99 * people) Console.WriteLine($"Yes You have {left - 249.99 * people:f2} leva left.");
                    else Console.WriteLine($"Not enough money! You need {249.99 * people - left:f2} leva.");
                }
                else if (people > 50)
                {
                    double left = budget - budget * 0.25;
                    if (left > 249.99 * people) Console.WriteLine($"Yes You have {left - 249.99 * people:f2} leva left.");
                    else Console.WriteLine($"Not enough money! You need {249.99 * people - left:f2} leva.");
                }
            }
            else if (catergory == "VIP")
            {
                if (people >= 1 && people <= 4)
                {
                    double left = budget - budget * 0.75;
                    if (left > 499.99 * people) Console.WriteLine($"Yes You have {left - 499.99 * people:f2} leva left.");
                    else Console.WriteLine($"Not enough money! You need {499.99 * people - left:f2} leva.");
                }
                else if (people >= 5 && people <= 9)
                {
                    double left = budget - budget * 0.6;
                    if (left > 499.99 * people) Console.WriteLine($"Yes You have {left - 499.99 * people:f2} leva left.");
                    else Console.WriteLine($"Not enough money! You need {499.99 * people - left:f2} leva.");
                }
                else if (people >= 10 && people <= 24)
                {
                    double left = budget - budget * 0.5;
                    if (left > 499.999 * people) Console.WriteLine($"Yes You have {left - 499.99 * people:f2} leva left.");
                    else Console.WriteLine($"Not enough money! You need {499.99 * people - left:f2} leva.");
                }
                else if (people >= 25 && people <= 49)
                {
                    double left = budget - budget * 0.4;
                    if (left > 499.99 * people) Console.WriteLine($"Yes You have {left - 499.99 * people:f2} leva left.");
                    else Console.WriteLine($"Not enough money! You need {499.99 * people - left:f2} leva.");
                }
                else if (people > 50)
                {
                    double left = budget - budget * 0.25;
                    if (left > 499.99 * people) Console.WriteLine($"Yes You have {left - 499.99 * people:f2} leva left.");
                    else Console.WriteLine($"Not enough money! You need {499.99 * people - left:f2} leva.");
                }
            }
        }
    }
}