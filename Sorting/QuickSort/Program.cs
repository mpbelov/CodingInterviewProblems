using System;

namespace QuickSort {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(string.Join(",", QuickSort.Sort(new int[] { 18, 5, 7, 7, 55, 3, 80, 48, 3 })));
        }
    }
}
