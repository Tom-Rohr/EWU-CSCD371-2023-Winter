namespace Logger;

public record class Book(string Title, string Author, int YearPublished) : Entity
{
    public override string Name { get; init; } = Title ?? throw new ArgumentNullException(nameof(Title));
    public string Author { get; init; } = Author?? throw new ArgumentNullException(nameof(Author));
    public int YearPublished { get; init; } = YearPublished;

    public virtual bool Equals(Book? other)
    {
        if (other is null) return false;
        return (Name, Author, YearPublished) == (other?.Name, other?.Author, other?.YearPublished);
    }

    public override int GetHashCode() =>  Title.GetHashCode();
}
