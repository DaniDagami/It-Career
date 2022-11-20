int x = int.Parse(Console.ReadLine());
if (x < 10 || x > 5000) Console.WriteLine("Error");
double y = double.Parse(Console.ReadLine());
if (y < 0 || y > 10) Console.WriteLine("Error"); 
int z = int.Parse(Console.ReadLine());
if (z < 10 || z > 600) Console.WriteLine("Error"); 
int robi = int.Parse(Console.ReadLine());
if (robi < 1 || robi > 20) Console.WriteLine("Error");
double grapes = x * y;
double wine = 0.4 * grapes / 2.5;
if (wine > z)
{
    Console.WriteLine($"Good harvest year! Total wine:{Math.Floor(wine)} liters");
    Console.WriteLine($"{Math.Ceiling(wine - z)} liters left -> {Math.Ceiling((wine - z) / robi)} liters per person");
}
else
{

    Console.WriteLine($"It will be a tough winter! More {Math.Floor(z - wine)} liters wine needed.");
}
