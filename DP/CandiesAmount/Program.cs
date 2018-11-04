using System;
using ExecutionTimeTracker;

namespace CandiesAmount {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(TimeTracker.Execute(() => Console.WriteLine(MemoizationSolution.Candies(1, 2, 2))).TotalSeconds); // 4
            Console.WriteLine(TimeTracker.Execute(() => Console.WriteLine(MemoizationSolution.Candies(2, 4, 2, 6, 1, 7, 8, 9, 2, 1))).TotalSeconds); // 19
        }
    }
}
