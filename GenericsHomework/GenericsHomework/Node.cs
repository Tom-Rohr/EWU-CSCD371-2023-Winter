﻿namespace GenericsHomework;

public class Node<TItem>
{
    public TItem Item { get; init; }
    public Node<TItem> Next { get; private set; }
    public TItem Prev { get; set; }

    public Node(TItem item)
    {
        Item = item ?? throw new ArgumentNullException(nameof(item));
        Next = this ?? throw new ArgumentNullException(nameof(item));//Initially points to itself, cannot be null per instructions
        Prev = Item ?? throw new ArgumentNullException(nameof(item));//Initially points to its own item.
    }

    public Node<TItem> Append(TItem newItem) //TO DO always have newly created node point to first item that was added
    {
        Node<TItem> newNode = new(newItem); //Make new node      //Indicate this is not the tail
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