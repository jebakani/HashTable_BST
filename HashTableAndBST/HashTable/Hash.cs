using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Hash<K,V>
    {
        private readonly int listSize;
        private  LinkedList<KeyValue<K, V>>[] item;
        public Hash(int size)
        {
            this.listSize = size;
            this.item = new LinkedList<KeyValue<K, V>>[size];
        }
        public int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % listSize;
            return (Math.Abs(position));

        }
        protected LinkedList<KeyValue<K,V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = item[position];
            if(linkedList==null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                item[position] = linkedList;
            }
            return linkedList;
        }
        public void AddNode(K key,V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> keyValue = new KeyValue<K, V> { Key = key, Value = value };
            linkedList.AddLast(keyValue);
        }
        public void display()
        {
            for (int i =0;i<listSize;i++)
            {
                LinkedList<KeyValue<K, V>> linkedList = item[i];
                if(linkedList==null)
                {
                    continue;
                }
                foreach(KeyValue<K, V> list in linkedList)
                {
                    Console.WriteLine("key:{0},value:{1}",list.Key,list.Value);
                }
            }
        }
        public int frequency(K key)
        {
            int count = 0;
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = item[position];
            if (linkedList == null)
            {
                return count;
            }
            else
            {
                foreach (KeyValue<K, V> list in linkedList)
                {
                    if(list.Key.Equals(key)==true)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }

    public struct KeyValue<k, v>
    {
        public k Key { get; set; }
        public v Value { get; set; }

    }
}

