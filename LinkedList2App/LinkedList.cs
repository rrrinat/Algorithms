using System;

namespace LinkedList2App
{
    class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            return (head == null);
        }

        public void AddFirst(int data)
        {
            Node node = new Node(data);
            node.next = this.head;  //старый head мы делаем next'ом
            this.head = node;       //текущий элемент мы делаем head'ом
        }

        public Node Find(int key)
        {
            Node current = head;
            while(current.data != key)
            {
                if (current.next == null)
                {
                    return null;
                }
                current = current.next;
            }

            return current;
        }

        public Node Delete(int key)
        {
            Node current = head;
            Node previous = head;
            while (current.data != key)
            {
                if (current.next == null)
                {
                    return null;
                }
                previous = current;
                current = current.next;
            }

            if (current == head)
            {
                head = head.next;
            }
            else
            {
                previous.next = current.next;
            }

            return current;
        }

        public Node RemoveFirst()
        {
            Node temp = head;
            head = head.next;

            return temp;
        }

        public void Display()
        {
            Console.WriteLine("Node (head -> last): ");
            Node current = head;
            while (current != null)
            {
                current.Display();
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
