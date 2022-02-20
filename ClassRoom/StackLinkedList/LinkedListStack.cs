namespace StackLinkedList;

internal class LinkedListStack
{
    private Node top;
    public LinkedListStack()
    {
        this.top = null;
    }

    //30
    internal void Push(int value)
    {
        Node node = new Node(value);
        if (this.top == null)
            node.next = null;
        else
            node.next = this.top;
        this.top = node;
        Console.WriteLine("{0} pushed to stack ", value);
    }
    public void Display()
    {
        Node temp = this.top;
        while (temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next;//1400
        }
    }

    internal void Peek()
    {
        if (this.top == null)
        {
            Console.WriteLine("Stack is empty");
            return;
        }
        Console.WriteLine("{0} is in the top of the stack ", this.top.data);//NullrefrenceRxception
    }

    internal void Pop()
    {
        if (this.top == null)
        {
            Console.WriteLine("Stack is empty, Deletion is not possible");
            return;
        }
        Console.WriteLine("Value popped is {0} ", this.top.data);
        this.top = this.top.next;
    }

    internal void IsEmpty()
    {
        while (this.top != null)
        {
            Peek();
            Pop();
        }
        //this.top=null;
    }

}
