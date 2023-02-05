using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Logger
{
    public record class Student(FullName FName) : Person(FName)
    {
        public override string ToString() => base.ToString();
        public virtual bool Equals(Student? other) => base.Equals(other);
   
        public override int GetHashCode() => base.GetHashCode();
    }
}
