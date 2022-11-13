var a = double.Parse(Console.ReadLine());
if (a > 150 && a < 1000) Console.WriteLine("ultra fast");
else if (a > 50 && a < 150) Console.WriteLine("fast");
else if (a > 10 && a < 50) Console.WriteLine("avarage");
else if (a < 10) Console.WriteLine("slow");
else Console.WriteLine("extremly fast");