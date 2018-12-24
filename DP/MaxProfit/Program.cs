using System;
using ExecutionTimeTracker;

namespace MaxProfit {
    class Program {
        static void Main(string[] args) {
            TT.E(() => Solution.stockmax(new long[] { 5, 3, 2 }), 0);
            TT.E(() => Solution.stockmax(new long[] { 1, 2, 100 }), 197);
            TT.E(() => Solution.stockmax(new long[] { 1, 3, 1, 2 }), 3);
        }
    }
}
