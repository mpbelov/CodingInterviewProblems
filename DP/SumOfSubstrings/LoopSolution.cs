namespace SumOfSubstrings {
    public static class LoopSolution {
        public static long substrings(string n) {
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
            var num = getNum(n[startIndex]);
            for (int i = 1; i <= length; i++) {
                num *= 10;
                num += getNum(n[startIndex + i]);
            }
            return num;
        }

        static long getNum(char c) {
            return (long)(c - '0');
        }
    }
}