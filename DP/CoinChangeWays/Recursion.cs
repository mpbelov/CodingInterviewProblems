using System;
using ExecutionTimeTracker;

namespace CoinChangeWays {
    public static class Recursion {
        public static long GetWays(long n, long[] c) {
            Array.Sort(c, (i1, i2) => i2.CompareTo(i1));
            var solution = new Solution(n, c);
            for (int i = 0; i < c.Length; i++) {
                solution.CalcWays(i, c[i]);
            }
            return solution.NumWays;
        }

        class Solution {
            public Solution(long neededChange, long[] coins) {
                _neededChange = neededChange;
                _coins = coins;
            }
            public long NumWays { get; private set; }
            private long _neededChange;
            private long[] _coins;

            public void CalcWays(int startIndex, long amountCurrent) {
                if (amountCurrent == _neededChange) {
                    NumWays++;
                }
                else if (amountCurrent < _neededChange) {
                    for (int i = startIndex; i < _coins.Length; i++) {
                        if (i + 1 == _coins.Length) { // last element
                            var amountRemained = _neededChange - amountCurrent;
                            if (amountRemained >= _coins[i] && amountRemained % _coins[i] == 0) {
                                NumWays++;
                            }
                            break;
                        }
                        CalcWays(i, amountCurrent + _coins[i]);
                    }
                }
            }
        }
    }
}