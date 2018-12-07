using System.Text;
namespace Abbreviation {
    /// TBD
    public static class LoopsSolution {
        public static string abbreviation(string a, string b) {
            var dp = new bool?[a.Length + 1, b.Length + 1];
            var result = false;

            var ai = 0;
            var bi = 0;
            while (ai <= a.Length) {
                while (bi <= b.Length) {
                    if (ai == a.Length && bi == b.Length) {
                        dp[ai, bi] = true;
                        continue;
                    }
                    if (ai == a.Length && bi < b.Length) {
                        dp[ai, bi] = false;
                        continue;
                    }

                    var ca = a[ai];
                    var cb = b[bi];

                    if (char.IsUpper(ca)) {
                        if (ca == cb) {
                            dp[ai, bi] = true;
                        }
                        else {
                            dp[ai, bi] = false;
                        }
                    }
                    else {

                    }

                    bi++;
                }
                ai++;
            }

            return result ? "YES" : "NO";
        }
    }
}