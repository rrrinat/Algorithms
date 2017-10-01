using System;

namespace LinkedListApp
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
