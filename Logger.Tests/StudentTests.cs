using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Tests;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void Student_SetsFullName_Success()
    {
        FullName testName = new("Michael","Scott","Gary");
        Student testStudent = new(testName);

        Assert.AreEqual(testStudent.Name, "Michael Gary Scott");
    }

    [TestMethod]
    public void TwoStudends_SameName_EqualityIsFalse()
    {
        FullName testName = new("Michael", "Scott", "Gary");
        Student testStudent = new(testName);
        Student testStudent2 = new(testName);

        Assert.IsFalse(testStudent2.Equals(testStudent)); //Same name, different guid
        Assert.IsTrue(testStudent.Equals(testStudent));
    }

    [TestMethod]
    public void Student_OverridenToStringFormat_Correct()
    {
        FullName testName = new("Michael", "Scott", "Gary");
        Student testStudent = new(testName);
        string expected = String.Format("ID: {0}, Full Name: {1} {2} {3}",
            testStudent.Id.ToString(), 
            testStudent.FName.FirstName, 
            testStudent.FName.MiddleName, 
            testStudent.FName.LastName);

        Assert.AreEqual(expected, testStudent.ToString());
    }
}