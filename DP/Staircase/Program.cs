using System;
using ExecutionTimeTracker;

namespace Staircase {
    class Program {
        static void Main(string[] args) {
            Run(2, new[] { 1, 2 }); // 2
            Run(3, new[] { 1, 2 }); // 3
            Run(4, new[] { 1, 2 }); // 5
            Run(10, new[] { 1, 2 }); // 89
            Run(24, new[] { 1, 2 }); // 75025
            Run(7, new[] { 1, 2, 3 }); // 44
            Run(35, new[] { 1, 2, 3 }); // 1132436852
        }

        static void Run(int n, int[] w) {
            Console.WriteLine(TimeTracker.Execute(() => Console.WriteLine(MemoizationSolution.NumWays(n, w))).TotalSeconds);
        }
    }
}