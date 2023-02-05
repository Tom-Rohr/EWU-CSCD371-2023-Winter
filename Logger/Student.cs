
namespace Logger
{
    public record class Student(FullName FName) : Person(FName)
    {
        public override string ToString() => base.ToString();
        public virtual bool Equals(Student? other) => base.Equals(other);
   
        public override int GetHashCode() => base.GetHashCode();
    }
}