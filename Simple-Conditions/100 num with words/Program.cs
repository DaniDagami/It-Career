int num = int.Parse(Console.ReadLine());
if (num<0 || num>100) Console.WriteLine("invalid number");
else
{
    int des = num/10;
    int ed = num%10;
    if (des == 0 && ed == 0) Console.WriteLine("zero");
    else if (des == 10) Console.WriteLine("a hundred");
    if (des == 1 && ed == 0) Console.WriteLine("ten");
    else if (des == 1 && ed == 1) Console.WriteLine("eleven");
    else if (des == 1 && ed == 2) Console.WriteLine("twelve");
    else if (des == 1 && ed == 3) Console.WriteLine("thirteen");
    else if (des == 1 && ed == 4) Console.WriteLine("fourteen");
    else if (des == 1 && ed == 5) Console.WriteLine("fifteen");
    else if (des == 1 && ed == 6) Console.WriteLine("sixteen");
    else if (des == 1 && ed == 7) Console.WriteLine("seventeen");
    else if (des == 1 && ed == 8) Console.WriteLine("eighteen");
    else if (des == 1 && ed == 9) Console.WriteLine("nineteen");
    if (des ==2) Console.Write("twenty ");
    else if (des ==3) Console.Write("thirty ");
    else if (des ==4) Console.Write("forty ");
    else if (des ==5) Console.Write("fifty ");
    else if (des ==6) Console.Write("sixty ");
    else if (des ==7) Console.Write("seventy ");
    else if (des ==8) Console.Write("eighty ");
    else if (des ==9) Console.Write("ninety ");
    if (ed == 1) Console.WriteLine("one");
    else if (ed == 2&& des != 1) Console.WriteLine("two");
    else if (ed == 3&& des != 1) Console.WriteLine("three");
    else if (ed == 4&& des != 1) Console.WriteLine("four");
    else if (ed == 5&& des != 1) Console.WriteLine("five");
    else if (ed == 6&& des != 1) Console.WriteLine("six");
    else if (ed == 7&& des != 1) Console.WriteLine("seven");
    else if (ed == 8&& des != 1) Console.WriteLine("eight");
    else if (ed == 9&& des != 1) Console.WriteLine("nine");
}
