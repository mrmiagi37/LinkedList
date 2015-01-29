using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Queue
    {
        public int Size;
        public JoshsLinkedList theQueue = new JoshsLinkedList();
        public Queue()
        {
            Size = 0;
        }

        public void Add(object Content)
        {
            this.Size++;
            theQueue.Add(Content);
        }
        public object Remove()
        {
            this.Size--;
            var data = theQueue.Head.Content;
            theQueue.Delete(1);
            return data;
        }
    }
}
