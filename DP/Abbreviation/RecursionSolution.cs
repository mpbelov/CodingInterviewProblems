using System.Text;
namespace Abbreviation {
    public static class RecursionSolution {
        public static string abbreviation(string a, string b) {
            var result = abbreviation(a, 0, b, 0, new bool?[a.Length + 1, b.Length + 1]);
            return result ? "YES" : "NO";
        }

        private static bool abbreviation(string a, int aIndex, string b, int bIndex, bool?[,] dp) {
            if (aIndex == a.Length && bIndex == b.Length) {
                return true;
            }
            if (aIndex == a.Length && bIndex < b.Length) {
                return false;
            }

            var r = dp[aIndex, bIndex];
            if (r.HasValue) {
                return r.Value;
            }

            if (aIndex < a.Length && bIndex == b.Length) {
                for (int i = aIndex; i < a.Length; i++) {
                    if (char.IsUpper(a[i])) {
                        return false;
                    }
                }
                return true;
            }

            var ca = a[aIndex];
            var cb = b[bIndex];

            if (char.IsUpper(ca)) {
                if (ca == cb) {
                    var result = abbreviation(a, aIndex + 1, b, bIndex + 1, dp);
                    dp[aIndex, bIndex] = result;
                    return result;
                }
                else {
                    dp[aIndex, bIndex] = false;
                    return false;
                }
            }
            else { // a is lower
                if (char.ToUpper(ca) == cb) {
                    var res1 = abbreviation(a, aIndex + 1, b, bIndex + 1, dp);
                    var res2 = abbreviation(a, aIndex + 1, b, bIndex, dp);
                    dp[aIndex, bIndex] = res1 | res2;
                    return res1 | res2;
                }
                else {
                    var result = abbreviation(a, aIndex + 1, b, bIndex, dp);
                    dp[aIndex, bIndex] = result;
                    return result;
                }
            }
        }
    }
}