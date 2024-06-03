using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingTraining.ArraysAndHashing {
    public class LRUCacheV2 {
        private int Capacity { get; set; }
        public Dictionary<int, LinkedListNode<(int key, int value)>> Items { get; }
        public LinkedList<(int key, int value)> Cache { get; }

        public LRUCacheV2(int capacity) {
            Capacity = capacity;
            Items = new Dictionary<int, LinkedListNode<(int key, int value)>>();
            Cache = new LinkedList<(int key, int value)>();
        }

        public int Get(int key) {
            if (!Items.ContainsKey(key)) {
                return -1;
            }
            else {
                var item = Items[key];

                Cache.Remove(item);
                Cache.AddFirst(item);

                return item.Value.value;
            }
        }


        public void Put(int key, int value) {
            LinkedListNode<(int key, int value)> item;

            if (Items.ContainsKey(key)) RemoveItem(Items[key]);
            else if (Items.Count == Capacity) RemoveItem(Cache.Last);

            Cache.AddFirst((key, value));
            Items.Add(key, Cache.First);
        }

        private void RemoveItem(LinkedListNode<(int key, int value)> item) {
            Items.Remove(item.Value.key);
            Cache.Remove(item);
        }
    }
}


