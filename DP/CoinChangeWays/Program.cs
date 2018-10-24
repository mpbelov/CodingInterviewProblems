using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExecutionTimeTracker;

namespace CoinChangeWays {
    class Program {
        static void Main(string[] args) {
            // Console.WriteLine(TimeTracker.Execute(() => { Console.WriteLine(Recursion.GetWays(4, new long[] { 1, 2, 3 })); }).TotalSeconds);
            // Console.WriteLine(TimeTracker.Execute(() => { Console.WriteLine(Recursion.GetWays(10, new long[] { 2, 5, 3, 6 })); }).TotalSeconds);
            // Console.WriteLine(TimeTracker.Execute(() => { Console.WriteLine(Recursion.GetWays(166, new long[] { 5, 37, 8, 39, 33, 17, 22, 32, 13, 7, 10, 35, 40, 2, 43, 49, 46, 19, 41, 1, 12, 11, 28 })); }).TotalSeconds);
            // Console.WriteLine(TimeTracker.Execute(() => { Console.WriteLine(Recursion.GetWays(250, new long[] { 41, 34, 46, 9, 37, 32, 42, 21, 7, 13, 1, 24, 3, 43, 2, 23, 8, 45, 19, 30, 29, 18, 35, 11 })); }).TotalSeconds);

            // Console.WriteLine(TimeTracker.Execute(() => { Console.WriteLine(Recursion2.GetWays(4, new long[] { 1, 2, 3 })); }).TotalSeconds);
            // Console.WriteLine(TimeTracker.Execute(() => { Console.WriteLine(Recursion2.GetWays(10, new long[] { 2, 5, 3, 6 })); }).TotalSeconds);
            // Console.WriteLine(TimeTracker.Execute(() => { Console.WriteLine(Recursion2.GetWays(166, new long[] { 5, 37, 8, 39, 33, 17, 22, 32, 13, 7, 10, 35, 40, 2, 43, 49, 46, 19, 41, 1, 12, 11, 28 })); }).TotalSeconds);
            // Console.WriteLine(TimeTracker.Execute(() => { Console.WriteLine(Recursion2.GetWays(250, new long[] { 41, 34, 46, 9, 37, 32, 42, 21, 7, 13, 1, 24, 3, 43, 2, 23, 8, 45, 19, 30, 29, 18, 35, 11 })); }).TotalSeconds);

            Console.WriteLine(TimeTracker.Execute(() => { Console.WriteLine(RecursionWithMemoization.GetWays(4, new long[] { 1, 2, 3 })); }).TotalSeconds);
            Console.WriteLine(TimeTracker.Execute(() => { Console.WriteLine(RecursionWithMemoization.GetWays(10, new long[] { 2, 5, 3, 6 })); }).TotalSeconds);
            Console.WriteLine(TimeTracker.Execute(() => { Console.WriteLine(RecursionWithMemoization.GetWays(166, new long[] { 5, 37, 8, 39, 33, 17, 22, 32, 13, 7, 10, 35, 40, 2, 43, 49, 46, 19, 41, 1, 12, 11, 28 })); }).TotalSeconds);
            Console.WriteLine(TimeTracker.Execute(() => { Console.WriteLine(RecursionWithMemoization.GetWays(250, new long[] { 41, 34, 46, 9, 37, 32, 42, 21, 7, 13, 1, 24, 3, 43, 2, 23, 8, 45, 19, 30, 29, 18, 35, 11 })); }).TotalSeconds);
        }
    }
}
