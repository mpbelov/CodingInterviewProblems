using System;

namespace MergeKSortedLists {
    class Program {
        static void Main(string[] args) {
            TT.E(() => Solution.MergeKLists(new[] {
                    ListNode.Build(new [] { 1, 4, 5 }),
                    ListNode.Build(new [] { 1, 3, 4 }),
                    ListNode.Build(new [] { 2, 6 })
                }),
                ListNode.Build(new[] { 1, 1, 2, 3, 4, 4, 5, 6 })
            );

            TT.E(() => Solution.MergeKLists(new[] { default(ListNode) }), default(ListNode));

            TT.E(() => Solution.MergeKLists(new[] { 
                    default(ListNode), 
                    ListNode.Build(new[] { 1 })
                }), ListNode.Build(new[] { 1 }));
        }
    }
}
