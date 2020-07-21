using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    public class Node<T>
    {
        public T Value { get; }
        public Node<T> NextNode { get; set; }

        public Node(T value)
        {
            Value = value;
        }
    }
}
