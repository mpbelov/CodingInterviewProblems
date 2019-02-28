namespace JesseAndCookies {
    public static class Solution {
        public static int cookies(int k, int[] A) {
            var heap = new Heap(A.Length);
            for (int i = 0; i < A.Length; i++) {
                heap.Add(A[i]);
            }


            var operaions = 0;
            var min1 = heap.GetAndRemoveMin();
            while (min1 < k && heap.Count > 0) {
                var min2 = heap.GetAndRemoveMin();
                var newCookie = min1 + 2 * min2;
                heap.Add(newCookie);
                operaions++;
                min1 = heap.GetAndRemoveMin();
            }

            return min1 < k
                ? -1
                : operaions;
        }
    }
}