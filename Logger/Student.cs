using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Logger
{
    public record class Student(FullName FName) : Entity
    {
        public override string Name { get; set; } = FName.ToString() ?? throw new ArgumentNullException(nameof(FName));

        public virtual bool Equals(Student? other) => (Name, Id).Equals((other?.Name, other?.Id)); //Can we do this without allowing nullability?
        public override int GetHashCode() => HashCode.Combine(Name.GetHashCode(), Id.GetHashCode());
    }
}
