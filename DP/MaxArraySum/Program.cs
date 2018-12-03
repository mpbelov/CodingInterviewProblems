using System;
using ExecutionTimeTracker;

namespace MaxArraySum {
    class Program {
        static void Main(string[] args) {
            TT.E(() => MemoizationSolution.maxSubsetSum(new int[] { -1, 1, 3, -4, 5 }), 8);
            TT.E(() => MemoizationSolution.maxSubsetSum(new int[] { 3, 7, 4, 6, 5 }), 13);
            TT.E(() => MemoizationSolution.maxSubsetSum(new int[] { 2, 1, 5, 8, 4 }), 11);
            TT.E(() => MemoizationSolution.maxSubsetSum(new int[] { 3, 5, -7, 8, 10 }), 15);
        }
    }
}
