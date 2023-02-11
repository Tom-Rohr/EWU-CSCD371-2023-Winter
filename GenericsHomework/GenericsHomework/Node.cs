namespace GenericsHomework;

public class Node<TValue>
{
    public TValue Item { get; set; }
    public Node<TValue> Next { get; private set; }
    public TValue Prev { get; set; }
    internal bool IsFirstItem { get; set; } = true;

    public Node(TValue item)
    {
        Item = item;
        Next = this; //Initially points to itself, cannot be null per instructions
        Prev = Item; //Initially points to its own item.
    }

    public Node<TValue> Append(TValue newItem) //TO DO always have newly created node point to first item that was added
    {
        Node<TValue> newNode = new(newItem); //Make new node
        newNode.IsFirstItem = false;         //Indicate this is not the tail
        newNode.Prev = Item;                 //Will point to previous item (this.Item)
        Next = newNode;                      //Set current node's next to the new node
        return newNode;                      //Return the new Node, which is now the head of the list

        /*TODO: Write a Exists method to check if what we are trying to add is already in the list.
                Call the method before the return statement and throw an exception if there is a duplicate*/
    }

    /*
    public bool Exists(TValue item)
    {
        return false;
    }
    */
    /*
    public void Clear()
    {

    }
    */
    public override string? ToString()
    {
        return Item!.ToString(); //Better way to handle than using '!'?
    }
}