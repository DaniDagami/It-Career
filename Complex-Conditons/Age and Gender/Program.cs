int a = int.Parse(Console.ReadLine());
string pol = Console.ReadLine();
if (a<16)
{
    if (pol == "f") Console.WriteLine("Miss");
    else  Console.WriteLine("Master");
}
else 
{
    if (pol == "f") Console.WriteLine("Ms.");
    else Console.WriteLine("Mr.");
}
