using System;

namespace CSharp_Practice.DSA.LinkedList
{
    public class SinglyLinkedList
    {
        private class Node
        {
            public int Data;
            public Node Next;

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node head;

        public void Add(int data)
        {
            Node temp = new Node(data);

            if (head == null)
            {
                head = temp;
            }
            else
            {
                Node current = head;

                while(current.Next != null)
                {
                    current = current.Next;
                }

                current.Next = temp;
            }
        }

        public void Delete(int data)
        {
            if(head == null)
            {
                Console.WriteLine("Singly Linked List is empty - Nothing to Delete");
            }
            else
            {
                if(head.Data == data)
                {
                    head = head.Next;
                }
                else
                {
                    Node current = head.Next;
                    Node prev = head;

                    while(current != null)
                    {
                        if(current.Data == data)
                        {
                            prev.Next = current.Next;
                            return;
                        }
                        else if(current.Next == null)
                        {
                            Console.WriteLine("The Singly Linked List doesn't contain " + data + " to Delete");
                        }

                        prev = current;
                        current = current.Next;
                    }
                }
            }
        }

        public void Search(int data)
        {
            if(head == null)
            {
                Console.WriteLine("Singly Linked List is empty - Nothing to search");
            }
            else
            {
                Node current = head;

                while(current != null)
                {
                    if(current.Data == data)
                    {
                        Console.WriteLine(data + " is in Singly Linked List");
                        return;
                    }
                    else if(current.Next == null)
                    {
                        Console.WriteLine(data + " is not in Singly Linked List");
                    }

                    current = current.Next;
                }
            }
        }

        public void Display()
        {
            if(head == null)
            {
                Console.WriteLine("Singly Linked List is empty - Nothing to Display");
            }
            else
            {
                Node current = head;

                while(current != null)
                {
                    Console.Write(current.Data + " ");
                    current = current.Next;
                }

                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            SinglyLinkedList values = new SinglyLinkedList();

            values.Add(3);
            values.Add(1);
            values.Add(5);

            values.Display();

            values.Search(51);
        }
    }
}
