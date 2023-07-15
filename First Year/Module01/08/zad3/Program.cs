namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rest_Days = int.Parse(Console.ReadLine());
            int work_Days = 365 - rest_Days;
            int playtime = work_Days * 63 + rest_Days * 127;
            if (playtime < 30000)
            {
                int difference = 30000 - playtime;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{difference / 60} hours and {difference % 60} minutes less for play");
            }
            else
            {
                int razlika = playtime - 30000;
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{razlika / 60} hours and {razlika % 60} minutes more for play");

            }
        }
    }
}