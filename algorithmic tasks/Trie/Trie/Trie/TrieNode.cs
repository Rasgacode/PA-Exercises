using System;
using System.Collections.Generic;
using System.Text;

namespace Trie
{
    public class TrieNode
    {
        static readonly int ALPHABET_SIZE = 26;
        public TrieNode[] children = new TrieNode[ALPHABET_SIZE];
        public bool isEndOfWord = false;

        public TrieNode()
        {
            for (int i = 0; i < ALPHABET_SIZE; i++) children[i] = null;
        }
    }
}
