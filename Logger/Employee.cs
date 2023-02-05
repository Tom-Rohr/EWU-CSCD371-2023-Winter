namespace Logger;

public record class Employee(FullName FName) : Person(FName)
{
    public override string ToString() => base.ToString();
    public virtual bool Equals(Employee? other) => base.Equals(other);
  
    public override int GetHashCode() => base.GetHashCode();
}
