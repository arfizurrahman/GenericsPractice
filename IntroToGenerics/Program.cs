using System;
using System.Collections.Generic;

namespace IntroToGenerics
{
    //type parameter T in angle brackets
    public class GenericList<T>
    {
        // The nested class is also generic on T
        private class Node
        {
            

            // Getter, Setter
            public Node Next
            {
                get { return next; }
                set { next = value;  }
            }
            private Node next;
            // T as private member data type.
            private T data;

            // T as return type of property
            public T Data
            {
                get { return data; }
                set { data = value; }
            }
            // T is used in non-generic constructor
            public Node(T t)
            {
                next = null;
                data = t;
            }
        }

        private Node head;

        // Constructor
        public GenericList()
        {
            head = null;
        }

        // T as method parameter type:
        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // int is the type argument
            GenericList<int> list = new GenericList<int>();

            for (int i = 0; i < 10; i++)
            {
                list.AddHead(i);
            }

            foreach (int i in list)
            {
                Console.Write(i + "");
            }

            Console.WriteLine("\nDone");
            Console.ReadKey();
        }
    }
}
