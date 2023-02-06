namespace Logger;

public class Program
{
    public static void Main(string[] args)
    {
        FullName testFullNameRecord = new FullName(FirstName: "Thomas", LastName: "Rohr", MiddleName: "Stephen");
        Console.WriteLine(testFullNameRecord.ToString());

        Student testStudent = new(1, testFullNameRecord);
        Console.WriteLine(testStudent.ToString());
    }
}