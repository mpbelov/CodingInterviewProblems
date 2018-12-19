using System;
using ExecutionTimeTracker;

namespace SherlockAndCost {
    class Program {
        static void Main(string[] args) {
            TT.E(() => Solution.cost(new[] { 1, 2, 3 }), 2);
            TT.E(() => Solution.cost(new[] { 10, 1, 10, 1, 10 }), 36);
            TT.E(() => Solution.cost(new[] { 100, 2, 100, 2, 100 }), 396);
            TT.E(() => Solution.cost(new[] { 3, 15, 4, 12, 10 }), 50);
            TT.E(() => Solution.cost(new[] { 4, 7, 9 }), 12);
        }
    }
}
