int n = int.Parse(Console.ReadLine());
if (n < 1 || n > 1000) return;
double p1 = 0;
double p2 = 0;
double p3 = 0;
for (int i = 0; i < n; i++)
{
    int n1 = int.Parse(Console.ReadLine());
    if (n1%2 == 0) p1 += 1;
    if (n1%3 == 0) p2 += 1;
    if (n1%4 == 0) p3 += 1;
}
Console.WriteLine($"{Math.Round(p1 / n * 100, 2):f2}%");
Console.WriteLine($"{Math.Round(p2 / n * 100, 2):f2}%");
Console.WriteLine($"{Math.Round(p3 / n * 100, 2):f2}%");