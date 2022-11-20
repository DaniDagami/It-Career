int eh = int.Parse(Console.ReadLine());
if (eh >= 0 && eh <= 23) {} else {Console.WriteLine("Error"); return;}
int em = int.Parse(Console.ReadLine());
if (em >= 0 && em <= 59) {} else {Console.WriteLine("Error"); return;}
int ch = int.Parse(Console.ReadLine());
if (ch >= 0 && ch <= 23) {} else {Console.WriteLine("Error"); return;}
int cm = int.Parse(Console.ReadLine());
if (cm >= 0 && cm <= 59) {} else {Console.WriteLine("Error"); return;}
eh = eh * 60;
ch = ch * 60;
int exam = eh + em;
int coming = ch + cm;
if (exam < coming)
{
    Console.WriteLine("Late");
    if (coming - exam < 60) Console.WriteLine($"{coming - exam} minutes after the start");
    else Console.WriteLine($"{(coming - exam) / 60:d}:{(coming - exam) % 60:d2} hours after the start");
}
else if (exam - coming <= 30)
{
    Console.WriteLine("On time");
    if (exam - coming > 0) Console.WriteLine($"{exam - coming} minutes before the start");
    else {} 
}
else if (exam - coming > 30)
{
    Console.WriteLine("Early");
    if (exam-coming < 60) Console.WriteLine($"{exam-coming} minutes before the start");
    else Console.WriteLine($"{(exam-coming) / 60:d}:{(exam-coming) % 60:d2} hours before the start");
}