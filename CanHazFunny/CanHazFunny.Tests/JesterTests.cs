using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Diagnostics.Metrics;

namespace CanHazFunny.Tests;

[TestClass]
public class JesterTests
{
    private string testString = "";
    private Jester testJester = new();
    private JokeService jokeService = new();
    private FunnyOut jokeWriter = new();

    [TestInitialize]
    public void TestSetup()
    {
        TestCleanup();
        testJester = new(jokeService, jokeWriter);
    }

    [TestCleanup]
    public void TestCleanup()
    {
        testString = "";
        testJester = new();
        jokeService = new();
        jokeWriter = new();
    }

    [TestMethod]
    public void Jester_Contains_JokeService()
    {
        //Arrange

        //Act

        //Assert
        Assert.AreEqual<JokeService>(testJester.JokeService, jokeService);
    }

    [TestMethod]
    public void Jester_Contains_JokeWriter()
    {
        //Arrange

        //Act

        //Assert
        Assert.AreEqual<FunnyOut>(testJester.JokeWriter, jokeWriter);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Jester_GivenNullJokeService_ThrowsNullException()
    {
        //Arrange

        //Act
        testJester = new(null!, jokeWriter);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Jester_GivenNullJokeWriter_ThrowsNullException()
    {
        //Arrange
        JokeService jokeService = new();

        //Act
        testJester = new(jokeService, null!);
    }

    [TestMethod]
    public void Jester_GivenChuckNorrisJoke_ReturnTrue()
    {
        //Arrange
        testString = "Hi, I'm Chuck Norris";

        //Act

        //Assert
        Assert.IsTrue(((IJokeService)testJester.JokeService).CheckForChuckNorris(testString));
    }

    [TestMethod]
    public void Jester_GivenNotChuckNorrisJoke_ReturnFalse()
    {
        //Arrange
        testString = "Hi, I'm not that guy with all the jokes written about him";

        //Act

        //Assert
        Assert.IsFalse(((IJokeService)testJester.JokeService).CheckForChuckNorris(testString));
    }
}
