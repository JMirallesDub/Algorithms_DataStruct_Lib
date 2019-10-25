using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    public class DoubleLinkedList<T>
    {
        public DoublyLinkedNode<T> Head { get; internal set; }
        public DoublyLinkedNode<T> Tail { get; internal set; }
        public bool IsEmpty => Count == 0;
        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            AddFirst(new DoublyLinkedNode<T>(value));
        }

        private void AddFirst(DoublyLinkedNode<T> node)
        {
            //save off the Head
            DoublyLinkedNode<T> temp = Head;

            //point Head to node
            Head = node;

            //insert the rest of the list after the head
            Head.Next = temp;

            if (IsEmpty)
            {
                Tail = Head;
            }
            else
            {
                temp.Previous = Head;
            }
            Count++;
        }

        public void AddLast(T value)
        {
            AddLast(new DoublyLinkedNode<T>(value));
        }

        private void AddLast(DoublyLinkedNode<T> node)
        {
            if (IsEmpty)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
            }
            Tail = node;

            Count++;
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }

            Head = Head.Next;

            Count--;

            if (IsEmpty)
            {
                Tail = null;
            }
            else
            {
                Head.Previous = null;
            }
        }

        public void RemoveLast()
        {
            if (IsEmpty)
            {
                throw new InvalidOperationException();
            }

            if (Count == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail.Previous.Next = null; //null the lat node
                Tail = Tail.Previous; //shift the Tail (now it is the former penultimate node)
            }

            Count--;
        }
    }
}
