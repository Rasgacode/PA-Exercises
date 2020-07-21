using System;
using System.Collections.Generic;
using System.Text;

namespace Trie
{
    public class Trie
    {
        public TrieNode root;

        public void insert(string key)
        {
            TrieNode pCrawl = root;

            for (int level = 0; level < key.Length; ++level)
            {
                int index = key[level] - 'a';
                if (pCrawl.children[index] == null)
                {
                    pCrawl.children[index] = new TrieNode();
                }
                pCrawl = pCrawl.children[index];
            }

            pCrawl.isEndOfWord = true;
        }

        public bool search(string key)
        {
            TrieNode pCrawl = root;

            for (int level = 0; level < key.Length; ++level)
            {
                int index = key[level] - 'a';
                if (pCrawl.children[index] == null) return false;
                pCrawl = pCrawl.children[index];
            }

            return pCrawl != null && pCrawl.isEndOfWord;
        }
    }
}
