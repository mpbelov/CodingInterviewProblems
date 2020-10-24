namespace MaxThreshold {
    public static class Solution {
        public static decimal FindThreshold(decimal[] numbers, decimal maxSum) {
            System.Array.Sort(numbers);

            var currentSum = 0m;
            var threshold = maxSum / numbers.Length;

            for (int i = 0; i < numbers.Length; i++) {
                threshold = (maxSum - currentSum) / (numbers.Length - i);
                currentSum += numbers[i];
                
                if (currentSum + threshold * (numbers.Length - i - 1) > maxSum) {
                    break;
                }
            }

            return threshold;
        }
    }
}