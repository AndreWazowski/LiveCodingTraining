using System.Collections.Generic;
using System.Linq;

using LiveCodingTraining.ArraysAndHashing;
using LiveCodingTraining.Curiosity;
using LiveCodingTraining.Trees;

using TreinamentoLiveCoding;
using TreinamentoLiveCoding.TwoPointers;

public static class Program {
    public static void Main(string[] args) {
        //Console.WriteLine(ValidPalindromeWithEnum.IsPalindrome("19Z man, a plan, a canal: Panamz91"));
        //Console.WriteLine(ValidPalindrome.IsPalindrome("1A man, a plan, a canal: Panama1"));
        //Console.WriteLine(TwoSumInputArraySorted.TwoSum([2, 3, 4], 6));3
        //Console.WriteLine(ThreeSum.Sum([-1, 0, 1, 2, -1, -4]));


        //int[] list = new int[5] { 8, 1, 5, 0, 3 };

        //OrderList.Order(list);

        //Console.WriteLine(string.Join(",", list));

        //BasicBinaryTree.CreateAndPrintTree();
        //TwoSum.GetResultV2([3, 4, 5, 6], 7);


        //var l = new Dictionary<int, int> {
        //    { 1, 1 },
        //    { 3, 7 },
        //    { 7, 6 },
        //    { 2, 66 },
        //};

        //Console.WriteLine($"Start: \r\n");


        //foreach (var i in l) Console.WriteLine($"Key: {i.Key}, Value {i.Value}");

        //var item = l.First(i => i.Key == 3);
        //l.Remove(item.Key);
        //l.Add(item.Key, item.Value);

        //Console.WriteLine($"Start: \r\n");

        //foreach (var i in l) Console.WriteLine($"Key: {i.Key}, Value {i.Value}");


        //var l = new HashSet<int>(4) {
        //    2,
        //    5,
        //    4,
        //    8,
        //    9
        //};

        //Console.WriteLine($"Start: \r\n");

        //foreach (var i in l) Console.WriteLine($"Key: {i}");

        //l.Remove(5);
        //l.Add(5);

        //Console.WriteLine($"Start: \r\n");

        //foreach (var i in l) Console.WriteLine($"Key: {i}");



        //var l = new LinkedList();

        //Console.WriteLine($"Start: \r\n");

        //foreach (var i in l) Console.WriteLine($"Key: {i}");

        //l.Find(i=>i.);
        //l.Add(5);

        //Console.WriteLine($"Start: \r\n");

        //foreach (var i in l) Console.WriteLine($"Key: {i}");

        LRUCacheV3 lRUCache = new LRUCacheV3(2);
        lRUCache.Put(1, 10);  // cache: {1=10}
        Console.WriteLine($"Key: 1, Value: {lRUCache.Get(1)}");      // return 10
        lRUCache.Put(2, 20);  // cache: {1=10, 2=20}
        lRUCache.Put(3, 30);  // cache: {2=20, 3=30}, key=1 was evicted
        Console.WriteLine($"Key: 2, Value: {lRUCache.Get(2)}");    // returns 20 
        Console.WriteLine($"Key: 1, Value: {lRUCache.Get(1)}");
    }
}