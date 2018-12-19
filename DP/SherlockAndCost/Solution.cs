using System;

namespace SherlockAndCost {
    static class Solution {
        public static int cost(int[] B) {
            // We should calculate 2 sums and compare them. The max one is the answer.
            // The sum would be max if the difference between two consecutive numbers if one of them is 1
            // The first one could be 1, or the second one. After that we should calculate 2 sums and compare them.
            var way1 = 0;
            var way2 = 0;

            for (int i = 1; i < B.Length; i++) {
                var fisrtIs1 = Math.Abs(B[i] - 1);
                var secondIs1 = Math.Abs(1 - B[i - 1]);

                var way1New = Math.Max(way2, way1 + secondIs1);
                var way2New = Math.Max(way1, way2 + fisrtIs1);

                way1 = way1New;
                way2 = way2New;
            }
            return Math.Max(way1, way2);
        }
    }
}