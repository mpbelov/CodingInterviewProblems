using System.Collections.Generic;

namespace StringPermutations {
    public static class RecursiveSolution {
        public static IEnumerable<string> GetPermutations(string inputString) {
            if (inputString.Length <= 1) {
                yield return inputString;
                yield break;
            }

            var firstCharacter = inputString[0].ToString();
            var permutations = GetPermutations(inputString.Remove(0, 1));

            foreach (var p in permutations) {
                for (int i = 0; i <= p.Length; i++) {
                    yield return p.Insert(i, firstCharacter);
                }
            }
            yield break;
        }
    }
}