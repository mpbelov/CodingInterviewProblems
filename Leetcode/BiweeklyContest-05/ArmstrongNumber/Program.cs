using System;

namespace ArmstrongNumber {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(IsArmstrong(100000000 - 1));
        }

        public static bool IsArmstrong(int N) {
            var s = N.ToString();
            int test = 0;
            var k = s.Length;
            foreach (var c in s) {
                var cInt = (int)(c - '0');
                test += Pow(cInt, k);
            }
            return test == N;
        }

        public static int Pow(int a, int b) {
            var pow = 1;
            for (int i = 0; i < b; i++) {
                pow *= a;
            }
            return pow;
        }
    }
}
