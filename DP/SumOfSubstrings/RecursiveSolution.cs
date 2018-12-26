using System;

namespace SumOfSubstrings {
    public static class RecursiveSolution {
        public static long substrings(string n) {
            long sum = 0;
            substrings(n, 0, ref sum);
            return sum;
        }

        public static long substrings(string n, int index, ref long sum) {
            if (index == n.Length - 1) {
                var num = getNum(n[index]);
                sum += num;
                return num;
            }

            var current = getNum(n[index]);
            var left = substrings(n, index + 1, ref sum);
            var charsLeft = n.Length - index - 1;
            long value = 0;
            for (var i = 1; i <= charsLeft; i++) {
                value += current * (long)Math.Pow(10, i);
            }
            var sumSoFar = value + left + current;
            sum += sumSoFar;
            sum %= 1000000007;
            return sumSoFar;
        }

        static long getNum(char c) {
            return (long)(c - '0');
        }
    }
}