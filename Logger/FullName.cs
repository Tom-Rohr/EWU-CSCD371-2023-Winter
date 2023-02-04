namespace Logger;

//A.)Creating a 'record struct' to define a custom value type as opposed to a 'record class' because...
/////1.) FullNameRecord logically represents one value.
/////2.) It will be immutable.
/////3.) It will consume less than 16-bytes of data.
/////4.) It will not be boxed frequently, so memory overhead will be less than using a reference type.
/////5.) Nothing should need to inherit from this record.

//B.)The Type is immutable because the record declaration is decorated with the 'readonly' modifier, meaning
/////the positional parameters can only be set in the constructor during initialization and cannot be changed.
public record struct FullName(string FirstName, string LastName, string? MiddleName = null)
{
    public string FirstName { get; } = FirstName??throw new ArgumentNullException(nameof(FirstName));
    public string LastName { get; } = LastName??throw new ArgumentNullException(nameof(LastName));
    public string? MiddleName { get; } = MiddleName;

    public override string ToString()
    {
        return FirstName + " " + MiddleName + " " + LastName;
    }
}
