string month = Console.ReadLine();
int n = int.Parse(Console.ReadLine());
if (n >= 0 && n <= 200) { } else { Console.WriteLine("Error"); return; }
if (month == "May" || month == "Octomber")
{
    if (n <= 7)
    {
        Console.WriteLine($"Apartment: {n * 65:f2} lv.");
        Console.WriteLine($"Studio: {n * 50:f2} lv.");
    }
    else if (n > 7 && n <= 14)
    {
        Console.WriteLine($"Apartment: {n * 65:f2} lv.");
        Console.WriteLine($"Studio: {n * 50 * 0.95:f2} lv.");
    }
    else if (n > 14)
    {
        Console.WriteLine($"Apartment: {n * 65 * 0.90:f2} lv.");
        Console.WriteLine($"Studio: {n * 50 * 0.70:f2} lv.");
    }
}
else if (month == "June" || month == "September")
{
    if (n >= 0 && n <= 14)
    {
        Console.WriteLine($"Apartment: {n * 68.7:f2} lv.");
        Console.WriteLine($"Studio: {n * 75.2:f2} lv.");
    }
    else if (n > 14)
    {
        Console.WriteLine($"Apartment: {n * 68.7 * 0.90:f2} lv.");
        Console.WriteLine($"Studio: {n * 75.2*0.80:f2} lv."); 
    }
}
else if (month == "July" || month == "August")
{
    if (n > 14)
    {
        Console.WriteLine($"Apartment: {n * 77*0.9:f2} lv.");
        Console.WriteLine($"Studio: {n * 76:f2} lv.");
    }
    else
    {
        Console.WriteLine($"Apartment: {n * 77:f2} lv.");
        Console.WriteLine($"Studio: {n * 76:f2} lv.");
    }
}