using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleStack
{
    public class Stack<E>
    {
        int counter = 0;
        int maxSize;
        E[] datas;

        public Stack(int maxSize)
        {
            this.maxSize = maxSize;
            datas = new E[maxSize];
        }

        public E Push(E value)
        {
            if (counter >= maxSize)
            {
                throw new IndexOutOfRangeException("Stack is full!");
            }

            datas[counter] = value;
            ++counter;

            return value;
        }

        public E Pop()
        {
            if (counter - 1 < 0)
            {
                throw new IndexOutOfRangeException("Stack is empty!");
            }

            --counter;
            return datas[counter];
        }

        public E Peek()
        {
            if (counter - 1 < 0)
            {
                throw new IndexOutOfRangeException("Stack is empty!");
            }

            return datas[counter - 1];
        }

        public bool Empty()
        {
            return counter - 1 < 0;
        }
    }
}
