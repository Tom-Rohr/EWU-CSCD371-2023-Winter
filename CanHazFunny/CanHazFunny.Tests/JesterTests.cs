using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
namespace CanHazFunny.Tests;

[TestClass]
public class JesterTests
{
    private string testString = "";
    private Jester testJester = new();
    [ClassInitialize]
    public void TestSetup(TestContext testcontext)
    {
        TestCleanup();

        var mockJokeService = new Mock<JokeService>();
        FunnyOut jokeWriter = new(); 

        mockJokeService.Setup(x => x.GetJoke()).Returns(testString);
        testJester = new(mockJokeService.Object, jokeWriter);
    }
    [TestCleanup]
    public void TestCleanup() 
    {
        testString = "";
        testJester = new();
    }

    /*[TestMethod]
    public void Jester_Contains_JokeService()
    {
        //Arrange

        //Act

        //Assert
    }*/
}
