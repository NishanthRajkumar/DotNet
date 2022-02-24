namespace EventsDemo;

public delegate void DelEventHandler();
class Program
{
    public static event DelEventHandler add;
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World!");
        //add += new DelEventHandler(India);
        //add += new DelEventHandler(USA);
        //add += new DelEventHandler(England);
        //add.Invoke();
        Console.WriteLine("************Event Handling****************");
        EventHandling.ImplementEvent();
        Console.ReadKey();
    }
    private static void India()
    {
        Console.WriteLine("India");
    }
    private static void USA()
    {
        Console.WriteLine("USA");
    }
    private static void England()
    {
        Console.WriteLine("England");
    }
}
