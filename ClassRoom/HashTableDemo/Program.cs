namespace HashTableDemo;

class Program
{
    static void Main(string[] args)
    {
        //Hashtable ht = new Hashtable();
        Console.WriteLine("Hash table demo"); //() []
        MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
        hash.Add("0", "To");
        hash.Add("1", "be");
        hash.Add("2", "or");
        hash.Add("3", "not");
        hash.Add("4", "to");
        hash.Add("5", "Not be");
        hash.Add("5", "be");
        hash.Add("5", "be 2");

        string hash5 = hash.Get("5");
        Console.WriteLine("5th index value: " + hash5);
        string hash2 = hash.Get("2");
        Console.WriteLine("2th index value: " + hash2);
        Console.ReadKey();


        ///////////////
        ///
        /*ht.Add(14, 135.789);
        ht.Add("key", 130);
        ht.Add(14.0, "Value");
        ht.Add(14, 135.789);*/

        /*Hashtable hashtable = new Hashtable(2);

        hashtable.Add("a", 1);
        //hashtable.Add("b", 2);
        //hashtable.Add("c", 3);
        Console.ReadKey();*/
    }
}