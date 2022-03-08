namespace CollectionsDemo;

internal class Sample
{
    public static void doSetDemo()
    {
        Console.WriteLine("\nIn doSetDemo");
        var set = new HashSet<string>();
        set.Add("Ravi");
        set.Add("Vijay");
        set.Add("Ravi");
        set.Add("Ajay");
        HashSet<string>.Enumerator enumerator = set.GetEnumerator();
        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }
        //Console.WriteLine(set[3]);
    }
    public static void doQueueDemo()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Amit Sharma");

        queue.Enqueue("Vijay Raj");
        queue.Enqueue("Jaishankar");
        queue.Enqueue("Raj");
        Console.WriteLine("Head:" + queue.Peek());
        Console.WriteLine("\nIterating the queue elements: ");
        foreach (var element in queue)
        {
            Console.WriteLine(element);
        }
        string dequeue = queue.Dequeue();
        Console.WriteLine("Dequeue element: " + dequeue);
        Console.WriteLine("\nIterating the queue elements after dequeu one element:");
        Queue<string>.Enumerator enumerator = queue.GetEnumerator();
        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current);
        }
    }

    public static void doDictionaryDemo()
    {
        Console.WriteLine("\nIn doDictionaryDemo");
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(100, "Amit");
        dictionary.Add(101, "Rahul");
        dictionary.Add(102, "Vijay");
        Console.WriteLine("Access value using key(key=100): " + dictionary[100]);
        Console.WriteLine("\nIterating Dictionary: ");
        foreach (var element in dictionary)
        {
            Console.WriteLine("key=" + element.Key + "& Value=" + element.Value);
        }
    }
    public static void doStackDemo()
    {
        Console.WriteLine("\nIn doStackDemo");
        Stack<string> stack = new Stack<string>();
        stack.Push("Ayush");
        stack.Push("Garvit");
        stack.Push("Amit");
        stack.Push("Ashish");
        stack.Push("Garina");
        string pop = stack.Pop();
        foreach (var element in stack)
        {
            Console.WriteLine(element);
        }
        Console.WriteLine("Poped element: " + pop);
    }

    public static void doListDemo()
    {
        Console.WriteLine("\nIn doListDemo");
        List<string> list = new List<string>();
        list.Add("Ravi");
        list.Add("Vijay");
        list.Add("Ravi");
        list.Add("Ajay");
        //list.Add(123);
        foreach (var element in list)
        {
            Console.WriteLine(element);
        }
        Console.WriteLine(list[3]);
    }
}
