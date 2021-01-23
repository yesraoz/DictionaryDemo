using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace DictionaryDemo
{
    public class MyDictionary<K, V>
    {
        K[] key;
        V[] values;


        public MyDictionary()
        {
            key = new K[0];
            values = new V[0];
        }

        public void Add(K keys, V value)
        {
            K[] tempKeys = key;
            V[] tempArray = values;
            key = new K[key.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                values[i] = tempArray[i];
            }

            values[values.Length - 1] = value;


            for (int i = 0; i < tempKeys.Length; i++)
            {
                key[i] = tempKeys[i];
            }

            key[key.Length - 1] = keys;
        }


        public int Count
        {
            get { return values.Length; }
        }

        public K[] keys
        {
            get { return key; }
        }

        public V[] value
        {
            get { return values; }
        }
    }
}
