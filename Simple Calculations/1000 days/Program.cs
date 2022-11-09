using System.Data;

DateTime d = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
d = d.AddDays(999);
Console.WriteLine(d.ToString("dd-MM-yyyy") );
