using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Tests;

[TestClass]
public class FullNameTests
{
    [TestMethod]
    public void FullName_SetsCorrectly()
    {
        FullName testRecord = new FullName(FirstName:"Thomas", LastName:"Rohr", MiddleName:"Stephen");

        Assert.AreEqual(testRecord.ToString(), "Thomas Stephen Rohr");
    }
}
