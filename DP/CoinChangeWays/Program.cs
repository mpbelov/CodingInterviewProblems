using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExecutionTimeTracker;

namespace Coins {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(TimeTracker.Execute(() => { Console.WriteLine(getWays(4, new long[] { 1, 2, 3 })); }).TotalSeconds);
            Console.WriteLine(TimeTracker.Execute(() => { Console.WriteLine(getWays(10, new long[] { 2, 5, 3, 6 })); }).TotalSeconds);
            Console.WriteLine(TimeTracker.Execute(() => { Console.WriteLine(getWays(166, new long[] { 5, 37, 8, 39, 33, 17, 22, 32, 13, 7, 10, 35, 40, 2, 43, 49, 46, 19, 41, 1, 12, 11, 28 })); }).TotalSeconds);
            // Console.WriteLine(TimeTracker.Execute(() => { Console.WriteLine(getWays(250, new long[] { 41, 34, 46, 9, 37, 32, 42, 21, 7, 13, 1, 24, 3, 43, 2, 23, 8, 45, 19, 30, 29, 18, 35, 11 })); }).TotalSeconds);
        }

        public static long getWays(long n, long[] c) {
            var p = new Problem {
                c = c,
                n = n,
            };

            Array.Sort(c, (i1, i2) => i2.CompareTo(i1));

            for (int i = 0; i < c.Length; i++) {
                // f(i, c[i], new List<long>() { c[i] });
                p.f(i, c[i]);
            }

            // foreach(var set in res) {
            //     Console.WriteLine(string.Join(" ", set));
            // }

            return p.count;

            // var numways = new long[c.Length + 1];
            // numways[0] = 1;

            // for (var i = 0; i < c.Length; i++) {
            //     for (var j = c[i]; j <= n; j++) {
            //         numways[j] += numways[j - c[i]];
            //     }
            // }
            // return numways[n];
        }

        class Problem {
            public long count = 0;
            public long n;
            public long[] c;
            // var res = new List<List<long>>();


            // public void f(int start, long sum, List<long> set) {
            public bool f(int start, long sum) {
                if (sum == n) {
                    count++;
                    // res.Add(set);
                    return false;
                }
                else if (sum > n) {
                    return false;
                }
                for (int i = start; i < c.Length; i++) {
                    if (i + 1 == c.Length) { // last element
                        var amountLeft = n - sum;
                        if (amountLeft >= c[i] && amountLeft % c[i] == 0) {
                            count++;
                        }
                        break;
                    }
                    // var set1 = set.ToList();
                    // set1.Add(c[i]);
                    // f(i, sum + c[i], set1);
                    f(i, sum + c[i]);
                    // if (!f(i, sum + c[i])) {
                    //     break;
                    // }
                }
                return true;
            }
        }
    }
}
