namespace CoinChangeWays {
    public static class Recursion2 {
        public static long GetWays(long n, long[] c) {
            return numWays(n, c);
        }

        private static long numWays(long amount, long[] coins, int index = 0) {
            if (amount == 0) {
                return 1;
            }
            if (amount < 0 || index >= coins.Length) {
                return 0;
            }
            long ways = 0;
            long amountWithCoins = 0;
            while (amountWithCoins <= amount) {
                var amountRemains = amount - amountWithCoins;
                ways += numWays(amountRemains, coins, index + 1);
                amountWithCoins += coins[index];
            }
            return ways;
        }
    }
}