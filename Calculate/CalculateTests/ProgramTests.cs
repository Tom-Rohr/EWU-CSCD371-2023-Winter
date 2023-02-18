using Calculate;

namespace CalculateTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Program_SetsAndInvokesProperties_Success()
        {
            void testActionWriteLine(string testLine) { }
            void testActionReadLine(string testLine) { }

            Program program = new() { WriteLine = testActionWriteLine, ReadLine = testActionReadLine };

            Assert.IsNotNull(program.WriteLine);
            Assert.IsNotNull(program.ReadLine);

        }
    }
}