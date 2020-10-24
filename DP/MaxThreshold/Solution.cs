namespace MaxThreshold {
    public static class Solution {
        public static decimal FindThreshold(decimal[] numbers, decimal maxSum) {
            System.Array.Sort(numbers);

            var currentSum = 0m;
            var threshold = maxSum / numbers.Length;

            for (int i = 0; i < numbers.Length; i++) {
                var thresholdCandidate = maxSum / (numbers.Length - i);
                var currentNumber = numbers[i];

                currentSum += currentNumber;

                if (currentSum + thresholdCandidate * (numbers.Length - i - 1) > maxSum) {
                    break;
                }
                threshold = thresholdCandidate;
            }

            return threshold;
        }
    }
}