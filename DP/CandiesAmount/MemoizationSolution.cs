using System;

namespace CandiesAmount {
    public static class BruteForceSolution {
        public static long Candies(params int[] rating) {
            var candies = new int[rating.Length];
            for (int i = 0; i < candies.Length; i++) {
                candies[i] = 1;
            }
            bool wasUpdate;
            do {
                wasUpdate = false;
                for (int i = 1; i < rating.Length; i++) {
                    if (rating[i] > rating[i - 1] && candies[i] <= candies[i - 1]) {
                        candies[i] = candies[i - 1] + 1;
                        wasUpdate = true;
                    }
                    else if (rating[i] < rating[i - 1] && candies[i] >= candies[i - 1]) {
                        candies[i - 1] = candies[i] + 1;
                        wasUpdate = true;
                    }
                }
            } while (wasUpdate);

            var sum = 0;
            for (int i = 0; i < candies.Length; i++) {
                Console.Write(candies[i] + " ");
                sum += candies[i];
            }
            Console.WriteLine();
            return sum;
        }
    }
}