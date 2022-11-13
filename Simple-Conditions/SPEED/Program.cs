var a = double.Parse(Console.ReadLine());
if (a<=10) Console.WriteLine("slow");
else if (a<=50) Console.WriteLine("average");
else if (a<=150) Console.WriteLine("fast");
else if (a<=1000) Console.WriteLine("ultra fast");
else Console.WriteLine("extremly fast");
