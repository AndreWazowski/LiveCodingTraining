using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoLiveCoding.TwoPointers {
    public static class TwoSumInputArraySorted {
        public static int[] TwoSum(int[] numbers, int target) {
            int[] result = new int[2];

            for (int i = 0; i < numbers.Length; i++) {
                for (int j = 1; j < numbers.Length; j++) {
                    if (numbers[i] + numbers[j] == target) {
                        result[0] = i + 1;
                        result[1] = j + 1;

                        break;
                    }
                }

                if (result.Length > 0) break;
            }

            return result;
        }
    }
}
