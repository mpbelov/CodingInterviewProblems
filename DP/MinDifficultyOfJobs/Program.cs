using System;
using System.Collections.Generic;

namespace MinDifficultyOfJobs {
    class Program {
        static void Main(string[] args) {
            // https://leetcode.com/problems/minimum-difficulty-of-a-job-schedule/

            TT.E(() => MinDifficulty(new[] { 6, 5, 4, 3, 2, 1 }, 2), baseline: 7);
            TT.E(() => MinDifficulty(new[] { 11, 111, 22, 222, 33, 333, 44, 444 }, 6), baseline: 843);
            TT.E(() => MinDifficulty(new[] { 7, 1, 7, 1, 7, 1 }, 3), baseline: 15);
            TT.E(() => MinDifficulty(new[] { 1, 5, 4, 2, 4 }, 2), baseline: 6);
            TT.E(() => MinDifficulty(new[] { 30, 10, 40, 20, 50 }, 2), baseline: 80);
            TT.E(() => MinDifficulty(new[] { 74303, 20452, 66120, 44483, 5370, 68585 }, 5), baseline: 234830);
        }

        static int MinDifficulty(int[] jobDifficulty, int d) {
            return MinDifficulty1(jobDifficulty, d, 0, new Dictionary<string, int>());
        }

        static int MinDifficulty1(int[] jobDifficulty, int d, int startIndex, Dictionary<string, int> difficulties) {
            var key = $"{d}_{startIndex}";
            if (difficulties.ContainsKey(key)) {
                return difficulties[key];
            }

            if (d == 1) {
                var max = int.MinValue;
                for (int i = startIndex; i < jobDifficulty.Length; i++) {
                    max = Math.Max(max, jobDifficulty[i]);
                }
                return max;
            }
            if (jobDifficulty.Length - startIndex < d) {
                return -1;
            }
            if (jobDifficulty.Length == d) {
                var sum = 0;
                for (int i = startIndex; i < jobDifficulty.Length; i++) {
                    sum += jobDifficulty[i];
                }
                return sum;
            }

            int difficultySoFar = -1;
            int minDifficulty = int.MaxValue;

            for (int i = startIndex; i <= jobDifficulty.Length - d; i++) {
                difficultySoFar = Math.Max(difficultySoFar, jobDifficulty[i]);

                int nextDaysComplexity = MinDifficulty1(jobDifficulty, d - 1, i + 1, difficulties);
                difficulties[$"{d - 1}_{i + 1}"] = nextDaysComplexity;

                minDifficulty = Math.Min(minDifficulty, difficultySoFar + nextDaysComplexity);
            }

            return minDifficulty;
        }
    }
}
