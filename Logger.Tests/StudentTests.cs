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
        Employee testStudent = new(testName);

        Assert.AreEqual(testStudent.FName.ToString(), "Michael Gary Scott");
    }
}