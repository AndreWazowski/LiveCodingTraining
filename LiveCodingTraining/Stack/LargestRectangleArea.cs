using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingTraining.Stack {
    public class LargestRectangleArea {
        public int Get(int[] heights) {
            int largestRectangle = 0;

            for (int i = 0; i < heights.Count() - 1; i++) {
                int tempRectangle = 0;

                if (heights[i] <= heights[i + 1]) tempRectangle = heights[i] * 2;
                else tempRectangle = heights[i + 1] * 2;

                if (tempRectangle > largestRectangle) largestRectangle = tempRectangle;
            }

            return largestRectangle;
        }
    }
}
