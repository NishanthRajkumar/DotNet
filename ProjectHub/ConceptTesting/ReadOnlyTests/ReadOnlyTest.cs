namespace ConceptTesting.ReadOnlyTests;


// This class is used test the readonly and observe it's difference from constant
internal class ReadOnlyTest
{
    // Decalaring and intializing the readonly variable with a value
    private readonly int num = 2;

    // Testing if readonly value can be changed in constructor
    public ReadOnlyTest()
    {
        num++;
    }

    // parametrised constructor
    public ReadOnlyTest(int a)
    {
        num = a;
    }

    public void Display()
    {
        Console.WriteLine("num: " + num);
    }
}