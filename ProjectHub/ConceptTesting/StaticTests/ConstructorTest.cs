namespace ConceptTesting.StaticTests;


//Put break point on the line of the static attribut declaration to test execution order of static
internal class ConstructorTest
{
    int num1 = 0;
    int num2 = 1;
    static int snum1 = 7;
    static int snum2 = 8;

    // Parameterized Constructor
    public ConstructorTest(int a, int b)
    {
        Console.WriteLine("Inside parametrised constructor");
        Console.WriteLine("num1: " + num1 + " num2: " + num2);
        num1 = a;
        num2 = b;
    }

    // Static Constructor
    static ConstructorTest()
    {
        Console.WriteLine("Inside Static Constructor");
        Console.WriteLine("snum1: " + snum1 + " snum2: " + snum2);
        snum1 = 1;
        snum2 = 1;
        snum3 = 1;
    }

    // Declared static attribute here for execution order testing purposes
    static int snum3 = 5;
}