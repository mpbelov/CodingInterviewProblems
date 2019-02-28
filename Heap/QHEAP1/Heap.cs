using System;

namespace QHEAP1 {
    public class Heap<T> where T : IComparable {
        public Heap(int size = 3) {
            storage = new T[size];
            Count = 0;
        }

        private T[] storage;

        public void Insert(T key) {
            resizeArrayIfNeeded();
            storage[++Count] = key;
            rise(Count);
        }

        public T GetMin() {
            var min = default(T);
            if (Count > 0) {
                min = storage[1];
            }
            return min;
        }

        public T GetAndRemoveMin() {
            var min = default(T);
            if (Count > 0) {
                min = storage[1];
            }

            remove(1);
            return min;
        }

        public void Remove(T key) {
            for (int i = 1; i <= Count; i++) {
                if (key.CompareTo(storage[i]) == 0) {
                    remove(i);
                    return;
                }
            }
        }

        private void remove(int i) {
            swap(i, Count);
            storage[Count--] = default(T);
            sink(i);
        }

        private void rise(int i) {
            while (i > 1 && storage[i / 2].CompareTo(storage[i]) > 0) {
                swap(i / 2, i);
                i = i / 2;
            }
        }

        private void sink(int i) {
            while (i * 2 <= Count) {
                var smallestChildIndex = i * 2;
                if (i * 2 + 1 <= Count) {
                    var child2Index = i * 2 + 1;
                    smallestChildIndex = storage[smallestChildIndex].CompareTo(storage[child2Index]) < 0
                        ? smallestChildIndex
                        : child2Index;
                }
                if (storage[i].CompareTo(storage[smallestChildIndex]) > 0) {
                    swap(i, smallestChildIndex);
                    i = smallestChildIndex;
                }
                else {
                    break;
                }
            }
        }

        private bool bigger(int parentIndex, int currentIndex) {
            return storage[parentIndex].CompareTo(storage[currentIndex]) > 0;
        }

        public int Count { get; private set; }

        private void resizeArrayIfNeeded() {
            if (storage.Length - Count <= 1) {
                var newStorage = new T[storage.Length * 2];
                for (int i = 0; i <= Count; i++) {
                    newStorage[i] = storage[i];
                }
                storage = newStorage;
            }
        }

        private void swap(int i, int j) {
            var temp = storage[i];
            storage[i] = storage[j];
            storage[j] = temp;
        }
    }
}