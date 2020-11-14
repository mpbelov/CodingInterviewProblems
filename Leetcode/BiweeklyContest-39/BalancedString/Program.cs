using System;

namespace BalancedString {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(MinimumDeletions("aababbab"));
        }

        // https://leetcode.com/problems/minimum-deletions-to-make-string-balanced/
        public static int MinimumDeletions(string s) {
            if (s.Length == 1) {
                return 0;
            }

            var bsLeft = new int[s.Length]; // number of 'b's to the left of the current character
            var asRight = new int[s.Length]; // number of 'a's to the right of the current character

            bsLeft[0] = 0; // no 'b's to the left
            asRight[asRight.Length - 1] = 0; // no 'a's to the rigth

            for (int i = 1; i < s.Length; i++) {
                if (s[i - 1] == 'b') {
                    bsLeft[i] = bsLeft[i - 1] + 1;
                }
                else {
                    bsLeft[i] = bsLeft[i - 1];
                }
            }

            for (int i = s.Length - 2; i >= 0; i--) {
                if (s[i + 1] == 'a') {
                    asRight[i] = asRight[i + 1] + 1;
                }
                else {
                    asRight[i] = asRight[i + 1];
                }
            }

            var minDeletions = int.MaxValue;
            for (int i = 0; i < bsLeft.Length; i++) {
                var curDeletions = bsLeft[i] + asRight[i];
                minDeletions = Math.Min(minDeletions, curDeletions);
            }

            return minDeletions;
        }
    }
}
