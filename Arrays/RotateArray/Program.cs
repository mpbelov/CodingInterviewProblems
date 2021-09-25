using System;

namespace RotateArray {
    class Program {
        static void Main(string[] args) {
            TT.E(() => new Solution().GetRotated(new[] { 1, 2, 3, 4, 5, 6, 7 }, 3), new[] { 5, 6, 7, 1, 2, 3, 4 });
            TT.E(() => new Solution().GetRotated(new[] { 1 }, 2), new[] { 1 });
        }
    }
}
