var N = double.Parse(Console.ReadLine());
var W = double.Parse(Console.ReadLine());
var L = double.Parse(Console.ReadLine());
var M = double.Parse(Console.ReadLine());
var O = double.Parse(Console.ReadLine());
var Area = (N * N - M * O) / (W * L);
Console.WriteLine(Math.Round(Area, 2));
Console.WriteLine(Math.Round(Area * 0.2, 2));
