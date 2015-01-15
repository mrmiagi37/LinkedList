using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;


namespace UnitTestProject1
{
    [TestClass]
    public class NodeTest
    {
        [TestMethod]
        public void ContentProperty()
        {
            var node = new Node();
            node.Content = 5;
            Assert.AreEqual(5, node.Content);
        }

        [TestMethod]
        public void NextProperty() 
        {
            var node = new Node();
            var nextNode = new Node();
            node.Next = nextNode;
            Assert.AreEqual(node.Next, nextNode);
        }
    }
}
