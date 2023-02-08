namespace Logger;

public record class Book(string Title, FullName Author, int YearPublished) : Entity 
{
    //Implemented implicitly because Name and Title are used interchangebly for books and should be accessible for their type.
    public override string Name { get; init; } = Title ?? throw new ArgumentNullException(nameof(Title));

    //Null check broke when changing FullName from record class to record struct
    public FullName Author { get; init; } = Author;
    public int YearPublished { get; init; } = YearPublished <= 0 ? throw new ArgumentException(nameof(YearPublished)) : YearPublished;

    public virtual bool Equals(Book? other)
    {
        if (other is null) return false;
        return (Name, Author, YearPublished) == (other?.Name, other?.Author, other?.YearPublished);
    }

    public override int GetHashCode() =>  HashCode.Combine(Title.GetHashCode(), Author.GetHashCode(), YearPublished.GetHashCode());

    public override string ToString()
    {
        return string.Format("TITLE: {0}, AUTHOR: {1}, PUBLISHED: {2}", Name, Author, YearPublished);
    }
}