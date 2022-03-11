namespace LambdaExpressionDemo;

internal class Person
{
    public string SSN;
    public string Name;
    public string Address;
    public int Age;

    public Person(string ssn, string name, string addr, int age)
    {
        SSN = ssn;
        Name = name;
        Address = addr;
        Age = age;
    }
}

internal static class Newclass
{
    public static void GetInfo(this Person O)
    {
        Console.WriteLine("Entended method");
    }
}