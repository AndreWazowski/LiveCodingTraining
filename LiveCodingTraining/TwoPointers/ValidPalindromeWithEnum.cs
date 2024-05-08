using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Net.Mime.MediaTypeNames;

namespace TreinamentoLiveCoding.TwoPointers {
    public static class ValidPalindromeWithEnum {
       
        public static bool IsPalindrome(string s) {

            s = s.ToLower();

            string newString = string.Empty;

            for (int i = 0; i < s.Length; i++) {
                if (IsLetterOrDigit(s.ElementAt(i)))
                    newString += s.ElementAt(i);
            }

            return newString == Reverse(newString);
        }

        public static bool IsLetterOrDigit(char s) {
            return (s >= (int)EIsLetterOrDigitsAscIIParams.Number0 && s <= (int)EIsLetterOrDigitsAscIIParams.Number9) ||
                   (s >= (int)EIsLetterOrDigitsAscIIParams.LowerLetterA && s <= (int)EIsLetterOrDigitsAscIIParams.LowerLetterZ);
        } 

        public static string Reverse(string text) {
            string stringReversed = string.Empty;

            for (int i = text.Length - 1; i >= 0; i--)
                stringReversed += text.ElementAt(i);

            return stringReversed;
        }
    }

    public enum EIsLetterOrDigitsAscIIParams {
        Number0 = 48,
        Number9 = 57,
        LowerLetterA = 97,
        LowerLetterZ = 122
    }
}
