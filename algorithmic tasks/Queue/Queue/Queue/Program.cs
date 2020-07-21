using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> lol = new Queue<int>();
            lol.Enqueue(20);
            lol.Enqueue(12, true);
            Console.WriteLine(lol.DeQueue());
        }
    }
}
