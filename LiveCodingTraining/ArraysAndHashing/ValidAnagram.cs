using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingTraining.ArraysAndHashing {
    public static class ValidAnagram {
        public static bool IsAnagram(string s, string t) {
            if (s.Length != t.Length) return false;

            int sValue = 0;
            int tValue = 0;

            for (int i = 0; i < s.Length; i++) {
                sValue += s[i];
                tValue += t[i];
            }

            return sValue == tValue;
        }
    }
}
