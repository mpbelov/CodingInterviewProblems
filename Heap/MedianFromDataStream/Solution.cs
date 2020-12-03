using Collections;

public class MedianFinder {
    public MedianFinder() {
        leftMaxHeap = new MaxHeap(10);
        rightMinHeap = new MinHeap(10);
    }

    Heap leftMaxHeap;
    Heap rightMinHeap;

    public void AddNum(int num) {
        var effectiveMedian = FindMedian();
        if (leftMaxHeap.Count == rightMinHeap.Count) { // median is average of the top elements
            if (num < effectiveMedian) { // goes to the left side
                leftMaxHeap.Add(num);
            }
            else {  // goes to the right side
                rightMinHeap.Add(num);
            }
        }
        else if (leftMaxHeap.Count > rightMinHeap.Count) { // median is the top of the left heap
            if (num < effectiveMedian) { // goes to the left side
                rightMinHeap.Add(leftMaxHeap.GetAndRemoveTop());
                leftMaxHeap.Add(num);
            }
            else { // goes to the right side
                rightMinHeap.Add(num);
            }
        }
        else { // if leftMaxHeap.Count < rightMinHeap.Count - median is the top of the right heap
            if (num < effectiveMedian) { // goes to the left side
                leftMaxHeap.Add(num);
            }
            else { // goes to the right side
                leftMaxHeap.Add(rightMinHeap.GetAndRemoveTop());
                rightMinHeap.Add(num);
            }
        }
    }

    public double FindMedian() {
        if (leftMaxHeap.Count == rightMinHeap.Count) {
            if (leftMaxHeap.Count == 0) return 0;
            return ((double)leftMaxHeap.GetTop() + (double)rightMinHeap.GetTop()) / 2;
        }
        else if (leftMaxHeap.Count > rightMinHeap.Count) {
            return leftMaxHeap.GetTop();
        }
        else {
            return rightMinHeap.GetTop();
        }
    }
}
