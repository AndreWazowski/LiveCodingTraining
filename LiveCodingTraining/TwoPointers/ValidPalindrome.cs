using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Net.Mime.MediaTypeNames;

namespace TreinamentoLiveCoding.TwoPointers {
    public static class ValidPalindrome {
        //public static bool IsPalindrome(string s)
        //{
        //    var newString = new string(s.Where(char.IsLetterOrDigit).ToArray());
        //    newString = newString.ToLower();

        //    return newString == new string(newString.Reverse().ToArray());
        //}

        public static bool IsPalindrome(string s) {

            s = s.ToLower();

            string newString = string.Empty;

            for (int i = 0; i < s.Length; i++) {
                if (IsLetterOrDigit(s.ElementAt(i)))
                    newString += s.ElementAt(i);
            }

            return newString == Reverse(newString);
        }

        public static bool IsLetterOrDigit(char s) => (s > 47 && s < 58) || (s > 96 && s < 123);

        public static string Reverse(string text) {
            string stringReversed = string.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
                stringReversed += text.ElementAt(i);

            return stringReversed;
        }
    }
}
