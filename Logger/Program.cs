using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger;

public class Program
{
    public static void Main(string[] args)
    {
        FullName testFullNameRecord = new FullName(FirstName: "Thomas", LastName: "Rohr", MiddleName: "Stephen");
        Console.WriteLine(testFullNameRecord.ToString());

        Student testStudent = new(testFullNameRecord);
        Console.WriteLine(testStudent.ToString());
    }
}
