using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_33_Hashmap_LeftJoin
{
    public class HashMap<TKey, TValue>
    {

        private const int DefaultSize = 100;
        public LinkedList<HashNode<TKey, TValue>>[] Map { get; set; }

        public HashMap() : this(DefaultSize) { }

        public HashMap(int size)
        {
            Map = new LinkedList<HashNode<TKey, TValue>>[size];
        }

        private int Hash(TKey key)
        {
            int hashValue = 0;

            char[] letters = key.ToString().ToCharArray();

            for (int i = 0; i < letters.Length; i++)
            {
                hashValue += letters[i];
            }

            return hashValue % Map.Length;
        }

        public void Set(TKey key, TValue value)
        {
            int hashKey = Hash(key);

            if (Map[hashKey] == null)
            {
                Map[hashKey] = new LinkedList<HashNode<TKey, TValue>>();
            }

            foreach (var entry in Map[hashKey])
            {
                if (entry.Key.Equals(key))
                {
                    entry.Value.Add(value);
                    return;
                }
            }

            Map[hashKey].AddLast(new HashNode<TKey, TValue>(key, value));
        }

        public bool Has(TKey key)
        {
            int hashKey = Hash(key);

            if (Map[hashKey] != null)
            {
                foreach (var entry in Map[hashKey])
                {
                    if (entry.Key.Equals(key))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public IEnumerable<TKey> Keys()
        {
            List<TKey> keys = new List<TKey>();

            foreach (var bucket in Map)
            {
                if (bucket != null)
                {
                    foreach (var entry in bucket)
                    {
                        keys.Add(entry.Key);
                    }
                }
            }

            return keys;
        }

        public IEnumerable<TValue> Get(TKey key)
        {
            int hashKey = Hash(key);
            List<TValue> values = new List<TValue>();

            if (Map[hashKey] != null)
            {
                foreach (var entry in Map[hashKey])
                {
                    if (entry.Key.Equals(key))
                    {
                        values.AddRange(entry.Value);
                    }
                }
            }

            if (values.Count == 0)
            {
                throw new KeyNotFoundException($"Key '{key}' not found in the hashtable.");
            }

            return values;
        }

        public int HashIndex(TKey key)
        {
            return Hash(key);
        }

        public void Print()
        {
            for (int i = 0; i < Map.Length; i++)
            {
                if (Map[i] != null)
                {
                    foreach (var node in Map[i])
                    {
                        Console.WriteLine($"Bucket {i}: Key = {node.Key}, Values = {string.Join(", ", node.Value)}");
                    }
                }
            }
        }
    }
}
