var workdays = int.Parse(Console.ReadLine());
var money = double.Parse(Console.ReadLine());
var dollarkurs= double.Parse(Console.ReadLine());
var monthly = workdays * money;
var yearly = monthly * 12 + monthly * 2.5;
var danuk = yearly * 0.25;
var cleanyearly = (yearly-danuk)*dollarkurs;
Console.WriteLine(Math.Round(cleanyearly / 365, 2));
