string product = Console.ReadLine();
string town = Console.ReadLine();
var num = double.Parse(Console.ReadLine());
if (product=="coffee")
{
    if (town== "Sofia") Console.WriteLine(num=num*0.5);
    else if (town=="Plovdiv") Console.WriteLine(num=num*0.4);
    else if (town=="Varna") Console.WriteLine(num=num*0.45);
}
else if (product=="water")
{
    if (town== "Sofia") Console.WriteLine(num=num*0.8);
    else if (town=="Plovdiv") Console.WriteLine(num=num*0.7);
    else if (town=="Varna") Console.WriteLine(num=num*0.7);
}
else if (product=="beer")
{
    if (town== "Sofia") Console.WriteLine(num=num*1.2);
    else if (town=="Plovdiv") Console.WriteLine(num=num*1.15);
    else if (town=="Varna") Console.WriteLine(num=num*1.1);
}
else if (product=="sweets")
{
    if (town== "Sofia") Console.WriteLine(num=num*1.45);
    else if (town=="Plovdiv") Console.WriteLine(num=num*1.3);
    else if (town=="Varna") Console.WriteLine(num=num*1.35);
}
else if (product=="peanuts")
{
    if (town== "Sofia") Console.WriteLine(num=num*1.6);
    else if (town=="Plovdiv") Console.WriteLine(num=num*1.5);
    else if (town=="Varna") Console.WriteLine(num=num*1.55);
}

