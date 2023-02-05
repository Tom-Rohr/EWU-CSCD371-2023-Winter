using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public record class Person(FullName FName) : Entity
    {
        public override string Name { get; init; } = FName.ToString() ?? throw new ArgumentNullException(nameof(FName));

        public override string ToString()
        {
            return String.Format("ID: {0}, Full Name: {1} {2} {3}", Id, FName.FirstName, FName.MiddleName, FName.LastName);
        }
        public virtual bool Equals(Person? other)
        {
            if (other is null) return false;
            return (Id, Name) == (other.Id, other.Name);
        }
        public override int GetHashCode() => HashCode.Combine(Id.GetHashCode(), Name.GetHashCode());

    }
}
