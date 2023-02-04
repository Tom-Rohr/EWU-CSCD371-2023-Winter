using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class Employee(FullName FName) : Entity
{
    public override string Name { get; set; } = FName.ToString() ?? throw new ArgumentNullException(nameof(FName));
}
