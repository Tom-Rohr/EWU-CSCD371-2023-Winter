using static System.Net.Mime.MediaTypeNames;

namespace GenericsHomework;

public class GenericCircularlyLL<TItem>
{
    public Node<TItem>? Head { get; set; }
    public Node<TItem>? Current { get; set; }

   /* public void Append(TItem newItem) //TO DO always have newly created node point to first item that was added
    {  
        if(Head is null && Current is null)
        {
            Node<TItem> newNode = new(newItem);
            Head = newNode;
            Current = newNode;
        }
        else
        {
            Node<TItem> newNode = new(newItem);
            newNode.Append(this);
            Current = newNode;   
        }

        //TODO: Write a Exists method to check if what we are trying to add is already in the list.
        //      Call the method before the return statement and throw an exception if there is a duplicate
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

}
