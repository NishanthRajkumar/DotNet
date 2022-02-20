using QueueLinkedList;

Console.Title = "Queue using Linked List";
Console.WriteLine("==========Queue using Linked List==========");

LinkedListQueue linkedListQueue = new LinkedListQueue();
linkedListQueue.Enqueue(56);
linkedListQueue.Enqueue(30);
linkedListQueue.Enqueue(70);
linkedListQueue.Display();// this.top=this.top.next
Console.ReadKey();