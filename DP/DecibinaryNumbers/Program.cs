using System;
using ExecutionTimeTracker;

namespace DecibinaryNumbers {
    class Program {
        static void Main(string[] args) {
            // TT.E(() => Solution.decibinaryNumbers(1), 0);
            // TT.E(() => Solution.decibinaryNumbers(2), 1);
            // TT.E(() => Solution.decibinaryNumbers(3), 2);
            // TT.E(() => Solution.decibinaryNumbers(4), 10);
            // TT.E(() => Solution.decibinaryNumbers(10), 100);

            Console.Write("000 - 010:\t");
            for (var x = 0; x < 1110; x++) {
                if (x != 0 && x % 10 == 0) {
                    Console.WriteLine();
                    Console.Write($"{x:D3} - {(x + 10):D3}:\t");
                }
                Console.Write(Solution.dbValue(x) + "\t");
            }
        }
    }
}
