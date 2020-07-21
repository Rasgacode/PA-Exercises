using System;
using System.Collections.Generic;
using System.Text;

namespace Heap
{
    public class MinIntHeap
    {
        private int _capacity;
        private int _size;
        public int[] Items { get; }

        public MinIntHeap()
        {
            _capacity = 10;
            _size = 0;
            Items = new int[_capacity];
        }

        private int getLeftChildIndex(int parentIndex) { return 2 * parentIndex + 1; }
        private int getRightChildIndex(int parentIndex) { return 2 * parentIndex + 2; }
        private int getParentIndex(int childIndex) { return (childIndex - 1) / 2; }
        private int leftChild(int index) { return Items[getLeftChildIndex(index)]; }
        private int rightChild(int index) { return Items[getRightChildIndex(index)]; }
        private int parent(int index) { return Items[getParentIndex(index)]; }
        private bool hasLeftChildren(int index) { return getLeftChildIndex(index) < _size; }
        private bool hasRightChildren(int index) { return getRightChildIndex(index) < _size; }
        private bool hasParent(int index) { return getParentIndex(index) >= 0; }

        private void swap(int indexOne, int indexTwo)
        {
            int tmp = Items[indexOne];
            Items[indexOne] = Items[indexTwo];
            Items[indexTwo] = tmp;
        }

        private void ensureExtraCapacity()
        {
            if (_size == _capacity)
            {
                Array.Copy(Items, Items, _capacity * 2);
                _capacity *= 2;
            }
        }

        private void heapifyUp()
        {
            int index = _size - 1;
            while (hasParent(index) && parent(index) > Items[index])
            {
                swap(getParentIndex(index), index);
                index = getParentIndex(index);
            }
        }

        private void heapifyDown()
        {
            int index = 0;
            while (hasLeftChildren(index))
            {
                int smallerChildIndex = getLeftChildIndex(index);
                if (hasRightChildren(index) && rightChild(index) < leftChild(index))
                {
                    smallerChildIndex = getRightChildIndex(index);
                }

                if (Items[index] < Items[smallerChildIndex])
                {
                    break;
                }
                else swap(index, smallerChildIndex);
                index = smallerChildIndex;
            }
        }

        public int Peek()
        {
            if (_size == 0) throw new IndexOutOfRangeException();
            return Items[0];
        }

        public int Poll()
        {
            if (_size == 0) throw new IndexOutOfRangeException();
            int item = Items[0];
            Items[0] = Items[_size - 1];
            --_size;
            heapifyDown();
            return item;
        }

        public void Add(int item)
        {
            ensureExtraCapacity();
            Items[_size] = item;
            ++_size;
            heapifyUp();
        }
    }
}
