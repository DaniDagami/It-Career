var PriceVeg = double.Parse(Console.ReadLine());
var PriceFruit = double.Parse(Console.ReadLine());
var kgVeg = double.Parse(Console.ReadLine());
var kgFruit= double.Parse(Console.ReadLine());
Console.WriteLine(Math.Round((PriceVeg*kgVeg+PriceFruit*kgFruit)/1.94, 2));
