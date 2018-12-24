using System;
using System.Collections.Generic;

namespace DecibinaryNumbers {
    public static class Solution {
        public static long decibinaryNumbers(long x) {
            return dbValue(x);
        }

        private static long[] nums100;
        private static void prepare() {
            nums100 = new long[100];
            for (int i = 0; i < 100; i++) {
                nums100[i] = dbValue(i);
            }
        }

        public static long dbValue(long x) {
            var num = x;
            var digits = new List<long>();
            while (num > 0) {
                digits.Add(num % 10);
                num /= 10;
            }
            long db = 0;
            for (int i = 0; i < digits.Count; i++) {
                db += digits[i] * (long)Math.Pow(2, i);
            }
            return db;
        }

        public static long calcDBValue(long x) {
            if (nums100 == null) {
                prepare();
            }
            var index = x % 100;
            var groupIndex = x / 100;
            return nums100[index] + 4 * groupIndex;
        }
    }
}