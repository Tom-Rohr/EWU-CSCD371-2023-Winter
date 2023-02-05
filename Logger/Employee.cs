using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public record class Employee(FullName FName) : Person(FName)
{
    public override string ToString() => base.ToString();
    public virtual bool Equals(Employee? other) => base.Equals(other);
  
    public override int GetHashCode() => HashCode.Combine(Id.GetHashCode(), Name.GetHashCode());
}
