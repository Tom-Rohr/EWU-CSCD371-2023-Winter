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

    [TestMethod]
    public void Node_AppendsNewNode_Success()
    {
        Node<int> list = new(1);
        list.Append(2);

        Assert.AreEqual(list.Next.Value, 2);
    }

    [TestMethod]
    public void Node_ListHeadPointsToTail_True() 
    { 
        Node<string> list = new("First node");
        list.Append("Second node");
        list.Append("Third node");
        list.Append("Fourth node");

        Assert.AreEqual("Fourth node", list.Next.Value);
    }

    [TestMethod]
    public void Node_IdentifiesEntries_True()
    {
        Node<string> list = new("First node");
        list.Append("Second node");
        list.Append("Third node");
        list.Append("Fourth node");

        Assert.IsTrue(list.Exists("Second node"));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Node_PreventsDuplicateEntries_True()
    {
        Node<string> firstNode = new("First node");
        firstNode.Append("Second node");
        firstNode.Append("Third node");
        firstNode.Append("Fourth node");

        firstNode.Append("Fourth node");
    }
}