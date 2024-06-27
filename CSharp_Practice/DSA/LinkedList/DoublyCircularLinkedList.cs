using System;

namespace CSharp_Practice.DSA.LinkedList
{
    public class DoublyCircularLinkedList
    {
        private class Node
        {
            public Node Prev;
            public int Data;
            public Node Next;

            public Node(int data)
            {
                Data = data;
            }
        }

        private Node head;
        private Node tail;

        public void Add(int data)
        {
            Node tempNode = new Node(data);

            if (head == null)
            {
                head = tempNode;
                tempNode.Next = tempNode;
                tail = tempNode;
            }
            else
            {
                Node currentNode = tail;
                currentNode.Next = tempNode;
                tempNode.Prev = currentNode;
                tempNode.Next = head;
                tail = tempNode;
            }
        }

        public void Delete(int data)
        {
            if(head == null)
            {
                Console.WriteLine("Doubly Circulat Linked List is Empty - Nothing to Delete");
            }
            else
            {
                if(head.Data == data && head == tail)
                {
                    head = null;
                    tail = null;
                }
                else if(head.Data == data)
                {
                    head = head.Next;
                    tail.Next = head;
                    head.Prev = null;
                }
                else
                {
                    Node currentNode = head.Next;
                    Node previousNode = head;

                    while(true)
                    {
                        if (currentNode.Data == data && currentNode == tail)
                        {
                            previousNode.Next = currentNode.Next;
                            tail = previousNode;
                            return;
                        }
                        else if (currentNode.Data == data)
                        {
                            previousNode.Next = currentNode.Next;
                            currentNode.Next.Prev = previousNode;
                            return;
                        }
                        else if (currentNode == tail)
                        {
                            Console.WriteLine(data + " is not in Doubly Circular Linked List");
                            return;
                        }

                        previousNode = currentNode;
                        currentNode = currentNode.Next;
                    }
                }
            }
        }

        public void Search(int data)
        {
            if(head == null)
            {
                Console.WriteLine("Doubly Circular Linked List is Empty - Nothing to Search");
            }
            else
            {
                Node currentNode = head;

                while(true)
                {
                    if(currentNode.Data == data)
                    {
                        Console.WriteLine(data + " is in Doubly Circular Linked List");
                        return;
                    }

                    if(currentNode == tail)
                    {
                        Console.WriteLine(data + " is not in Doubly Circular Linked List");
                        return;
                    }

                    currentNode = currentNode.Next;
                }
            }
        }

        public void Display()
        {
            if(head == null)
            {
                Console.WriteLine("Doubly Circular Linked List is Empty - Nothing to Display");
            }
            else
            {
                Node currentNode = head;

                while(true)
                {
                    Console.Write(currentNode.Data + " ");

                    if(currentNode == tail)
                    {
                        Console.WriteLine();
                        return;
                    }

                    currentNode = currentNode.Next;
                }
            }
        }

        public static void Main(string[] args)
        {
            DoublyCircularLinkedList values = new DoublyCircularLinkedList();

            values.Add(3);
            values.Add(1);
            values.Add(5);

            values.Display();

            values.Search(5);
        }
    }
}
