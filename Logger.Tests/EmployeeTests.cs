using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class EmployeeTests
{
    [TestMethod]
    public void Employee_SetsFullName_Success()
    {
        FullName testName = new("Michael", "Scott", "Gary");
        Employee testEmployee = new(1, testName);

        Assert.AreEqual(testEmployee.FName.ToString(), ("Michael Gary Scott"));
    }
}
