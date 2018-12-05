using System.Text;
namespace Abbreviation {
    public static class RecursionSolution {
        public static string abbreviation(string a, string b) {
            var result = abbreviation1(a, b, new bool?[a.Length + 1, b.Length + 1]);
            return result ? "YES" : "NO";
        }

        private static bool abbreviation1(string a, string b, bool?[,] dp) {
            if (a.Length == 0 && b.Length == 0) {
                return true;
            }
            if (a.Length == 0 && b.Length > 0) {
                return false;
            }

            var r = dp[a.Length, b.Length];
            if (r.HasValue) {
                return r.Value;
            }

            if (a.Length > 0 && b.Length == 0) {
                for (int i = 0; i < a.Length; i++) {
                    if (char.IsUpper(a[i])) {
                        return false;
                    }
                }
                return true;
            }

            var ca = a[0];
            var cb = b[0];

            if (char.IsUpper(ca)) {
                if (ca == cb) {
                    var result = abbreviation1(a.Remove(0, 1), b.Remove(0, 1), dp);
                    dp[a.Length, b.Length] = result;
                    return result;
                }
                else {
                    dp[a.Length, b.Length] = false;
                    return false;
                }
            }
            else { // a is lower
                if (char.ToUpper(ca) == cb) {
                    var res1 = abbreviation1(a.Remove(0, 1), b.Remove(0, 1), dp);
                    var res2 = abbreviation1(a.Remove(0, 1), b, dp);
                    dp[a.Length, b.Length] = res1 | res2;
                    return res1 | res2;
                }
                else {
                    var result = abbreviation1(a.Remove(0, 1), b, dp);
                    dp[a.Length, b.Length] = result;
                    return result;
                }
            }
        }
    }
}