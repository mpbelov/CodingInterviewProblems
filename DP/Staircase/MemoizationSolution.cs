namespace Staircase {
    public static class MemoizationSolution {
        public static long NumWays(int stepNum, int[] allowedMoves) {
            var memo = new System.Collections.Generic.Dictionary<string, long>();
            return numWays(stepNum, allowedMoves, memo);
        }

        private static long numWays(int leftSteps, int[] allowedMoves, System.Collections.Generic.Dictionary<string, long> memo) {
            if (leftSteps == 0) {
                return 1;
            }
            if (leftSteps < 0) {
                return 0;
            }
            long n = 0;
            for (int i = 0; i < allowedMoves.Length; i++) {
                var currentMove = allowedMoves[i];

                var key = $"{leftSteps}-{currentMove}";
                long val;
                if (!memo.TryGetValue(key, out val)) {
                    val = numWays(leftSteps - currentMove, allowedMoves, memo);
                    memo[key] = val;
                }
                n += val;
            }
            return n % 10000000007;
        }
    }
}