int n = int.Parse(Console.ReadLine());
if (n < 1 || n > 1000) return;
double p1 = 0;
double p2 = 0;
double p3 = 0;
double p4 = 0;
double p5 = 0;
for (int i = 0; i < n; i++)
{
    int n1 = int.Parse(Console.ReadLine());
    if (n1 < 200) p1 += 1;
    else if (n1 >= 200 && n1 <= 399) p2 += 1;
    else if (n1 >= 400 && n1 <= 599) p3 += 1;
    else if (n1 >= 600 && n1 <= 799) p4 += 1;
    else if (n1 >= 800) p5 += 1;
}
Console.WriteLine($"{Math.Round(p1 / n * 100, 2):f2}%");
Console.WriteLine($"{Math.Round(p2 / n * 100, 2):f2}%");
Console.WriteLine($"{Math.Round(p3 / n * 100, 2):f2}%");
Console.WriteLine($"{Math.Round(p4 / n * 100, 2):f2}%");
Console.WriteLine($"{Math.Round(p5 / n * 100, 2):f2}%");
