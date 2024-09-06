using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingTraining.ArraysAndHashing {
    public class LRUCacheV1 {
        private int Capacity { get; set; }
        public LinkedList<LRUCacheItem> Itens { get; } = new LinkedList<LRUCacheItem>();

        public LRUCacheV1(int capacity) {
            Capacity = capacity;
        }

        public int Get(int key) {

            var item = Itens.FirstOrDefault(i => i.Key == key);

            if (item == null) return -1;
            else {
                Updatecache(item);

                return item.Value;
            }
        }


        public void Put(int key, int value) {
            LRUCacheItem? item = null;

            if (Itens.Count != 0) item = Itens.FirstOrDefault(i => i.Key == key);

            if (item != null) {
                Updatecache(item);
            }
            else {
                if (Itens.Count == Capacity) Itens.RemoveLast();

                Itens.AddFirst(new LRUCacheItem(key, value));
            }
        }

        private void Updatecache(LRUCacheItem item) {
            Itens.Remove(item);
            Itens.AddFirst(item);
        }
    }

    public class LRUCacheItem {
        public int Key { get; private set; }
        public int Value { get; private set; }

        public LRUCacheItem(int key, int value) {
            UpdateValue(value);
            Key = key;
        }

        public void UpdateValue(int value) {
            Value = value;
        }
    }
}


