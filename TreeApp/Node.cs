using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeApp
{
    class Node
    {
        public int data;
        public Node leftChild;
        public Node rightChild;

        public Node(int data)
        {
            this.data = data;
        }

        public void Display()
        {
            Console.WriteLine("data = {0}", this.data);
        }
    }
}
