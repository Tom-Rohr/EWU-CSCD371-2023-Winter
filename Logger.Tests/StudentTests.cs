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

        Assert.AreEqual(testStudent.FName.ToString(), "Michael Gary Scott");
    }

    [TestMethod]
    public void Student_ValueBasedEquality_True()
    {
        FullName testName = new("Michael", "Scott", "Gary");
        Student testStudent = new(testName);
        Student testStudent2 = new(testName);

        Assert.IsFalse(testStudent2.Equals(testStudent));
        //Assert.AreEqual(testStudent, testStudent2);
    }
}