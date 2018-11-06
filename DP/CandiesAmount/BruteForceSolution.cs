using System;

namespace CandiesAmount {
    public static class BruteForceSolution {
        public static long Candies(params int[] arr) {
            var rating = arr;
            var candies = new int[rating.Length];
            // we should specify 1 as a default value,
            // otherwise all candies amount to be incremented by 1 in the end
            // for (int i = 0; i < candies.Length; i++) {
            //     candies[i] = 1;
            // }
            
            // go forward and find candy amount for elements with ascending rating sort
            for (int i = 1; i < rating.Length; i++) {
                if (rating[i] > rating[i - 1] && candies[i] <= candies[i - 1]) {
                    candies[i] = candies[i - 1] + 1;
                }
                else if (rating[i] < rating[i - 1] && candies[i] >= candies[i - 1]) {
                    candies[i - 1] = candies[i] + 1;
                }
            }
            // go backward and find candy amount for elements with descending rating sort
            for (int i = rating.Length - 1; i > 0; i--) {
                if (rating[i] > rating[i - 1] && candies[i] <= candies[i - 1]) {
                    candies[i] = candies[i - 1] + 1;
                }
                else if (rating[i] < rating[i - 1] && candies[i] >= candies[i - 1]) {
                    candies[i - 1] = candies[i] + 1;
                }
            }

            long sum = 0;
            for (int i = 0; i < candies.Length; i++) {
                // just add 1 to each candy amount to get correct result
                sum += candies[i] + 1;
            }
            return sum;
        }
    }
}