double a = double.Parse(Console.ReadLine());
double b = 0;
if (a < 100) b = b + 5;
else if (a > 1000) b = b + a * 0.1;
else if (a > 100) b = b + a * 0.2;
if (a % 2 == 0) b = b + 1;
else if (a % 5 == 0 && a%10 != 0) b = b + 2;
Console.WriteLine(b);
Console.WriteLine(a + b);
