using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class Book(string Title, FullName Author, int ISBN) : Entity
{
    public override string Name { get; init; } = Title ?? throw new ArgumentNullException(nameof(Title));
    public FullName AuthorName { get; init; } = Author ?? throw new ArgumentNullException(nameof(Author));
    public int ISBN { get; init; } = ISBN; // throw new ArgumentException();
    public virtual bool Equals(Book? other) => (Name, Id).Equals((other?.Name, other?.Id));
    public override int GetHashCode() => HashCode.Combine(Id.GetHashCode(), Title.GetHashCode(), Author.GetHashCode(), ISBN);
}
