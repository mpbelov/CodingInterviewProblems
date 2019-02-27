using System;

namespace QHEAP1 {
    class Program {
        static void Main(string[] args) {
            var heap = new Heap<int>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++) {
                var s = Console.ReadLine();
                switch (s[0]) {
                    case '1':
                        var num = int.Parse(s.Substring(2));
                        heap.Insert(num);
                        break;
                    case '2':
                        num = int.Parse(s.Substring(2));
                        heap.Remove(num);
                        break;
                    case '3':
                        Console.WriteLine(heap.GetMin());
                        break;
                }
            }
        }
    }
}
