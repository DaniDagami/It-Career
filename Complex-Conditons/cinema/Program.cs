string type = Console.ReadLine();
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());

if (type=="Premiere")
{
    double result = row*column*12;
    Console.WriteLine($"{result:f2} leva");
}
else if (type=="Normal")
{
    double result = row*column*7.5;
    Console.WriteLine($"{result:f2} leva");
}
else if (type=="Discount")
{
    double result = row*column*5;
    Console.WriteLine($"{result:f2} leva");
}
