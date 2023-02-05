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
        public override string Name { get; init; } = FName.ToString() ?? throw new ArgumentNullException(nameof(FName));

        public override string ToString()
        {
            return String.Format("Student ID = {0}, Student Name: {1} {2} {3}",Id, FName.FirstName, FName.MiddleName, FName.LastName);
        }
        public virtual bool Equals(Student? other) => (Id).Equals(other?.Id); //Can we do this without allowing nullability?
        public override int GetHashCode() => HashCode.Combine(Id.GetHashCode(), Name.GetHashCode());
    }
}
