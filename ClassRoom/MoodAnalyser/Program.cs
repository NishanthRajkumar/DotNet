Console.Title = "Mood Analyser App";
Console.WriteLine("==========Mood Analyser==========");

int num;
string text = "875349075925675468069869340957606";

try
{
    Console.Read();
    num = Int32.Parse(text);
}
catch (ArgumentNullException e)
{
    Console.WriteLine("caught no argument");
}
catch (FormatException e)
{
    Console.WriteLine("Format error");
}
catch (OverflowException e)
{
    Console.WriteLine("Overflowed");
}