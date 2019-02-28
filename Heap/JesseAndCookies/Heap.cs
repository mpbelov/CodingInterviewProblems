namespace JesseAndCookies {
    public class Heap {
        public Heap(int size) {
            arr = new int[size + 1];
            Count = 0;
        }

        private int[] arr;
        public int Count { get; private set; }

        public void Add(int value) {
            arr[++Count] = value;
            rise(Count);
        }

        public int GetAndRemoveMin() {
            var min = arr[1];
            swap(1, Count);
            arr[Count--] = 0;
            sink(1);
            return min;
        }

        private void swap(int i, int j) {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        private void sink(int i) {
            while (i * 2 <= Count) {
                var smallestChildIndex = i * 2;
                if (i * 2 + 1 <= Count) {
                    var child2Index = i * 2 + 1;
                    smallestChildIndex = arr[smallestChildIndex] < arr[child2Index]
                        ? smallestChildIndex
                        : child2Index;
                }
                if (arr[i] > arr[smallestChildIndex]) {
                    swap(i, smallestChildIndex);
                    i = smallestChildIndex;
                }
                else {
                    break;
                }
            }
        }

        private void rise(int i) {
            while (i > 1 && arr[i / 2] > arr[i]) {
                swap(i, i / 2);
                i /= 2;
            }
        }
    }
}