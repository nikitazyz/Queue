using System;
using System.Text;
using SingleLinkedList;

namespace Queue
{
    class Queue<T>
    {
        private List<T> queue = new List<T>();

        public int Size { get { return queue.Size; } }
        
        public void Enque(T data)
        {
            queue.Add(data);
        }

        public T Deque()
        {
            return queue.Pop();
        }

        public T Rear()
        {
            return queue.Head;
        }
        public T Front()
        {
            return queue.Tale;
        }

        public bool isEmpty()
        {
            return Size == 0;
        }

        public void Clear()
        {
            queue.Clear();
        }
    }
}
