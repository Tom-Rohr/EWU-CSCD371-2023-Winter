﻿namespace GenericsHomework;

public class Node<TValue>
{
    public TValue? Value { get; set; } //does 'no validation necessary' mean null is fine? Erasing the ? from here and constructor causes no errors.
    public Node<TValue> Next { get; private set; } //is this sufficiently non-nullable because no code paths can make it null?
    public Node(TValue? value)
    {
        Value = value;
        Next = this;
    }

    public void Append(TValue value)
    {
        if (!Exists(value))
        {
            Node<TValue> temp = new(value) { Next = Next };
            Next = temp;
        }
        else
        {
            throw new ArgumentException(nameof(value) + " already exists in the list.");
        }
    }

    public bool Exists(TValue value)
    {
        Node<TValue> temp = this;
        bool exists = false;
        while (temp.Next != this && !exists) //unsure if != operator is correct here
        {
            if (temp.Value!.Equals(value)) //unsure if this is the right Equals to call
            {
                exists = true;
            }
            temp = temp.Next;
        }
        return exists;
    }

    public override string? ToString()
    {
        return (Value is null) ? "null" : Value!.ToString(); //is use of ! and ? ok here?
    }

    public void Clear()
    {
        this.Next = this; //When the rest of the items in the list fall out of execution reachability the
                          //garbage collector will collect them regardless of them pointing to each other.
                          //No need to point the last item away from this Node, as there is no root reference
                          //leading to the last item.
                          //https://stackoverflow.com/questions/400706/circular-references-cause-memory-leak
    }

    /*
     * https://learn.microsoft.com/en-us/archive/msdn-magazine/2000/november/garbage-collection-automatic-memory-management-in-the-microsoft-net-framework
     * When the garbage collector starts running, it makes the assumption that all objects in the heap are garbage. 
     * In other words, it assumes that none of the application's roots refer to any objects in the heap. Now, the 
     * garbage collector starts walking the roots and building a graph of all objects reachable from the roots. 
     * For example, the garbage collector may locate a global variable that points to an object in the heap. 
     * 
     * Figure 2 shows a heap with several allocated objects where the application's roots refer directly to objects 
     * A, C, D, and F. All of these objects become part of the graph. When adding object D, the collector notices 
     * that this object refers to object H, and object H is also added to the graph. The collector continues to
     * walk through all reachable objects recursively.
     * 
     * Once this part of the graph is complete, the garbage collector checks the next root and walks the objects again. 
     * As the garbage collector walks from object to object, if it attempts to add an object to the graph that 
     * it previously added, then the garbage collector can stop walking down that path. This serves two purposes. 
     * First, it helps performance significantly since it doesn't walk through a set of objects more than once. 
     * Second, it prevents infinite loops should you have any circular linked lists of objects.
     */
}