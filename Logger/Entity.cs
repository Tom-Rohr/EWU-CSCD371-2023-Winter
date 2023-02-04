using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public abstract record class Entity : IEntity
{
    public abstract string Name { get; set; }
    public Guid Id { get; init; } = Guid.NewGuid();
}
