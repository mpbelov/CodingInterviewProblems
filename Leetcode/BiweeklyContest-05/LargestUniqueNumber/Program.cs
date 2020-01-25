using System;

namespace LargestUniqueNumber {
    class Program {
        static void Main(string[] args) {
            Console.Write(LargestUniqueNumber(new int[] { 9, 9, 8, 8 }));
        }

        public static int LargestUniqueNumber(int[] A) {
            var B = new int[1001];
            for (int i = 0; i < A.Length; i++) {
                B[A[i]]++;
            }
            for (int i = B.Length - 1; i >= 0; i--) {
                if (B[i] == 1) {
                    return i;
                }
            }
            return -1;
        }
    }
}
