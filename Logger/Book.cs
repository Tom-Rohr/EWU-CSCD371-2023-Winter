using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class Book(string Title, string Author, int YearPublished) : Entity
{
    public override string Name { get; init; } = Title ?? throw new ArgumentNullException(nameof(Title));
    public virtual bool Equals(Book? other) => (Name).Equals(other?.Name); 
    public override int GetHashCode() =>  Title.GetHashCode();
}
