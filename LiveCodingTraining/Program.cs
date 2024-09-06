using System.Collections.Generic;
using System.Linq;

using LiveCodingTraining.ArraysAndHashing;
using LiveCodingTraining.Curiosity;
using LiveCodingTraining.Stack;
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

        //LRUCacheV3 lRUCache = new LRUCacheV3(2);
        //lRUCache.Put(1, 10);  // cache: {1=10}
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(1)}");      // return 10
        //lRUCache.Put(2, 20);  // cache: {1=10, 2=20}
        //lRUCache.Put(3, 30);  // cache: {2=20, 3=30}, key=1 was evicted
        //Console.WriteLine($"Key: 2, Value: {lRUCache.Get(2)}");    // returns 20 
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(1)}");


        //LRUCacheV3 lRUCache = new LRUCacheV3(1);
        //lRUCache.Put(2, 1);  // cache: {1=10}
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(2)}");      // return 10
        //lRUCache.Put(3, 2);  // cache: {2=20, 3=30}, key=1 was evicted
        //Console.WriteLine($"Key: 2, Value: {lRUCache.Get(2)}");    // returns 20 
        //lRUCache.Put(2, 20);  // cache: {1=10, 2=20}
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(3)}");


        //LRUCacheV3 lRUCache = new LRUCacheV3(10);
        //lRUCache.Put(10, 13);
        //lRUCache.Put(3, 17);
        //lRUCache.Put(6, 11);
        //lRUCache.Put(10, 5);
        //lRUCache.Put(9, 10);
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(13)}");
        //lRUCache.Put(2, 19);
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(2)}");
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(3)}");
        //lRUCache.Put(5, 25);
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(8)}");
        //lRUCache.Put(9, 22);
        //lRUCache.Put(5, 5);
        //lRUCache.Put(1, 30);
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(11)}");
        //lRUCache.Put(9, 12);
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(7)}");
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(5)}");
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(8)}");
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(9)}");
        //lRUCache.Put(4, 30);
        //lRUCache.Put(9, 3);
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(9)}");
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(10)}");
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(10)}");
        //lRUCache.Put(6, 14);
        //lRUCache.Put(3, 1);
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(3)}");
        //lRUCache.Put(10, 11);
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(8)}");
        //lRUCache.Put(2, 14);
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(1)}");
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(5)}");
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(4)}");
        //lRUCache.Put(11, 4);
        //lRUCache.Put(12, 24);
        //lRUCache.Put(5, 18);
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(13)}");
        //lRUCache.Put(7, 23);
        //lRUCache.Put(8, 27);
        //lRUCache.Put(12, 12);
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(3)}");
        //lRUCache.Put(3, 21);
        //lRUCache.Put(10, 10);
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(8)}");
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(11)}");
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(7)}");
        //lRUCache.Put(7, 10);
        //lRUCache.Put(9, 2);
        //lRUCache.Put(5, 8);
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(11)}");
        //lRUCache.Put(8, 2);
        //lRUCache.Put(11,1);
        //lRUCache.Put(5,5);
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(5)}");
        //lRUCache.Put(4,9);
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(4)}");
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(10)}");
        //lRUCache.Put(6, 18);
        //lRUCache.Put(4, 7);
        //lRUCache.Put(8, 12);
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(7)}");
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(5)}");
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(4)}");
        //Console.WriteLine($"Key: 1, Value: {lRUCache.Get(5)}");

        //ThreeSum.Sum([0, 1, 1]);




        Console.WriteLine(ValidParentheses.IsValid("([{}])[]{}()").ToString());


    }
}

/*
 Exemplo Memory Cache

public async Task<IActionResult> ListarPorTomador(int? filtroPedidoId) {
            var tomadorId = $"TomadorId{ObterTomadorId()}";
            var pedidoId = $"PedidoId{filtroPedidoId}";
            var cacheItem = $"Projetos{tomadorId}{pedidoId}";

            //Limpa o Cache
            if (MemoryCache.TryGetValue(cacheItem, out ICollection<Projeto> projetosCache)) {
                //foreach (var projeto in projetosCache) {
                    MemoryCache.Remove(cacheItem);
                //}
            }

            //Carrega o Cache se não tiver itens
            var projetos = MemoryCache.GetOrCreate(cacheItem, item =>
            {
                item.SlidingExpiration = TimeSpan.FromMinutes(10);
                return ProjetoService.ListarPorFiltro(ObterTomadorId(), filtroPedidoId);
            });

            return CustomResponse(Mapper.Map<ICollection<ProjetoDataTableTomadorDto>>(projetos));
        }
 */