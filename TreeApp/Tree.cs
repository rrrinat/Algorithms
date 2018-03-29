using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeApp
{
    class Tree
    {
        private Node root;

        public Tree()
        {
            root = null;
        }

        public Node Find(int key)
        {
            Node current = root;
            while (current.data != key)
            {
                if (key < current.data)
                {
                    current = current.leftChild;
                }
                else
                {
                    current = current.rightChild;
                }

                if (current == null)
                {
                    return null;
                }
            }

            return current;
        }

        public void Insert(int data)
        {
            Node node = new Node(data);

            if (root == null)
            {
                root = node;

                return;
            }

            Node current = root;
            Node parent;

            while (true)
            {
                parent = current;
                if (data < current.data)
                {
                    current = current.leftChild;
                    if (current == null)
                    {
                        parent.leftChild = node;

                        return;
                    }
                }
                else
                {
                    current = current.rightChild;
                    if (current == null)
                    {
                        parent.rightChild = node;

                        return;
                    }
                }
            }
        }

    }
}
