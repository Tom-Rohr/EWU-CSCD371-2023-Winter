using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Logger
{
    public record class Student(FullName FName, Standing studentStanding) : Entity
    {
        public override string Name { get; init; } = FName.ToString() ?? throw new ArgumentNullException(nameof(FName));
        public Standing studentStanding { get; set; } = studentStanding; //TO DO do we need to perform a check on this enum?

        public override string ToString()
        {
            return String.Format("{0} {1} {2}",FName.FirstName, FName.MiddleName, FName.LastName);
        }
        public virtual bool Equals(Student? other) => (Name, studentStanding).Equals((other?.Name, other?.studentStanding)); //Can we do this without allowing nullability?
        public override int GetHashCode() => HashCode.Combine(Name.GetHashCode(), studentStanding.GetHashCode());
    }
}
