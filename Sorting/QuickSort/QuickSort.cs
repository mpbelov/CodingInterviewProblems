using System;

namespace QuickSort {
    public static class QuickSort {
        public static T[] Sort<T>(T[] array) where T : IComparable {
            sort(array, 0, array.Length - 1);
            return array;
        }

        private static void sort<T>(T[] array, int l, int r) where T : IComparable {
            if (r < l) {
                return;
            }
            var j = partition(array, l, r);
            sort(array, l, j - 1);
            sort(array, j + 1, r);
        }

        private static int partition<T>(T[] array, int l, int r) where T : IComparable {
            var i = l;
            var j = r + 1;
            var v = array[l];
            while (true) {
                while (array[++i].CompareTo(v) <= 0) {
                    if (i == r) {
                        break;
                    }
                }
                while (v.CompareTo(array[--j]) <= 0) {
                    if (j == l) {
                        break;
                    }
                }
                if (i >= j) {
                    break;
                }
                swap(array, i, j);
            }
            swap(array, l, j);
            return j;
        }

        private static void swap<T>(T[] array, int i, int j) {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
