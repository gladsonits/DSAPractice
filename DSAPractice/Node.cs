using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice
{
    public class Node
    {
        private object data;
        private Node next;

        public Node(object _data, Node _next)
        {
            this.data = _data;
            this.next = _next;
        }

        public object Data {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next=value; }
        }
    }
}
