using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingTraining.ArraysAndHashing {
    public static class TwoSum {
        public static int[] GetResultV2(int[] nums, int target) {
            var list = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++) {
                var num = nums[i];
                var diff = target - num;

                if (list.ContainsKey(diff)) return [list.Single(l => l.Key == diff).Value, i];
                else list.Add(nums[i], i);
            }

            return new int[2];
        }

        public static int[] GetResultV1(int[] nums, int target) {

            for (int i = 0; i < nums.Length; i++) {

                for (int j = i + 1; j < nums.Length; j++) {
                    if (nums[i] + nums[j] == target)
                        return [i, j];
                }
            }

            return new int[2];
        }
    }
}
