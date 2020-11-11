using Microsoft.VisualBasic;
using System;
using System.Collections;

namespace SingleLinkedList
{
    public class List<T>
    {
        private Node<T> head;
        private Node<T> tale;
        private int size;

        public int Size { get { return size; } }
        public T Head { get { return head.data; } }
        public T Tale { get { return tale.data; } }
        public List() { }

        public List(params T[] data)
        {
            Node<T> node = null;
            foreach (T x in data)
            {
                size += 1;
                if (head == null)
                {
                    head = new Node<T>(x);
                    node = head;
                    continue;
                }
                node.next = new Node<T>(x);
                node = node.next;
            }
            tale = node;
        }

        public void Add(T data)
        {
            Node<T> n = new Node<T>(data, head);
            if (head == null) { tale = n; }
            head = n;
            size += 1;
        }

        public bool Search(T data)
        {
            if (head == null) return false;
            Node<T> n = head;
            while (true)
            {
                if (n.data.Equals(data)) return true;
                if (n.next == null) return false;
                n = n.next;
            }
        }

        public void Remove(T data)
        {
            if (head == null) return;
            Node<T> n = head;
            while (true)
            {
                if (n.next == null) return;
                if (n.next.data.Equals(data))
                {

                    n.next = n.next.next;
                    if (n.next == null)
                    {
                        tale = n;
                    }
                    size -= 1;
                    return;
                }
                n = n.next;
            }
        }

        public void Append(T data)
        {
            if (head == null)
            {
                Add(data);
                return;
            }
            Node<T> n = new Node<T>(data);
            tale.next = n;
            tale = tale.next;
            size += 1;
        }

        public T Pop()
        {
            Node<T> n = head;
            Node<T> prev = null;
            if (n == null) return default(T);
            while (n.next != null)
            {
                prev = n;
                n = n.next;
            }
            if(prev != null)
            prev.next = null;
            if (prev != null)
            {
                tale = prev;
            }
            size -= 1;
            return n.data;
        }

        public T Shift()
        {
            Node<T> n = head;
            head = head.next;
            size -= 1;
            return n.data;
        }

        public void Insert(int index, T data)
        {

            if (index > Size)
            {
                throw new IndexOutOfRangeException("Index was outside the bounds of the List.");
            }
            Node<T> n = head;
            Node<T> insert = new Node<T>(data, n.next);
            if (index == 0)
            {
                head = insert;
            }
            for (int i = 0; i < index - 1; i++)
            {
                n = n.next;
            }
            n.next = insert;
            size += 1;
        }

        public int Find(T data)
        {
            if (head == null) return -1;
            Node<T> n = head;
            int c = 0;
            while (true)
            {
                if (n.data.Equals(data)) return c;
                if (n.next == null) return -1;
                n = n.next;
                c += 1;
            }
        }

        public T Select(int index)
        {
            if (index >= Size)
            {
                throw new IndexOutOfRangeException("Index was outside the bounds of the List.");
            }
            Node<T> n = head;
            for (int i = 0; i < index; i++)
            {
                n = n.next;
            }
            return n.data;
        }

        public void Clear()
        {
            head = null;
            size = 0;
        }

        public override string ToString()
        {
            if (head == null) return "[]";
            Node<T> n = head;
            string str = "[";
            while (true)
            {
                str += n.data.ToString();
                if (n.next == null) break;
                str += ", ";
                n = n.next;
            }
            str += "]";
            return str;
        }

        public IEnumerator GetEnumerator()
        {
            Node<T> n = head;
            while (n != null)
            {
                T val = n.data;
                n = n.next;
                yield return val;
            }
        }

        private class Node<nT>
        {
            public nT data;
            public Node<nT> next;

            public Node(nT data)
            {
                this.data = data;
            }

            public Node(nT data, Node<nT> next)
            {
                this.data = data;
                this.next = next;
            }
        }
    }
}