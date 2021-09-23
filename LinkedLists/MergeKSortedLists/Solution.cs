using System.Text;

namespace MergeKSortedLists {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }

        public static ListNode Build(int[] values) {
            var result = new ListNode();
            ListNode cur = result;
            for (var i = 0; i < values.Length; i++) {
                cur.val = values[i];
                if (i < values.Length - 1) {
                    cur.next = new ListNode();
                    cur = cur.next;
                }
            }
            return result;
        }

        public override bool Equals(object obj) {
            if (!(obj is ListNode listNode)) {
                return false;
            }
            ListNode left = this, right = listNode;
            while (left != null && right != null) {
                if (left.val != right.val) {
                    return false;
                }
                left = left.next;
                right = right.next;
            }
            if (left == null && right == null) {
                return true;
            }

            return false;
        }

        public override int GetHashCode() {
            return System.HashCode.Combine(val, next);
        }

        public override string ToString() {
            var sb = new StringBuilder();
            sb.Append("[");
            for (var node = this; node != null; node = node.next) {
                sb.Append(node.val);
                if (node.next != null) {
                    sb.Append(",");
                }
            }
            sb.Append("]");
            return sb.ToString();
        }
    }

    public static class Solution {
        public static ListNode MergeKListsBruteforce(ListNode[] lists) {
            var result = new System.Collections.Generic.List<int>();
            foreach (var list in lists) {
                for (var node = list; node != null; node = node.next) {
                    result.Add(node.val);
                }
            }
            result.Sort();

            return ListNode.Build(result.ToArray());
        }

        public static ListNode MergeKLists(ListNode[] lists) {
            if (lists.Length == 0) {
                return null;
            }
            var listsNotEmpty = false;
            foreach (var list in lists) {
                listsNotEmpty |= list != null;
            }
            if (!listsNotEmpty) {
                return null;
            }

            var result = default(ListNode);
            var current = result;
            var listsLeft = lists.Length;
            while (listsLeft > 0) {
                var minVal = int.MaxValue;
                var minIndex = -1;

                for (int i = 0; i < lists.Length; i++) {
                    var list = lists[i];
                    if (list != null) {
                        if (minVal >= list.val) {
                            minVal = list.val;
                            minIndex = i;
                        }
                    }
                }

                if (minIndex == -1) {
                    break;
                }

                if (lists[minIndex] != null) {
                    lists[minIndex] = lists[minIndex].next;
                    if (lists[minIndex] == null) {
                        listsLeft--;
                    }
                }

                if (result == null) {
                    result = new ListNode(minVal);
                    current = result;
                } else {
                    current.next = new ListNode(minVal);
                    current = current.next;
                }
            }
            return result;
        }
    }
}
