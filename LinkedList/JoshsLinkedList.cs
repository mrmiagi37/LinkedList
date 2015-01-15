using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class JoshsLinkedList
    {
        public Node Head;
        public Node Tail;
        public int Size;
        public JoshsLinkedList()
        {
            Head = null;
            Size = 0;
        }
        public void Add(object Content)
        {
            this.Size++;
            var newNode = new Node();
            newNode.Content = Content;
            if (this.Head == null)
            {
                this.Head = newNode;
            }
            else
            {
                this.Tail.Next = newNode;
            }
            this.Tail = newNode;
        }
        public void Delete(int nodePosition)
        {
            if (nodePosition == 1)
            {
                this.Head = this.Head.Next;
                this.Size--;
            }
            if (nodePosition > 1 && nodePosition <= this.Size)
            {
                Node tempNode = this.Head;
                Node prevNode = null;
                for (int count = 0; count < nodePosition; count++)
                {
                    if (count == nodePosition - 1)
                    {
                        prevNode.Next = tempNode.Next;
                        if (nodePosition == this.Size)
                        {
                            this.Tail = prevNode;
                        }
                        this.Size--;


                    }
                    prevNode = tempNode;
                    tempNode = tempNode.Next;
                }
            }
        }
        public int SearchList(object Content)
        {
            var tempNode = new Node();
            tempNode = this.Head;
            for (int position = 0; position < this.Size; position++)
            {
                if (tempNode.Content.Equals(Content))
                {
                    return position;
                }
                tempNode = tempNode.Next;
            }
            return -1;
        }

    }
}
