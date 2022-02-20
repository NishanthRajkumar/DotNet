using StackLinkedList;

Console.Title = "Stack using Linked List";
Console.WriteLine("==========Stack using Linked List==========");

Console.WriteLine("Hello World!");
LinkedListStack linkedListStack = new LinkedListStack();
linkedListStack.Push(70);
linkedListStack.Push(30);
linkedListStack.Push(56);
linkedListStack.Display();
//linkedListStack.Peek(); top.data
//linkedListStack.Pop();
//linkedListStack.IsEmpty();
//linkedListStack.Display();
Console.ReadKey();