using System;
using System.Collections.Generic;

namespace CoinChangeWays {
    public static class RecursionWithMemoization {
        public static long GetWays(long n, long[] c) {
            var map = new Dictionary<string, long>();
            var solution = new ProblemSolution(n, c);
            for (int i = 0; i < c.Length; i++) {
                solution.CalcWays(i, c[i], map);
            }
            return solution.NumWays;
        }

        class ProblemSolution {
            public ProblemSolution(long neededChange, long[] coins) {
                _neededChange = neededChange;
                _coins = coins;
            }
            public long NumWays { get; private set; }
            private long _neededChange;
            private long[] _coins;

            public void CalcWays(int startIndex, long amountCurrent, Dictionary<string, long> map) {
                if (amountCurrent == _neededChange) {
                    NumWays++;
                }
                else if (amountCurrent < _neededChange) {
                    var key = $"{amountCurrent}-{startIndex}";

                    if (map.TryGetValue(key, out long ways)) {
                        NumWays += ways;
                    }
                    else {
                        var begin = NumWays;
                        for (int i = startIndex; i < _coins.Length; i++) {
                            if (i + 1 == _coins.Length) { // last element
                                var amountRemained = _neededChange - amountCurrent;
                                if (amountRemained >= _coins[i] && amountRemained % _coins[i] == 0) {
                                    NumWays++;
                                }
                                break;
                            }
                            CalcWays(i, amountCurrent + _coins[i], map);
                        }
                        map[key] = NumWays - begin;
                    }
                }
            }
        }
    }
}