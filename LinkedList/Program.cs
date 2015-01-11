using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class JoshsLinkedList
    {
        static void Main(string[] args)
        {
        }
        public class Node
        {
            public object Content;
            public Node Next;
        }
        private Node Head;
        private Node Tail;
        private int Size;
        public JoshsLinkedList() 
        {
            Head = null;
            Size = 0;
        }
        public void Add(object Content)
        {
            Size++;
            var newNode = new Node();
            newNode.Content = Content;
            if (Head == null)
            {
                Head = newNode;
            }
            else {
                Tail.Next = newNode;
            }
            Tail = newNode;
        }
        public void Delete(int nodePosition) {
            if (nodePosition == 1) {
                Head = Head.Next;
            }
            if (nodePosition > 1 && nodePosition <= Size) { 
                Node tempNode = Head;
                Node prevNode = null;
                for (int count = 0; count <nodePosition;count++){
                    if (count == nodePosition - 1) {
                        prevNode.Next = tempNode.Next;
                    }
                    prevNode = tempNode;
                    tempNode = tempNode.Next;
                }
            }
        }
        public int SearchList(object Content) {
            Node tempNode = Head;
            for (int position = 1; position <= Size; position++)
            {
                if (tempNode.Content == Content)
                {
                    return position;
                }
                tempNode = tempNode.Next;
            }
            return 0;
        }

    }
}
