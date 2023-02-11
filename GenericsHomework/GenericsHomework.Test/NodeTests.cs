namespace GenericsHomework.Test;

[TestClass]
public class NodeTests
{
    [TestMethod]
    public void Node_ToString_works()
    {
        Node<string> node = new("I hope this works...");
        Assert.AreEqual(node.ToString(), "I hope this works...");
    }
}