using System;

namespace _5112_Hexspeak {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(ToHexspeak("257"));
            Console.WriteLine(ToHexspeak("3"));
        }

        public static string ToHexspeak(string num) {
            var sb = new System.Text.StringBuilder(num.Length);
            var numI = int.Parse(num);
            var remainder = numI % 16;
            var result = (int)(numI / 16);
            try {
                while (true) {
                    sb.Append(Map(remainder));
                    if (result == 0) {
                        break;
                    }
                    remainder = result % 16;
                    result = (int)(result / 16);
                }
            }
            catch {
                return "ERROR";
            }
            var res = new System.Text.StringBuilder(sb.Length);
            for (int i = sb.Length - 1; i >= 0; i--) {
                res.Append(sb[i]);
            }
            return res.ToString();
        }

        public static string Map(int decS) {
            switch (decS) {
                case 0: return "O";
                case 1: return "I";
                case 10: return "A";
                case 11: return "B";
                case 12: return "C";
                case 13: return "D";
                case 14: return "E";
                case 15: return "F";
                default: throw new Exception();
            }
        }
    }
}