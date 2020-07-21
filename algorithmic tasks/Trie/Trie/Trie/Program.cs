using System;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keys = {"the", "a", "there", "answer",
                        "any", "by", "bye", "their"};

            string[] output = { "Not present in trie", "Present in trie" };

            Trie trie = new Trie();
            trie.root = new TrieNode();

            for (int i = 0; i < keys.Length; i++) trie.insert(keys[i]);

            if (trie.search("the") == true)
                Console.WriteLine("the --- " + output[1]);
            else Console.WriteLine("the --- " + output[0]);

            if (trie.search("these") == true)
                Console.WriteLine("these --- " + output[1]);
            else Console.WriteLine("these --- " + output[0]);

            if (trie.search("their") == true)
                Console.WriteLine("their --- " + output[1]);
            else Console.WriteLine("their --- " + output[0]);

            if (trie.search("thaw") == true)
                Console.WriteLine("thaw --- " + output[1]);
            else Console.WriteLine("thaw --- " + output[0]);
        }
    }
}
