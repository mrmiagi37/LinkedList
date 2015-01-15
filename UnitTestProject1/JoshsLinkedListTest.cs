using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;

namespace UnitTestProject1
{
    [TestClass]
    public class JoshsLinkedListTest
    {
        [TestMethod]
        public void Constructor()
        {
            var list = new JoshsLinkedList();

            Assert.AreEqual(0, list.Size);
        }
        [TestMethod]
        public void Add() 
        {
            var list = new JoshsLinkedList();
            list.Add(123);

            Assert.AreEqual(1, list.Size);
            Assert.AreEqual(123, list.Tail.Content); 
        }
        [TestMethod]
        public void Search()
        {
            var list = new JoshsLinkedList();
            list.Add(123);
            list.Add(456);

            Assert.AreEqual(2, list.Size);
            Assert.AreEqual(123, list.Head.Content);
            Assert.AreEqual(456, list.Tail.Content);
            Assert.AreEqual(0, list.SearchList(123));
            Assert.AreEqual(1, list.SearchList(456));
        }

        [TestMethod]
        public void DeleteFirst()
        {
            var list = new JoshsLinkedList();
            list.Add(123);
            list.Add(456);
            list.Add(789);

            list.Delete(1);

            Assert.AreEqual(789, list.Tail.Content);
            Assert.AreEqual(2, list.Size);
            Assert.AreEqual(456, list.Head.Content);
        }
        [TestMethod]
        public void DeleteLast()
        {
            var list = new JoshsLinkedList();
            list.Add(123);
            list.Add(456);
            list.Add(789);
            list.Delete(3);

            Assert.AreEqual(123, list.Head.Content);
            Assert.AreEqual(2, list.Size);
            Assert.AreEqual(456, list.Tail.Content);
        }

        [TestMethod]
        public void Delete()
        {
            var list = new JoshsLinkedList();
            list.Add(123);
            list.Add(456);
            list.Add(789);
            list.Delete(2);

            Assert.AreEqual(2, list.Size);
            Assert.AreEqual(789, list.Head.Next.Content);
            Assert.AreEqual(789, list.Tail.Content);
            Assert.AreEqual(123, list.Head.Content);
        }
    }
}
