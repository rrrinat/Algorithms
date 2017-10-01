using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListApp
{
    class LinkedListApp
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();

            linkedList.AddFirst(22);
            linkedList.AddFirst(44);
            linkedList.AddFirst(66);
            linkedList.AddFirst(88);

            linkedList.Display();

            while (!linkedList.IsEmpty())
            {
                Node node = linkedList.RemoveFirst();
                node.Display();
            }

            Console.ReadLine();
        }
    }
}
