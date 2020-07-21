using System;

namespace Heap
{
    class Program
    {
        static void Main(string[] args)
        {
            MinIntHeap lol = new MinIntHeap();
            lol.Add(123);
            lol.Add(13);
            lol.Add(153);
            lol.Add(34);
            lol.Add(23);
            lol.Add(53);
            lol.Add(1003);
            lol.Add(45);
            lol.Add(4);
            lol.Add(1);

            foreach (var item in lol.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
