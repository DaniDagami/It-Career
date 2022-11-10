var w = double.Parse(Console.ReadLine());
var h = double.Parse(Console.ReadLine());
h = h * 100;
w = w * 100;
var rows = Math.Truncate((h - 100) / 70);
var cols = Math.Truncate(w / 120);
var seats = rows * cols - 3;
Console.WriteLine(seats);
