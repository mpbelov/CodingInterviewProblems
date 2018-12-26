using System;

namespace SumOfSubstrings {
    public static class LoopSolution2 {
        public static long substrings(string n) {
            long sumSoFar = getNum(n[n.Length - 1]);
            var total = sumSoFar;

            long multiplier = 10;

            for (int index = n.Length - 2; index >= 0; index--) {
                var current = getNum(n[index]);
                var charsLeft = n.Length - index - 1;

                long value = current * multiplier;
                multiplier = (multiplier + 1) * 10 % 1000000007;

                var sumThisStepOnly = value + sumSoFar + current;
                total += sumThisStepOnly;
                total %= 1000000007;
                sumSoFar = (long)(sumThisStepOnly % 1000000007);
            }

            return total;
        }

        static long getNum(char c) {
            return (long)(c - '0');
        }
    }
}