namespace GenericsHomework;

public class Node<TItem>
{
    public static Node<TItem>? Head;
    public static Node<TItem>? Current;
    public TItem Item { get; init; }
    public Node<TItem> Next { get; private set; }

    public Node(TItem item)
    {
        if (Head is null && Current is null)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
            Next = this;
            Head = this;
            Current = this;
        }
        else
        {
            Item = item ?? throw new ArgumentNullException(nameof(item));
            Next = Current!;
            Current = this;
            Head!.Next = Current;
        }
        //Item = item ?? throw new ArgumentNullException(nameof(item));
        //Next = this ?? throw new ArgumentNullException(nameof(item));//Initially points to itself, cannot be null per instructions
    }

    public void Append()
    {

    }

    public override string? ToString()
    {
        return Item!.ToString(); //Better way to handle than using '!'?
    }
}