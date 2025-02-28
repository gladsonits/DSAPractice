using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAPractice
{
    class DefaultLinkedList
    {
        LinkedList<string> lndList = new LinkedList<string>();


        public void DoOperations()
        {
            LinkedList<int> l = new LinkedList<int>();

            // Adding elements to the LinkedList using AddLast()
            l.AddLast(10);
            l.AddLast(20);
            l.AddLast(30);
            l.AddLast(40);
            l.AddLast(50);
            l.AddFirst(20);

            l.Remove(20);

            LinkedListNode<int> newnode = new LinkedListNode<int>(60);
            Console.WriteLine("Contains new node:" + l.Contains(60));

            l.AddLast(newnode);
            l.Remove(newnode);

            Console.WriteLine("Contains:" + l.Contains(50));

            Console.WriteLine("List of numbers:");

            // Accessing and displaying the elements using
            // foreach loop
            foreach (int num in l) { Console.WriteLine(num); }


        }
        
    }
}
