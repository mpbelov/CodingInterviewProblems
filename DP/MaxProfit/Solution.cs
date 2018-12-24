namespace MaxProfit {
    public static class Solution {
        public static long stockmax(long[] prices) {
            long profit = 0;
            long maxSoFar = 0;

            for (long i = prices.Length - 1; i >= 0; i--) {
                if (prices[i] >= maxSoFar) {
                    maxSoFar = prices[i];
                }
                profit += maxSoFar - prices[i];

            }
            return profit;
        }
    }
}