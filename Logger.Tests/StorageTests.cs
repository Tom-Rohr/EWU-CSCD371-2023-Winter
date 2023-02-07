using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logger.Tests;

[TestClass]
public class StorageTests
{
    Storage testStorage = new();
    Employee genericEmployee = new(42, new FullName(FirstName: "John", LastName: "Smith", MiddleName: "Middleton"));

    Person testPerson = new(new FullName(FirstName: "PersonFirst", LastName: "PersonLast", MiddleName: "PersonMiddle"));
    Student testStudent = new(SID: 1, new FullName(FirstName: "StudentFirstName", LastName: "StudentLastName", MiddleName: "StudentMiddleName"));
    Employee testEmployee = new(EID: 1, new FullName(FirstName: "StudentFirstName", LastName: "StudentLastName", MiddleName: "StudentMiddleName"));
    Book testBook = new(Title: "Test Book Tile", Author: new FullName("AuthorFirst", "AuthorLast", "AuthorMiddle"), YearPublished: 2000);

    [TestInitialize]
    public void TestSetup()
    {
        TestCleanup();
        Storage testStorage = new();
    }

    [TestCleanup]
    public void TestCleanup()
    {
        Storage testStorage = new();
    }

    [TestMethod]
    public void Storage_AddsAndRemovesPerson_Success()
    {
        testStorage.Add(testPerson);
        Assert.IsTrue(testStorage.Contains(testPerson));
        testStorage.Remove(testPerson);
        Assert.IsFalse(testStorage.Contains(testPerson));
    }

    [TestMethod]
    public void Storage_AddsAndRemovesStudent_Success()
    {
        testStorage.Add(testStudent);
        Assert.IsTrue(testStorage.Contains(testStudent));
        testStorage.Remove(testStudent);
        Assert.IsFalse(testStorage.Contains(testStudent));
    }

    [TestMethod]
    public void Storage_AddsAndRemovesEmployee_Success()
    {
        testStorage.Add(testEmployee);
        Assert.IsTrue(testStorage.Contains(testEmployee));
        testStorage.Remove(testEmployee);
        Assert.IsFalse(testStorage.Contains(testEmployee));
    }

    [TestMethod]
    public void Storage_AddsAndRemovesBook_Success()
    {
        testStorage.Add(testBook);
        Assert.IsTrue(testStorage.Contains(testBook));
        testStorage.Remove(testBook);
        Assert.IsFalse(testStorage.Contains(testBook));
    }

    [TestMethod]
    public void Storage_GetItemWithGuid()
    {
        Guid expectedGuid = testPerson.Id;
        testStorage.Add(testPerson);
        Person? newPerson = testStorage.Get(expectedGuid) as Person;

        Assert.AreEqual(testPerson, newPerson);
    }
}
