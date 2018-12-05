using System.Text;
namespace Abbreviation {
    public static class RecursionSolution {
        public static string abbreviation(string a, string b) {
            var result = abbreviation1(a, b);
            return result ? "YES" : "NO";
        }

        private static bool abbreviation1(string a, string b) {
            if (a.Length == 0 && b.Length == 0) {
                return true;
            }
            if (a.Length == 0 && b.Length > 0) {
                return false;
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
                    return abbreviation1(a.Remove(0, 1), b.Remove(0, 1));
                }
                else {
                    return false;
                }
            }
            else { // a is lower
                if (char.ToUpper(ca) == cb) {
                    var res1 = abbreviation1(a.Remove(0, 1), b.Remove(0, 1));
                    var res2 = abbreviation1(a.Remove(0, 1), b);
                    return res1 | res2;
                }
                else {
                    return abbreviation1(a.Remove(0, 1), b);
                }
            }
        }
    }
}