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
        FullName testRecord = new FullName(FirstName: "Thomas", LastName: "Rohr", MiddleName: "Stephen");
        Console.WriteLine(testRecord.ToString());
    }
}
