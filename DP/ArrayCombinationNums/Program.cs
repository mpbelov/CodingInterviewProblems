using System;

namespace ArrayCombinationNums {
    class Program {
        static void Main(string[] args) {
            // Console.WriteLine(MemoizationSolution.numWays(maxNumber: 3, length: 4, lastNumber: 2)); //1
            // Console.WriteLine(MemoizationSolution.numWays(maxNumber: 3, length: 3, lastNumber: 3)); //1
            // Console.WriteLine(MemoizationSolution.numWays(maxNumber: 4, length: 3, lastNumber: 3)); //2
            // Console.WriteLine(MemoizationSolution.numWays(maxNumber: 4, length: 4, lastNumber: 3)); //9
            // Console.WriteLine(MemoizationSolution.numWays(maxNumber: 5, length: 5, lastNumber: 3)); //80
            // Console.WriteLine(MemoizationSolution.numWays(maxNumber: 15, length: 50, lastNumber: 3)); //80
            Console.WriteLine(MemoizationSolution.numWays(maxNumber: 99, length: 761, lastNumber: 1)); //80
        }
    }
}
