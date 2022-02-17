namespace GenericsDemo;
internal class GenericsMethods
{
    public static void ToPrint(int[] inputArray)
    {
        foreach (double element in inputArray)
        {
            Console.WriteLine(element);
        }
        Console.WriteLine("----------------------------------");
    }

    public static void ToPrint(double[] inputArray)
    {
        for (int element = 0; element < inputArray.Length; element++)
        {
            Console.WriteLine(inputArray[element]);
        }
        foreach (double element in inputArray)
        {
            Console.WriteLine(element);
        }
        Console.WriteLine("----------------------------------");
    }

    public static void ToPrint(char[] inputArray)
    {
        foreach (char element in inputArray)
        {
            Console.WriteLine(element);
        }
        Console.WriteLine("-------------------------------------");
    }

    public static void ToPrint<T>(T[] inputArray)
    {
        foreach (var element in inputArray)
        {
            Console.WriteLine(element);
        }
        Console.WriteLine("----------------------------------");
    }
}