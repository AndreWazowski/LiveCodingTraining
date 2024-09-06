using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingTraining.Stack {
    public static class ValidParentheses {
        public static bool IsValid(string s) {
            var list = new Stack<char>();
            var pairs = new Dictionary<char, char>() {
                ['('] = ')',
                ['['] = ']',
                ['{'] = '}'
            };

            foreach (char c in s) {
                if (pairs.ContainsKey(c)) list.Push(c);
                else if (list.Count == 0 || pairs[list.Pop()] != c) return false;
            }


            return list.Count == 0;
        }
    }
}
