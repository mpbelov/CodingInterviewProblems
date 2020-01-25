using System;

namespace _5155_Rank_Transform_of_an_Array {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution {
        public int[] ArrayRankTransform(int[] arr) {
            var rankedArr = new int[arr.Length];

            var sortedArr = new int[arr.Length];
            arr.CopyTo(sortedArr, 0);
            Array.Sort(sortedArr);

            var map = new System.Collections.Generic.Dictionary<int, int>(arr.Length);
            int currentRank = 1;
            for (int i = 0; i < arr.Length; i++) {
                if (!map.ContainsKey(sortedArr[i])) {
                    map.Add(sortedArr[i], currentRank++);
                }
            }

            for (int i = 0; i < arr.Length; i++) {
                rankedArr[i] = map[arr[i]];
            }
            return rankedArr;
        }

        public string BreakPalindrome(string palindrome) {
            if (palindrome.Length == 1) {
                return string.Empty;
            }

            var sb = new System.Text.StringBuilder(palindrome);
            for (int i = 0; i < sb.Length / 2; i++) {
                if (sb[i] != 'a') {
                    sb[i] = 'a';
                    return sb.ToString();
                }
            }
            sb[sb.Length - 1] = 'b';
            return sb.ToString();
        }

        public int[][] DiagonalSort(int[][] mat) {
            var m = mat.Length;
            var n = mat[0].Length;
            var sortedMat = new int[m][];

            for (int i = 0; i < mat.Length; i++) {
                sortedMat[i] = new int[n];
            }

            for (var initM = 0; initM < m; initM++) {
                var initN = 0;
                var arrDiag = new System.Collections.Generic.List<int>(Math.Min(m, n));
                for (int i = 0; (initN + i) < n && (initM + i) < m; i++) {
                    arrDiag.Add(mat[initM + i][initN + i]);
                }
                arrDiag.Sort();
                for (int i = 0; i < arrDiag.Count; i++) {
                    sortedMat[initM + i][initN + i] = arrDiag[i];
                }
            }
            for (int initN = 1; initN < n; initN++) {
                var initM = 0;
                var arrDiag = new System.Collections.Generic.List<int>(Math.Min(m, n));
                for (int i = 0; (initN + i) < n && (initM + i) < m; i++) {
                    arrDiag.Add(mat[initM + i][initN + i]);
                }
                arrDiag.Sort();
                for (int i = 0; i < arrDiag.Count; i++) {
                    sortedMat[initM + i][initN + i] = arrDiag[i];
                }
            }
            return sortedMat;
        }
    }
}
