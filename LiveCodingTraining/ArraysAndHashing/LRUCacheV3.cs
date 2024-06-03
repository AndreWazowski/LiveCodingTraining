using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Net.Mime.MediaTypeNames;

namespace LiveCodingTraining.ArraysAndHashing {
    public class LRUCacheV3 {
        public int Capacity { get; }
        public CacheItem Cache { get; private set; }
        public Dictionary<int, CacheItem> CacheList { get; private set; }

        public LRUCacheV3(int capacity) {
            Capacity = capacity;
            CacheList = new Dictionary<int, CacheItem>();
        }

        public int Get(int key) {
            if (CacheList.TryGetValue(key, out CacheItem? item)) {
                item.RemoveLink();
                item.SetNext(Cache);

                UpdateCache(key, item);

                return item.Value;
            }
            else return -1;
        }

        public void Put(int key, int value) {
            CacheList.TryGetValue(key, out CacheItem? item);

            if (item != null) {
                item.Update(value, Cache);

            }
            else {
                item = new CacheItem(key, value, Cache);

                if (CacheList.Count == Capacity) {
                    var itemToRemove = Cache.GetLast();
                    var newLastItem = itemToRemove.Previous;

                    newLastItem.SetNext(null);

                    CacheList.Remove(itemToRemove.Key);
                }
            }

            UpdateCache(key, item);
        }

        private void UpdateCache(int key, CacheItem item) {
            Cache?.SetPrevious(item);

            Cache = item;

            CacheList[key] = item;
        }
    }

    public class CacheItem {
        public int Value { get; private set; }
        public int Key { get; private set; }

        public CacheItem? Previous { get; private set; } = null;
        public CacheItem? Next { get; private set; } = null;

        public CacheItem(int key, int value, CacheItem next) {
            Update(value, next);
            Key = key;
        }

        public void Update(int value, CacheItem next) {
            Value = value;

            RemoveLink();
            SetNext(next);
        }

        public void RemoveLink() {
            Previous?.SetNext(Next);
            Next?.SetPrevious(Previous);

            Previous = null;
            Next = null;
        }

        public void SetPrevious(CacheItem previous) {
            if (this != previous)
                Previous = previous;
        }

        public void SetNext(CacheItem next) {
            if (this != next)
                Next = next;
        }

        public CacheItem GetLast() {
            var item = this;

            while (item.Next != null) {
                item = item.Next;
            }

            return item;
        }
    }
}
