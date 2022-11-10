using System.Transactions;

var sum = double.Parse(Console.ReadLine());
string from =Console.ReadLine();
string to = Console.ReadLine();
if (from == "USD") sum = sum *1.79549;
if (from == "EUR") sum = sum*1.95583;
if (from == "GBP") sum = sum * 2.53405;
if (to == "USD") sum = sum/1.79549;
if (to == "EUR") sum = sum/1.95583;
if (to =="GBP") sum = sum/2.53405;
Console.WriteLine(Math.Round(sum, 2) +" "+ to);
