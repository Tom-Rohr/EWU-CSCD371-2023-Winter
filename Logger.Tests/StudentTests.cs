using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void Student_SetsFullName_Success()
    {
        FullName testName = new("Michael","Scott","Gary");
        Student testStudent = new(1, testName);

        Assert.AreEqual(testStudent.Name, "Michael Gary Scott");
    }

    [TestMethod]
    public void TwoStudends_SameName_EqualityIsFalse()
    {
        FullName testName = new("Michael", "Scott", "Gary");
        Student testStudent = new(1, testName);
        Student testStudent2 = new(2, testName);

        Assert.IsFalse(testStudent2.Equals(testStudent)); //Same name, different guid
        Assert.IsTrue(testStudent.Equals(testStudent));
    }

    [TestMethod]
    public void Student_OverridenToStringFormat_Correct()
    {
        FullName testName = new("Michael", "Scott", "Gary");
        Student testStudent = new(1, testName);
        string expected = String.Format("Student ID: {0}, Full Name: {1}", testStudent.SID, testStudent.FName);  

        Assert.AreEqual(expected, testStudent.ToString());
    }
}