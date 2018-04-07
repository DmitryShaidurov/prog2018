using System;
using System.Collections.Generic;

namespace task4
{
    public class HashTable

    {
        class KeyValuePair
        {
            public object Key { get; set; }
            public object Value { get; set; }
        }

        List<List<KeyValuePair>> table; 

        public HashTable(int size)
        {
            table = new List<List<KeyValuePair>>();
            for (int i = 0; i < size; i++)
            {
                table.Add(new List<KeyValuePair>());
            }
        }
 
        public void PutPair(object key, object value)
        {
            var noBucket = GetBucketNumber(key);
            foreach (var keyValuePair in table[noBucket])
            {
                if (Equals(keyValuePair.Key, key))
                {
                    keyValuePair.Value = value;
                    return;
                }
            }

        table[noBucket].Add(new KeyValuePair { Key = key, Value = value });
        }

        public object GetValueByKey(object key)
        {
            var noBucket = GetBucketNumber(key);
            foreach (var keyValuePair in table[noBucket])
            {
                if (Equals(keyValuePair.Key, key))
                {
                    return keyValuePair.Value;
                }
            }

            return null;
        }

        private int GetBucketNumber(object key)
        {
            return Math.Abs(key.GetHashCode()) % table.Count;
        }
    }
}