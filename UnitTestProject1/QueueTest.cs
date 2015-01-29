using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;

namespace UnitTestProject1
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void Constructor()
        {
            var newQueue = new Queue();

            Assert.AreEqual(0, newQueue.Size);
        }

        [TestMethod]
        public void Add()
        {
            var newQueue = new Queue();

            newQueue.Add(123);

            Assert.AreEqual(123, newQueue.theQueue.Head.Content);
            Assert.AreEqual(1, newQueue.Size);
        }
        [TestMethod]
        public void Remove()
        {
            var newQueue = new Queue();

            newQueue.Add(123);
            newQueue.Add(456);
            Assert.AreEqual(2, newQueue.Size);
            Assert.AreEqual(123, newQueue.Remove());
            Assert.AreEqual(1, newQueue.Size);
        }
    }
}
