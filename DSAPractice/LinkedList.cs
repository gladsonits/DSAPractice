using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice
{
    public class LinkedList
    {
        private Node head;
        private int size;

        public LinkedList()
        {
            head = null;
            size = 0;
        }

        public bool Empty {
            get { return size == 0; }
        }

        public int Count
        {
            get { return this.size; }

        }
    }
}
