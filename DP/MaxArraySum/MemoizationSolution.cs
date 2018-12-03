namespace MaxArraySum {
    public static class MemoizationSolution {
        public static int maxSubsetSum(int[] arr) {
            if (arr == null || arr.Length == 0) {
                throw new System.Exception();
            }
            if (arr.Length == 1) {
                return arr[0];
            }
            if (arr.Length == 2) {
                return System.Math.Max(arr[0], arr[1]);
            }

            var maxSums = new int[arr.Length];
            maxSums[0] = arr[0];
            maxSums[1] = System.Math.Max(arr[0], arr[1]);
            var maxSum = maxSums[1];
            for (int i = 2; i < arr.Length; i++) {
                maxSums[i] = max(maxSum, arr[i], arr[i] + maxSums[i - 2]);
                maxSum = System.Math.Max(maxSum, maxSums[i]);
            }
            return maxSum;
        }

        private static int max(int a1, int a2, int a3) {
            return a1 > a2
                ? a1 > a3
                    ? a1
                    : a3
                : a2 > a3
                    ? a2
                    : a3;
        }
    }
}