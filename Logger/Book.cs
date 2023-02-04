using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class Book(string Title) : Entity
{
    public override string Name { get; set; } = Title ?? throw new ArgumentNullException(nameof(Title));
}
