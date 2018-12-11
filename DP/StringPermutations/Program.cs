using System;

namespace StringPermutations {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(string.Join(" ", RecursiveSolution.GetPermutations(""))); // ""
            Console.WriteLine(string.Join(" ", RecursiveSolution.GetPermutations("a"))); // a
            Console.WriteLine(string.Join(" ", RecursiveSolution.GetPermutations("ab"))); // ab ba
            Console.WriteLine(string.Join(" ", RecursiveSolution.GetPermutations("abc"))); // abc bac bca acb cab cba
        }
    }
}
