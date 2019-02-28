using System;
using ExecutionTimeTracker;

namespace JesseAndCookies {
    class Program {
        static void Main(string[] args) {
            TT.E(() => Solution.cookies(7, new[] { 1, 2, 3, 9, 10, 12 }), 2);
            TT.E(() => Solution.cookies(90, new[] { 13, 47, 74, 12, 89, 74, 18, 38 }), 5);
        }
    }
}
