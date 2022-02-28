using BinarySearchTree;

class Program
{
    static void Main(string[] args)
    {
        //1.0//1
        Console.WriteLine("\\nHello World!"); //[3,7,9,11,55,67]
        BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
        binarySearch.Insert(30);
        binarySearch.Display();

        binarySearch.Insert(70);

        binarySearch.GetSize();


        bool result = binarySearch.IfExists(67, binarySearch);
        Console.WriteLine("67 in tree? " + result);


        Console.ReadKey();
    }
}