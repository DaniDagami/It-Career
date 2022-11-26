using System;
class Program
{
    static int GetMax(int f, int s)
    {
        if (f > s) return f;
        else return s;
    }
    static char GetMax(char f, char s)
    {
        if (f > s) return f;
        return s;
    }
    static string GetMax(string f, string s)
    {
        if (f.CompareTo(s) >= 0) return f;
        else return s;
    }
    static void Main()
    {
        var type = Console.ReadLine();
        if (type=="int")
        {
            int f = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(f, s));
        }
        else if (type == "char")
        {
            char f = char.Parse(Console.ReadLine());
            char s = char.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(f, s));
        }
        else if (type == "string")
        {
            string f = Console.ReadLine();
            string s = Console.ReadLine();
            Console.WriteLine(GetMax(f, s));
        }
    }
}