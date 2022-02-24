using BinarySearchTree;

class Program
{
    static void Main(string[] args)
    {
        //1.0//1
        Console.WriteLine("\\nHello World!"); //[3,7,9,11,55,67]
        BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
        binarySearch.Insert(30);
        binarySearch.Insert(70);
        binarySearch.Insert(22);
        binarySearch.Insert(40);
        binarySearch.Insert(60);
        binarySearch.Insert(95);
        binarySearch.Insert(11);
        binarySearch.Insert(65);
        binarySearch.Insert(3);
        binarySearch.Insert(16);
        binarySearch.Insert(63);
        binarySearch.Insert(67);
        binarySearch.Display();
        bool result = binarySearch.IfExists(67, binarySearch);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}