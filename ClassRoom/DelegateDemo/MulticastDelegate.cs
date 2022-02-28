namespace DelegateDemo;

class MulticastDelegate
{
    delegate void Delop(int x, int y);
    public static void ImplementDelegate()
    {

        Delop obj = Operation.Add;
        obj += Operation.Square;   //  int x=5;   x+=6 x
        //obj -= Operation.Square;
        obj(5, 5);
        obj(8, 3);
        obj = null;
    }
}
public class Operation
{
    public Operation(int a)
    {
        Console.WriteLine(a);
    }
    public static void Add(int a, int b)
    {
        Console.WriteLine("Addition = {0}", a + b);
    }
    public static void Square(int a, int b)
    {
        Console.WriteLine("Multiple = {0}", a * b);
    }
}