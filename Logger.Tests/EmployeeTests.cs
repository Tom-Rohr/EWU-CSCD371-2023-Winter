using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Tests;

[TestClass]
public class EmployeeTests
{
    [TestMethod]
    public void Employee_SetsFullName_Success()
    {
        FullName testName = new("Michael", "Scott", "Gary");
        Employee testEmployee = new(testName);

        Assert.AreEqual(testEmployee.FName, "Michael Gary Scott");
    }
}
