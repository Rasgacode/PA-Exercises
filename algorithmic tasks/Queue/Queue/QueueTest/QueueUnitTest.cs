using Queue;
using System;
using Xunit;

namespace QueueTest
{
    public class QueueUnitTest
    {
        private readonly Queue<int> _queue;

        public QueueUnitTest()
        {
            _queue = new Queue<int>();
            _queue.Enqueue(10);
            _queue.Enqueue(6);
            _queue.Enqueue(5);
            _queue.Enqueue(4);
            _queue.Enqueue(3);
            _queue.Enqueue(2);
            _queue.Enqueue(101, true);
            _queue.Enqueue(15);
        }

        [Fact]
        public void EnqueueCase()
        {
            Assert.Equal("101 10 6 5 4 3 2 15", _queue.ToString());
        }

        [Fact]
        public void PeekCase()
        {
            Assert.Equal(101, _queue.Peek());
        }

        [Fact]
        public void PeekEmptyCase()
        {
            Queue<string> tempQue = new Queue<string>();
            Exception e = Assert.Throws<NullReferenceException>(() => tempQue.Peek());
            Assert.Equal("Queue is empty!", e.Message);
        }

        [Fact]
        public void DeQueueCase()
        {
            _queue.Enqueue(200, true);
            Assert.Equal(200, _queue.DeQueue());
        }

        [Fact]
        public void DeQueueEmptyCase()
        {
            Queue<string> tempQue = new Queue<string>();
            Exception e = Assert.Throws<NullReferenceException>(() => tempQue.DeQueue());
            Assert.Equal("Queue is empty!", e.Message);
        }

        [Fact]
        public void QueueSizeCase()
        {
            Assert.Equal(8, _queue.QueueSize());
        }

        [Fact]
        public void IsEmptyCase()
        {
            Assert.False(_queue.IsEmpty());
        }
    }
}
