using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace CanHazFunny.Tests;

[TestClass]
public class JesterTests
{
    private string testString = "";
    private Jester testJester = new();
    private IJokeService jokeService = new JokeService();
    private IFunnyOut jokeWriter = new FunnyOut();

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
    }

    [TestMethod]
    public void Jester_Contains_JokeService()
    {
        //Arrange

        //Act

        //Assert
        Assert.AreEqual<IJokeService>(testJester.JokeService, jokeService);
    }

    [TestMethod]
    public void Jester_Contains_JokeWriter()
    {
        //Arrange

        //Act

        //Assert
        Assert.AreEqual<IFunnyOut>(testJester.JokeWriter, jokeWriter);
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
        Assert.IsTrue(testJester.CheckForChuckNorris(testString));
    }

    [TestMethod]
    public void Jester_TellJoke_SkipsChuckNorris()
    {
        //Arrange
        var mockService = new Mock<IJokeService>();
        mockService.SetupSequence(x => x.GetJoke())
            .Returns("Chuck Norris")
            .Returns("test");
        IJokeService jokeService = mockService.Object;

        var mockWriter = new Mock<IFunnyOut>();
        mockWriter.Setup(x => x.PrintJokeToConsole("test")).Verifiable();
        IFunnyOut jokeWriter = mockWriter.Object;

        Jester jester = new(jokeService, jokeWriter);

        //Act
        jester.TellJoke();

        //Assert
        mockWriter.Verify(x => x.PrintJokeToConsole("test"), Times.Once);
    }
}
