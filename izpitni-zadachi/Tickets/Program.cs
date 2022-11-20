double budget = double.Parse(Console.ReadLine());
if (budget >= 1000 && budget <= 1000000) { } else { Console.WriteLine("Error"); return; }
string cat = Console.ReadLine();
int p = int.Parse(Console.ReadLine());
if (p >= 1 && p <= 200) { } else { Console.WriteLine("Error"); return; }
if (cat == "Normal")
{
    if (p >= 1 && p <= 4)
    {
        double ostava = budget - budget * 0.75;
        if (ostava > 249.99*p) Console.WriteLine($"Yes You have {ostava - 249.99*p:f2} leva left.");
        else Console.WriteLine($"Not enough money! You need {249.99 * p-ostava:f2} leva.");
    }
    else if (p >= 5 && p <= 9)
    {
        double ostava = budget - budget * 0.6;
        if (ostava > 249.99 * p) Console.WriteLine($"Yes You have {ostava - 249.99 * p:f2} leva left.");
        else Console.WriteLine($"Not enough money! You need {249.99 * p - ostava:f2} leva.");
    }
    else if (p >= 10 && p <= 24)
    {
        double ostava = budget - budget * 0.5;
        if (ostava > 249.99 * p) Console.WriteLine($"Yes You have {ostava - 249.99 * p:f2} leva left.");
        else Console.WriteLine($"Not enough money! You need {249.99 * p - ostava:f2} leva.");
    }
    else if (p >= 25 && p <= 49)
    {
        double ostava = budget - budget * 0.4;
        if (ostava > 249.99 * p) Console.WriteLine($"Yes You have {ostava - 249.99 * p:f2} leva left.");
        else Console.WriteLine($"Not enough money! You need {249.99 * p - ostava:f2} leva.");
    }
    else if (p > 50)
    {
        double ostava = budget - budget * 0.25;
        if (ostava > 249.99 * p) Console.WriteLine($"Yes You have {ostava - 249.99 * p:f2} leva left.");
        else Console.WriteLine($"Not enough money! You need {249.99 * p - ostava:f2} leva.");
    }
}
else if (cat == "VIP")
{
    if (p >= 1 && p <= 4)
    {
        double ostava = budget - budget * 0.75;
        if (ostava > 499.99 * p) Console.WriteLine($"Yes You have {ostava - 499.99 * p:f2} leva left.");
        else Console.WriteLine($"Not enough money! You need {499.99 * p - ostava:f2} leva.");
    }
    else if (p >= 5 && p <= 9)
    {
        double ostava = budget - budget * 0.6;
        if (ostava > 499.99 * p) Console.WriteLine($"Yes You have {ostava - 499.99 * p:f2} leva left.");
        else Console.WriteLine($"Not enough money! You need {499.99 * p - ostava:f2} leva.");
    }
    else if (p >= 10 && p <= 24)
    {
        double ostava = budget - budget * 0.5;
        if (ostava > 499.999 * p) Console.WriteLine($"Yes You have {ostava - 499.99 * p:f2} leva left.");
        else Console.WriteLine($"Not enough money! You need {499.99 * p - ostava:f2} leva.");
    }
    else if (p >= 25 && p <= 49)
    {
        double ostava = budget - budget * 0.4;
        if (ostava > 499.99 * p) Console.WriteLine($"Yes You have {ostava - 499.99 * p:f2} leva left.");
        else Console.WriteLine($"Not enough money! You need {499.99 * p - ostava:f2} leva.");
    }
    else if (p > 50)
    {
        double ostava = budget - budget * 0.25;
        if (ostava > 499.99 * p) Console.WriteLine($"Yes You have {ostava - 499.99 * p:f2} leva left.");
        else Console.WriteLine($"Not enough money! You need {499.99 * p - ostava:f2} leva.");
    }
}