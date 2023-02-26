﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment.Tests;

[TestClass]
public class PersonTests
{
    static readonly string testCsvRow = "1337, Tom, Rohr, trohr@ewu.edu, 4127 S. Sullivan Rd, Veradale, WA, 99037";
    readonly Person testPerson = SampleData.ParsePersonFromRow(testCsvRow);

    [TestMethod]
    public void Person_ParseAndSetProperties_Success()
    {
        Assert.AreEqual<string>("Tom", testPerson.FirstName);
        Assert.AreEqual<string>("Rohr", testPerson.LastName);
        Assert.AreEqual<string>("trohr@ewu.edu", testPerson.EmailAddress);
        Assert.AreEqual<string>("4127 S. Sullivan Rd, Veradale WA, 99037", testPerson.Address.ToString()!);


    }
}