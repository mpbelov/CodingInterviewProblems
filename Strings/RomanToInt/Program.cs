using System;

namespace RomanToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode.com/problems/roman-to-integer/
            
            TT.E(() => Solution.RomanToInt("III"), 3);
            TT.E(() => Solution.RomanToInt("IV"), 4);
            TT.E(() => Solution.RomanToInt("IX"), 9);
            TT.E(() => Solution.RomanToInt("LVIII"), 58);
            TT.E(() => Solution.RomanToInt("MCMXCIV"), 1994);
        }
    }
}
