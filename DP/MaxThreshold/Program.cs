using System;
using ExecutionTimeTracker;

namespace MaxThreshold {
    class Program {
        static void Main(string[] args) {
            TT.E(() => Solution.FindThreshold(numbers: new[] { 4m, 5m, 1m, 2m, 3m, }, maxSum: 12m), 3m);
            TT.E(() => Solution.FindThreshold(numbers: new[] { 1m, 2m, 3m, 4m, 5m }, maxSum: 13m), 3.25m);
            TT.E(() => Solution.FindThreshold(numbers: new[] { 5m, 5m, 5m, }, maxSum: 15m), 5m);
            TT.E(() => Solution.FindThreshold(numbers: new[] { 5m, 5m, 5m, }, maxSum: 12m), 4m);
        }
    }
}
