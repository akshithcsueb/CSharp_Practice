using System;

namespace CSharp_Practice.DSA.LinkedList
{
    public class DoublyLinkedList
    {
        private class Node
        {
            public Node Prev;
            public int Data;
            public Node Next;

            public Node(int data)
            {
                Prev = null;
                Data = data;
                Next = null;
            }
        }

        private Node head;

        public void Add(int data)
        {
            Node tempNode = new Node(data);

            if(head == null)
            {
                head = tempNode;
            }
            else
            {
                Node currentNode = head;

                while(currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                tempNode.Prev = currentNode;
                currentNode.Next = tempNode;
            }
        }

        public void Delete(int data)
        {
            if(head == null)
            {
                Console.WriteLine("Doubly Linked List is Empty - Nothing to Delete");
            }
            else
            {
                if(head.Data == data && head.Next != null)
                {
                    head = head.Next;
                    head.Prev = null;
                }
                else if(head.Data == data)
                {
                    head = head.Next;
                }
                else
                {
                    Node currentNode = head.Next;
                    Node previousNode = head;

                    while(currentNode != null)
                    {
                        if(currentNode.Data == data)
                        {
                            if(currentNode.Next == null)
                            {
                                previousNode.Next = null;
                                return;
                            }

                            previousNode.Next = currentNode.Next;
                            currentNode.Next.Prev = previousNode;
                            return;
                        }

                        previousNode = currentNode;
                        currentNode = currentNode.Next;
                    }

                    Console.WriteLine(data + " is not in the Doubly Linked List to Delete");
                }
            }
        }

        public void Search(int data)
        {
            if (head == null)
            {
                Console.WriteLine("Doubly Linked List is Empty - Nothing to Search");
            }
            else
            {
                Node currentNode = head;

                while(currentNode != null)
                {
                    if(currentNode.Data == data)
                    {
                        Console.WriteLine(data + " is in Doubly Linked List");
                        return;
                    }    

                    currentNode = currentNode.Next;
                }

                Console.WriteLine(data + " is not in Doubly Linked List");
            }
        }

        public void Display()
        {
            if(head == null)
            {
                Console.WriteLine("Doubly Linked List is empty - Nothing to Display");
            }
            else
            {
                Node currentNode = head;

                while(currentNode != null)
                {
                    Console.Write(currentNode.Data + " ");
                    currentNode = currentNode.Next;
                }

                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            DoublyLinkedList values = new DoublyLinkedList();

            values.Add(3);
            values.Add(1);
            values.Add(5);

            values.Display();

            values.Delete(3);
            values.Delete(1);
            values.Delete(5);

            values.Add(1);

            values.Display();
        }
    }
}
