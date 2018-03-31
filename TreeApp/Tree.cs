using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeApp
{
    class Tree
    {
        private enum Child
        {
            Left,
            Right
        }

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

        public bool Delete(int key)
        {
            Node current = root;
            Node parent = root;

            var child = Child.Left;
            
            //looking for node
            while(current.data != key)
            {
                parent = current;
                if (key < current.data)
                {
                    child = Child.Left;
                    current = current.leftChild;
                }
                else
                {
                    child = Child.Right;
                    current = current.rightChild;
                }

                if (current == null)
                {
                    return false;
                }
            }

            //if we found node!
            //если у искомого узла нет потомков то просто удаляем его
            if (current.leftChild == null && current.rightChild == null)
            {
                if (current == root)
                {
                    root = null;                
                }
                else if (child.Equals(Child.Left))
                {
                    parent.leftChild = null;
                }
                else
                {
                    parent.rightChild = null;
                }
            }

            //если нет правого потомка, то узел заменяется левым поддеревом
            else if (current.rightChild == null)
            {
                if (current == root)
                {
                    root = current.leftChild;
                }
                else if (child.Equals(Child.Left))
                {
                    parent.leftChild = current.leftChild;
                }
                else
                {
                    parent.rightChild = current.leftChild;
                }
            }

            //если нет левого потомка, то узел заменяется правым поддеревом
            else if (current.leftChild == null)
            {
                if (current == root)
                {
                    root = current.rightChild;
                }
                else if (child.Equals(Child.Left))
                {
                    parent.leftChild = current.rightChild;
                }
                else
                {
                    parent.rightChild = current.rightChild;
                }
            }

            //если имеется 2 потомка, то узел заменяется преемником
            else
            {

            }
        }

        private Node GetSuccessor(Node deleteNode)
        {
            Node successorParent = deleteNode;
            Node successor = deleteNode;


            Node current = deleteNode.rightChild;


        }
        //
    }
}
