using System;
using ExecutionTimeTracker;

namespace CandiesAmount {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(TimeTracker.Execute(() => Console.WriteLine(BruteForceSolution.Candies(1, 2, 2))).TotalSeconds); // 4
            Console.WriteLine(TimeTracker.Execute(() => Console.WriteLine(BruteForceSolution.Candies(2, 4, 2, 6, 1, 7, 8, 9, 2, 1))).TotalSeconds); // 19
            Console.WriteLine(TimeTracker.Execute(() => Console.WriteLine(BruteForceSolution.Candies(10, 9, 8, 7, 6, 5, 4, 3, 2, 1))).TotalSeconds); // 55
        }
    }
}
