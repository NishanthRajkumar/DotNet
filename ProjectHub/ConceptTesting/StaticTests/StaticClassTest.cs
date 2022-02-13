namespace ConceptTesting.StaticTests;

// This class is used for testing static classes
internal static class StaticClassTest
{
    private static int num = 0;

    static StaticClassTest()
    {
        Console.WriteLine("Inside Static class constructor");
        num++;
    }

    internal static void StaticMethod()
    {
        Console.WriteLine("num: " + num);
    }
}