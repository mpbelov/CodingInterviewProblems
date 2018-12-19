using System;

namespace SherlockAndCost {
    static class Solution {
        // We should calculate 2 sums and compare them. The max one is the answer.
        // The sum would be max if the difference between two consecutive numbers if one of them is 1
        // The first one could be 1, or the second one. After that we should calculate 2 sums and compare them.
        public static int cost(int[] B) {
            var firstIs1Way = 0;
            var secondIs1Way = 0;

            for (int i = 1; i < B.Length; i++) {
                var firstIs1 = Math.Abs(B[i] - 1);
                var secondIs1 = Math.Abs(1 - B[i - 1]);

                var firstIs1WayTemp = Math.Max(firstIs1Way, secondIs1Way + firstIs1);
                var secondIs1WayTemp = Math.Max(secondIs1Way, firstIs1Way + secondIs1);

                firstIs1Way = firstIs1WayTemp;
                secondIs1Way = secondIs1WayTemp;
            }
            
            return Math.Max(firstIs1Way, secondIs1Way);
        }
    }
}