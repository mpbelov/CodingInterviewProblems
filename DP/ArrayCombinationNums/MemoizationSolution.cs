using System;
using System.Collections.Generic;

namespace ArrayCombinationNums {
    public static class MemoizationSolution {
        public static long numWays(long maxNumber, int length, long lastNumber) {
            var map = new Dictionary<string, long>();
            long ways = 0;
            for (long i = 1; i <= maxNumber; i++) {
                ways += numWays(maxNumber, length, lastNumber,
                index: 1,
                prevNumber: 1,
                currentNumber: i,
                map: map);
            }
            return ways;
        }

        private static long numWays(long maxNumber, int length, long lastNumber, int index, long prevNumber, long currentNumber, Dictionary<string, long> map) {
            if (index == length - 2) {
                if (currentNumber != prevNumber && currentNumber != lastNumber) {
                    return 1;
                }
                else {
                    return 0;
                }
            }
            else {
                var key = $"{index}-{currentNumber}";
                if (map.TryGetValue(key, out long value)) {
                    return value;
                }
                long ways = 0;
                for (long i = 1; i <= maxNumber; i++) {
                    ways += numWays(maxNumber, length, lastNumber,
                        index: index + 1,
                        prevNumber: currentNumber,
                        currentNumber: i,
                        map: map);
                }
                map[key] = ways;
                return ways;
            }
        }
    }
}