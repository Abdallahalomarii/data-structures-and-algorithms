using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange30_HashTable
{

    public class HashNode<TKey, TValue>
    {
        public TKey Key { get; set; }
        public IList<TValue> Value { get; set; }

        public HashNode(TKey key, TValue value)
        {
            Key = key;
            Value = new List<TValue> { value };
        }
    }
}
