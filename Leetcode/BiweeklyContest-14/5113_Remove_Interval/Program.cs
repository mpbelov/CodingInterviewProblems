using System;
using System.Collections.Generic;

namespace _5113_Remove_Interval {
    class Program {
        static void Main(string[] args) {
            // Console.WriteLine(PrintIntervals(new Solution().RemoveInterval(
            //     new[] { new[] { -5, -4 }, new[] { -3, -2 }, new[] { 1, 2 }, new[] { 3, 5 }, new[] { 8, 9 } },
            //     new[] { -1, 4 })));
            // Console.WriteLine(PrintIntervals(new Solution().RemoveInterval(
            //     new[] { new[] { 0, 2 }, new[] { 3, 4 }, new[] { 5, 7 } },
            //     new[] { 1, 6 })));
            Console.WriteLine(PrintIntervals(new Solution().RemoveInterval(
                new[] { new[] { 0, 5 } },
                new[] { 2, 3 })));
        }

        static string PrintIntervals(IList<IList<int>> intervals) {
            var sb = new System.Text.StringBuilder();
            foreach (var i in intervals) {
                sb.Append($"[{i[0]}, {i[1]}] ");
            }
            return sb.ToString();
        }
    }

    public class Solution {
        public IList<IList<int>> RemoveInterval(int[][] intervals, int[] toBeRemoved) {
            var result = new List<IList<int>>(intervals.Length);
            foreach (var curInterval in intervals) {
                if (
                        curInterval[1] < toBeRemoved[0]
                        || curInterval[1] == toBeRemoved[0]
                        || curInterval[0] > toBeRemoved[1]
                        || curInterval[0] == toBeRemoved[1]) {
                    result.Add(new List<int>(curInterval));
                }
                else if (
                        (curInterval[0] > toBeRemoved[0] || curInterval[0] == toBeRemoved[0])
                        && (curInterval[1] < toBeRemoved[1] || curInterval[1] == toBeRemoved[1])) {
                    continue;
                }
                else if (
                        (curInterval[0] < toBeRemoved[0])
                        && (curInterval[1] < toBeRemoved[1] || curInterval[1] == toBeRemoved[1])) {
                    result.Add(new List<int>() { curInterval[0], toBeRemoved[0] });
                }
                else if (
                        (curInterval[1] > toBeRemoved[1])
                        && (curInterval[0] > toBeRemoved[0] || curInterval[0] == toBeRemoved[0])) {
                    result.Add(new List<int>() { toBeRemoved[1], curInterval[1] });
                }
                else if (curInterval[0] < toBeRemoved[0] && curInterval[1] > toBeRemoved[1]) {
                    result.Add(new List<int>() { curInterval[0], toBeRemoved[0] });
                    result.Add(new List<int>() { toBeRemoved[1], curInterval[1] });
                }
                else {
                    throw new Exception();
                }
            }
            return result;
        }
    }
}