
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingTraining.Curiosity {
    public static class OrderList {
        //Here is not necessary a return, because de original list is modified
        public static void BubbleSort(int[] list) {

            for (int i = 0; i < list.Length; i++) {
                for (int j = i + 1; j < list.Length; j++) {
                    if (list[i] > list[j]) {
                        var itemAtual = list[i];
                        var prximoitem = list[j];

                        list[i] = prximoitem;
                        list[j] = itemAtual;
                    }
                }
            }
        }
    }
}
