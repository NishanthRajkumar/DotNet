namespace BinarySearchTree;

class BinarySearchTree<T> where T : IComparable<T>
{
    public T NodeData { get; set; }
    public BinarySearchTree<T> leftTree { get; set; }
    public BinarySearchTree<T> rightTree { get; set; }

    public BinarySearchTree(T nodeData)
    {
        this.NodeData = nodeData;
        this.rightTree = null;
        this.leftTree = null;

    }

    int leftCount = 0, rightCount = 0;
    bool result = false;
    public void Insert(T item)
    {
        T currentNodeValue = this.NodeData;
        if ((currentNodeValue.CompareTo(item)) > 0) // "A".CompareTo("a")
        {
            if (this.leftTree == null)
                this.leftTree = new BinarySearchTree<T>(item);
            else
                this.leftTree.Insert(item);
        }
        else
        {
            if (this.rightTree == null)
                this.rightTree = new BinarySearchTree<T>(item);
            else
                this.rightTree.Insert(item);
        }
    }


    public void Display()
    {
        if (this.leftTree != null)
        {
            this.leftCount++;
            this.leftTree.Display();
        }
        Console.WriteLine(this.NodeData.ToString());
        if (this.rightTree != null)
        {
            this.rightCount++;
            this.rightTree.Display();
        }
    }

    public void GetSize()
    {
        Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
    }

    public bool IfExists(T element, BinarySearchTree<T> node)
    {
        if (node == null)
            return false;
        if (node.NodeData.Equals(element))
        {
            Console.WriteLine("Found the element in BST" + " " + node.NodeData);
            result = true;
        }
        else
            Console.WriteLine("Current element is {0} in BST", node.NodeData);
        if (element.CompareTo(node.NodeData) < 0)
            IfExists(element, node.leftTree);
        if (element.CompareTo(node.NodeData) > 0)
            IfExists(element, node.rightTree);
        return result;
    }
}
