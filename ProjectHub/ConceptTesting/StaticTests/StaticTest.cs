namespace ConceptTesting.StaticTests;

internal static class StaticTest
{
    public static void ConstructorTesting()
    {
        //ConstructorTest test = new ConstructorTest();
        /* The above statement produces error.
         * Because when you have parameterized constructors, the default constructor of C# is no more in use
         * If the above statement is to be executed, must create parameterless constructor in class
         * These observations hold true even if you intialise the attributes of the class at declaration
         */

        // Testing if class attributes are initialized at object declaration
        ConstructorTest test;

        // Testing if class attributes are initialized at objrct new() allocation
        Console.WriteLine("Creating first ConstructorTest object");
        test = new(1, 2);

        //Testing If static Constructor is called again...
        Console.WriteLine("Creating first ConstructorTest object");
        ConstructorTest test2 = new ConstructorTest(2, 3);
    }

    public static void TestStaticClass()
    {
        Console.WriteLine("Calling static method using class name....");
        StaticClassTest.StaticMethod();
        Console.WriteLine("Calling static method using class name....");
        StaticClassTest.StaticMethod();
    }
}