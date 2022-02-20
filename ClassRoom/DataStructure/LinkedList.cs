namespace DataStructure;

internal class LinkedList
{
    internal Node head; //new 
    internal void Add(int data)
    {
        Node node = new Node(data);
        if (this.head == null)
            this.head = node;
        else
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = node;
        }
        Console.WriteLine("{0} inserted into the linked list", node.data);
    }

    internal void Display()
    {
        Node temp = this.head;
        if (temp == null)
        {
            Console.WriteLine("Linked list is empty");
            return;
        }
        while (temp != null)
        {
            Console.Write(temp.data + " ");
            temp = temp.next; //temp=null
        }
    }
    // 3 15
    internal Node InsertAtParticularPosition(int position, int data)
    {
        if (position < 1)
            Console.WriteLine("Invalid position");
        if (position == 1)
        {
            var newNode = new Node(data);
            newNode.next = this.head;
            head = newNode;
        }
        else
        {
            Node temp = this.head;
            while (position != 0) //
            {

                if (position == 1)
                {
                    Node node = new Node(data);
                    node.next = this.head.next;
                    head.next = node;
                    break;
                }
                temp = temp.next;//1000
            }
            if (position != 1)
                Console.WriteLine("Position out of range");
        }
        return head;
    }

    internal Node RemoveFirstNode()
    {
        if (this.head == null)
            return null;
        this.head = this.head.next;
        return this.head;
    }

    internal Node RemovaLastNode()
    {
        if (head == null)
            return null;
        if (head.next == null)
            return null;
        Node newNode = head;
        while (newNode.next.next != null)
        {
            newNode = newNode.next;
        }
        newNode.next = null;
        return head;
    }

    internal Node Search(int value)
    {
        while (this.head != null)
        {
            if (this.head.data == value)
            {
                return this.head;
            }
            this.head = this.head.next;
        }
        return null;
    }

}
