namespace DelegateDemo;

class Program
{
    //public delegate int operation123(int b, int c);
    public delegate int operation(int x, int y);
    static int Addition(int a, int b)
    {
        return a + b;
    }
    //static int Addition123(int a, int b, int c)
    //{
    //    return a + b;
    //}
    static void Main(string[] args)
    {
        Console.WriteLine("Delegate Demo");
        //operation obj = new operation(Addition);
        //Console.WriteLine("Addition is = {0}",obj.Invoke(23,27));
        MulticastDelegate.ImplementDelegate();
        Console.ReadKey();
    }
}
