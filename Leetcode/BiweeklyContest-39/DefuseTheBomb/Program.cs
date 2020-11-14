using System;

namespace DefuseTheBomb {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(string.Join(",", Decrypt(new int[] { 5, 7, 1, 4 }, 3)));
        }

        // https://leetcode.com/problems/defuse-the-bomb/
        static int[] Decrypt(int[] code, int k) {
            var newCode = new int[code.Length];

            if (k > 0) {
                for (int i = 0; i < newCode.Length; i++) {
                    int sum = 0;
                    int nextIndex = i + 1;
                    int left = k;
                    while (left-- > 0) {
                        if (nextIndex == code.Length) {
                            nextIndex = 0;
                        }
                        sum += code[nextIndex++];
                    }
                    newCode[i] = sum;
                }
            }
            else if (k < 0) {
                for (int i = 0; i < newCode.Length; i++) {
                    int sum = 0;
                    int nextIndex = i - 1;
                    int left = k;
                    while (left++ < 0) {
                        if (nextIndex == -1) {
                            nextIndex = code.Length - 1;
                        }
                        sum += code[nextIndex--];
                    }
                    newCode[i] = sum;
                }
            }
            else {
                for (int i = 0; i < newCode.Length; i++) {
                    newCode[i] = 0;
                }
            }
            return newCode;
        }
    }
}
