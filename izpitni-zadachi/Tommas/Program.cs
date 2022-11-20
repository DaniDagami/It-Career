int pochd = int.Parse(Console.ReadLine());
if (pochd >= 1 && pochd <= 365)
{
    int rabd = 365 - pochd;
    int playtime = rabd * 63 + pochd * 127;
    if (playtime < 30000)
    {
        int razlika = 30000 - playtime;
        Console.WriteLine("Tom sleeps well");
        Console.WriteLine($"{razlika / 60} hours and {razlika % 60} minutes less for play");
    }
    else
    {
        int razlika = playtime - 30000;
        Console.WriteLine("Tom will run away");
        Console.WriteLine($"{razlika / 60} hours and {razlika % 60} minutes more for play");

    }
}
else Console.WriteLine("Error");