namespace IntToRoman {
    class Program {
        static void Main(string[] args) {
            // https://leetcode.com/problems/integer-to-roman/
            
            TT.E(() => Solution.IntToRoman(3), "III");
            TT.E(() => Solution.IntToRoman(4), "IV");
            TT.E(() => Solution.IntToRoman(9), "IX");
            TT.E(() => Solution.IntToRoman(58), "LVIII");
            TT.E(() => Solution.IntToRoman(1994), "MCMXCIV");
        }
    }
}
