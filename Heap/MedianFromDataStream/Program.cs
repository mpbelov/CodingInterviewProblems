using System;

namespace MedianFromDataStream {
    class Program {
        static void Main(string[] args) {
            var obj = new MedianFinder();
            obj.AddNum(1);
            obj.AddNum(2);
            TT.E(() => obj.FindMedian(), 1.5);
            obj.AddNum(3);
            TT.E(() => obj.FindMedian(), 2);

            Console.WriteLine();
            obj = new MedianFinder();
            obj.AddNum(3);
            obj.AddNum(2);
            TT.E(() => obj.FindMedian(), 2.5);
            obj.AddNum(1);
            TT.E(() => obj.FindMedian(), 2);

            Console.WriteLine();
            obj = new MedianFinder();
            obj.AddNum(-1);
            obj.AddNum(-2);
            TT.E(() => obj.FindMedian(), -1.5);
            obj.AddNum(-3);
            TT.E(() => obj.FindMedian(), -2);
        }
    }
}
