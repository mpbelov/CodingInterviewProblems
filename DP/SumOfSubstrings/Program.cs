using System;

namespace SumOfSubstrings {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(substrings("123"));
        }

        static long substrings(string n) {
            long sum = 0;
            for (int numLength = 0; numLength < n.Length; numLength++) {
                for (int charIndex = 0; charIndex < n.Length - numLength; charIndex++) {
                    var num = getSubstring(n, charIndex, numLength);
                    sum += num;
                    sum %= 1000000007;
                }
            }
            return sum;
        }

        static long getSubstring(string n, int startIndex, int length) {
            var num = getInt(n[startIndex]);
            for (int i = 1; i <= length; i++) {
                num *= 10;
                num += getInt(n[startIndex + i]);
            }
            return num;
        }

        static long getInt(char c) {
            return (long)(c - '0');
        }
    }
}