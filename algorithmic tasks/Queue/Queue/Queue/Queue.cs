using System;

namespace Queue
{
    public class Queue<T>
    {
        private Node<T> _head;
        private Node<T> _tail;

        public void Enqueue(T value, bool isImportant = false)
        {
            Node<T> newNode = new Node<T>(value);

            if (_head == null)
            {
                _head = newNode;
                _tail = newNode;
                return;
            }

            if (isImportant)
            {
                Node<T> tmp = _head;
                _head = newNode;
                _head.NextNode = tmp;
                return;
            }

            _tail.NextNode = newNode;
            _tail = newNode;
        }

        public T Peek()
        {
            try
            {
                return _head.Value;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("Queue is empty!");
            }
        }

        public T DeQueue()
        {
            try
            {
                T result = _head.Value;
                _head = _head.NextNode;
                return result;
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("Queue is empty!");
            }
        }

        public int QueueSize()
        {
            int counter = 0;
            Node<T> currentNode = _head;
            if (currentNode == null)
            {
                return counter;
            }
            ++counter;

            while (currentNode.NextNode != null)
            {
                currentNode = currentNode.NextNode;
                ++counter;
            }

            return counter;
        }

        public bool IsEmpty()
        {
            return _head == null;
        }

        public override string ToString()
        {
            string result = "";
            Node<T> currentNode = _head;
            while (currentNode != null)
            {
                result += currentNode.Value + " ";
                currentNode = currentNode.NextNode;
            }
            return result == "" ? result : result[..^1];
        }
    }
}
