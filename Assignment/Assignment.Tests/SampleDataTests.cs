using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment.Tests;

[TestClass]
public class SampleDataTests
{
    SampleData data = new();

    [TestMethod]
    public void SampleData_FillsListFromCSVRows_Success()
    {
        IEnumerable<string> items = data.CsvRows;

        Assert.AreEqual<int>(50, items.Count());
    }

    [TestMethod]
    public void GetUniqueSortedListOfStatesGivenCsvRows_FillsUniqueStates()
    {
        IEnumerable<string> uniqueStates = data.GetUniqueSortedListOfStatesGivenCsvRows();

        Assert.IsTrue(uniqueStates.Distinct().Count() == uniqueStates.Count());
    }

    [TestMethod]
    public void GetUniqueSortedListOfStatesGivenCsvRows_IsSorted()
    {
        List<string> uniqueStates = data.GetUniqueSortedListOfStatesGivenCsvRows().ToList();
        bool nextElementAscendsPrevious = true;

            for(int i=0; i<uniqueStates.Count-1; i++)
            {
                if (StringComparer.Ordinal.Compare(uniqueStates[i], uniqueStates[i + 1]) > 0)
                    nextElementAscendsPrevious = false;
            }

        Assert.IsTrue(nextElementAscendsPrevious);
    }

    [TestMethod]
    public void SpokaneAddresses_YieldOneDistinctState_True()
    {
        List<string> uniqueStates = new();
        foreach (Address address in spokaneAddresses) 
        {
            if (!uniqueStates.Contains(address.State)) uniqueStates.Add(address.State);
        }
        Assert.AreEqual<int>(1, uniqueStates.Count);
    }

    [TestMethod]
    public void GetAggregateSortedListOfStatesUsingCsvRows_ReturnsListAsSingleString()
    {
        string uniqueStatesSorted = data.GetAggregateSortedListOfStatesUsingCsvRows();
        string[] testArray = uniqueStatesSorted.Split(',');
        int count = 0;
        bool sameElements = true;
        List<string> uniqueStates = data.GetUniqueSortedListOfStatesGivenCsvRows().ToList();

        foreach(string state in uniqueStates)
        {
            if (testArray[count] != state) sameElements = false;
            count++;
        }
        Assert.IsTrue(sameElements);
    }

    List<Address> spokaneAddresses = new List<Address> //Where to leverage this for #2 on assignment?
    {
        new Address("507 N Howard St", "Spokane", "WA", "99201"),     //River Front Park
        new Address("803 W Mallon Ave","Spokane", "WA", "99201"),     //David's Pizza
        new Address("1702 S Grand Blvd", "Spokane", "WA", "99203"),   //Manito Park
        new Address("101 W 8th Ave", "Spokane", "WA", "99204"),       //Sacred Heart Hospital
        new Address("601 E Riverside Ave", "Spokane", "WA", "99202"), //Catalyst Building
        new Address("916 W 2nd Ave", "Spokane", "WA", "99201"),       //Wild Sage Bistro
        new Address("501 W Park Pl", "Spokane", "WA", "99205"),       //Corbin Park
        new Address("1810 N Greene St", "Spokane", "WA", "99217")     //Spokane Community College
    };
}