using System;

namespace Collections {
    public abstract class Heap {
        protected Heap() : this(1) { }
        protected Heap(int estimatedSize) {
            Arr = new int[estimatedSize + 1];
            Count = 0;
        }

        public int Count { get; protected set; }
        protected int[] Arr;

        public void Add(int value) {
            resizeArrayIfNeeded();
            Arr[++Count] = value;
            rise(Count);
        }

        public int GetTop() {
            if (Count < 1) {
                throw new IndexOutOfRangeException("Heap is empty");
            }
            return Arr[1];
        }

        public int GetAndRemoveTop() {
            if (Count < 1) {
                throw new IndexOutOfRangeException("Heap is empty");
            }
            var min = Arr[1];
            swap(1, Count);
            Arr[Count--] = 0;
            sink(1);
            return min;
        }

        protected abstract bool NeedRise(int index);
        protected abstract bool NeedSink(int index, out int sinkToIndex);

        protected static int ParentIndex(int nodeIndex) => nodeIndex / 2;
        protected static int LeftChildIndex(int nodeIndex) => nodeIndex * 2;
        protected static int RightChildIndex(int nodeIndex) => nodeIndex * 2 + 1;

        private void rise(int index) {
            while (index > 1 && NeedRise(index)) {
                swap(ParentIndex(index), index);
                index = ParentIndex(index);
            }
        }

        private void sink(int index) {
            while (LeftChildIndex(index) <= Count) {
                if (NeedSink(index, out int sinkToIndex)) {
                    swap(index, sinkToIndex);
                    index = sinkToIndex;
                }
                else {
                    break;
                }
            }
        }

        private void swap(int i1, int i2) {
            var temp = Arr[i1];
            Arr[i1] = Arr[i2];
            Arr[i2] = temp;
        }

        private void resizeArrayIfNeeded() {
            if (Arr.Length - Count <= 1) {
                var newStorage = new int[Arr.Length * 2];
                for (int i = 0; i <= Count; i++) {
                    newStorage[i] = Arr[i];
                }
                Arr = newStorage;
            }
        }
    }

    public class MaxHeap : Heap {
        public MaxHeap() : base() { }
        public MaxHeap(int size) : base(size) { }

        protected override bool NeedRise(int index) {
            return Arr[ParentIndex(index)] < Arr[index];
        }

        protected override bool NeedSink(int i, out int sinkToIndex) {
            sinkToIndex = LeftChildIndex(i);
            if (RightChildIndex(i) <= Count) {
                sinkToIndex = Arr[sinkToIndex] > Arr[RightChildIndex(i)]
                    ? sinkToIndex
                    : RightChildIndex(i);
            }
            return Arr[i] < Arr[sinkToIndex];
        }
    }

    public class MinHeap : Heap {
        public MinHeap() : base() { }
        public MinHeap(int size) : base(size) { }

        protected override bool NeedRise(int index) {
            return Arr[ParentIndex(index)] > Arr[index];
        }

        protected override bool NeedSink(int i, out int sinkToIndex) {
            sinkToIndex = LeftChildIndex(i);
            if (RightChildIndex(i) <= Count) {
                sinkToIndex = Arr[sinkToIndex] < Arr[RightChildIndex(i)]
                    ? sinkToIndex
                    : RightChildIndex(i);
            }
            return Arr[i] > Arr[sinkToIndex];
        }
    }
}
