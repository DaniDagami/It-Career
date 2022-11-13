string shape = Console.ReadLine();
if (shape == "square")
{
    var a = double.Parse(Console.ReadLine());
    Console.WriteLine(Math.Round(a*a,3));
}
else if (shape == "rectangle")
{
    var a = double.Parse(Console.ReadLine());
    var b = double.Parse(Console.ReadLine());
    Console.WriteLine(Math.Round(a*b,3));
}
else if (shape == "circle")
{
    var a = double.Parse(Console.ReadLine());
    Console.WriteLine(Math.Round(Math.PI * a * a,3));
}
else if (shape == "triangle")
{
    var a = double.Parse(Console.ReadLine()); 
    var b = double.Parse(Console.ReadLine());
    Console.WriteLine(Math.Round(a * b/2,3));
}
