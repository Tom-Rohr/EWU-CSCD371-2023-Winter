namespace Logger;

//A.)Creating a 'record struct' to define a custom value type as opposed to a 'record class' because...
/////1.) FullNameRecord logically represents one value.
/////2.) FullName is comprised of 3 strings, which are reference types. So, the length of strings will not matter since the references being stored will be less than 16 bytes.

//B.) The Type is immutable because the struct is decorated with the access modifier 'readonly' so it cannot be changed after instantiation.
////  FullName should be immutable because we do not want to allow Entities to change their names. 
public readonly record struct FullName(string FirstName, string LastName, string? MiddleName = null)
{
    public string FirstName { get; } = FirstName??throw new ArgumentNullException(nameof(FirstName));
    public string LastName { get; } = LastName??throw new ArgumentNullException(nameof(LastName));
    public string? MiddleName { get; } = MiddleName;

    public override string ToString()
    {
        if (MiddleName is null) return $"{FirstName} {LastName}";
        return $"{FirstName} {MiddleName} {LastName}";
    }
}