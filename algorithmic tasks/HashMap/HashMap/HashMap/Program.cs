using System;

namespace HashMap
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHashMap<string, int> lol = new MyHashMap<string, int>();
            lol.Put("lol", 1322342);
            Console.WriteLine(lol.Get("lol"));
        }
    }
}
