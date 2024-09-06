using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoLiveCoding.TwoPointers {
    public static class ThreeSum {
        public static IList<IList<int>> Sum(int[] numbers) {
            IList<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < numbers.Length; i++) {
                for (int j = 0; j < numbers.Length; j++) {
                    if (i != j) {
                        for (int k = 0; k < numbers.Length; k++) {
                            if (i != k && j != k) {
                                if (numbers[i] + numbers[j] + numbers[k] == 0) {
                                    var triplet = new List<int> { numbers[i], numbers[j], numbers[k] }.Order().ToList();

                                    if (!result.Any(t => t.SequenceEqual(triplet)))
                                        result.Add(triplet);
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }
    }
}
