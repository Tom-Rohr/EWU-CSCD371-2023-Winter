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
    public void Student_SetsFullNameAndStanding_Success()
    {
        FullName testName = new("Michael","Scott","Gary");
        Student testStudent = new(testName, Standing.Senior);

        Assert.AreEqual(testStudent.FName.ToString(), "Michael Gary Scott");
        Assert.AreEqual(testStudent.studentStanding, Standing.Senior);
    }

    [TestMethod]
    public void Student_ValueBasedEquality_True()
    {
        FullName testName = new("Michael", "Scott", "Gary");
        Student testStudent = new(testName, Standing.Senior);
        Student testStudent2 = new(testName, Standing.Senior);

        Assert.IsTrue(testStudent2.Equals(testStudent));
        //Assert.AreEqual(testStudent, testStudent2);
    }
}