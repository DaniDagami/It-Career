Console.WriteLine("Enter seconds:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int total = a + b + c;
Console.WriteLine($"{total/60:d}:{total%60:d2}");     // stava i Console.WriteLine("{0:d}:{1:d2}", total/60, total%60)