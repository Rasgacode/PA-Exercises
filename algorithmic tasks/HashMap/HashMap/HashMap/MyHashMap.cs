using System;
using System.Collections.Generic;
using System.Linq;

namespace HashMap
{
    public class MyHashMap<K, V>
    {
        private const int bucketSize = 16;
        private readonly LinkedList<KeyValue<K, V>>[] elements = new LinkedList<KeyValue<K, V>>[bucketSize];


        public int GetPositionByHash(K key)
        {
            int h;
            h = (h = key.GetHashCode()) ^ (h >> bucketSize);
            return h & (bucketSize - 1);
        }

        public void Put(K key, V value)
        {
            int position = GetPositionByHash(key);
            if (elements[position] == null) elements[position] = new LinkedList<KeyValue<K, V>>();
            if (elements[position].Any(kvp => kvp.key.Equals(key)))
            {
                KeyValue<K, V> currentKvp = elements[position].Single(kvp => kvp.key.Equals(key));
                currentKvp.value = value;
                return;
            }
            elements[position].AddLast(new KeyValue<K, V>(key, value));
        }

        public V Get(K key)
        {
            int position = GetPositionByHash(key);
            try
            {
                return elements[position].First(kvp => kvp.key.Equals(key)).value;
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("This key is not exist");
            }
        }

        public void Clear()
        {
            for (int i = 0; i < elements.Length; ++i)
            {
                elements[i] = null;
            }
        }

        public V Remove(K key)
        {
            int position = GetPositionByHash(key);
            if (elements[position].Any(kvp => kvp.key.Equals(key)))
            {
                V deletedElementValue = elements[position].Single(kvp => kvp.key.Equals(key)).value;
                elements[position].Remove(elements[position].Single(kvp => kvp.key.Equals(key)));
                return deletedElementValue;
            }
            throw new InvalidOperationException("This key is not exist");
        }
    }
}
