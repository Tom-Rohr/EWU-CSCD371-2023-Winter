using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Assignment;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Tests;

[TestClass]
public class SampleDataTests
{
    [TestMethod]
    public void SampleData_FillsListFromCSVRows_Success()
    {
        SampleData data = new();
        IEnumerable<string> items = data.CsvRows;

        Assert.AreEqual<int>(50, items.Count());
    }
}
