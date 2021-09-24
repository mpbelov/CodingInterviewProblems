namespace ClimbingStairs {
    public class Solution {
        public int ClimbStairs(int n) {
            return ClimbStairs(n, new int?[n + 1, 3]);
        }

        public int ClimbStairs(int n, int?[,] memo) {
            if (n == 0) {
                return 0;
            }
            if (n == 1) {
                return 1;
            }
            if (n == 2) {
                return 2;
            }

            var num = 0;
            if (memo[n, 1].HasValue) {
                num += memo[n, 1].Value;
            }
            else {
                var res = ClimbStairs(n - 1, memo); // num of steps    
                memo[n, 1] = res;
                num += res;
            }
            if (memo[n, 2].HasValue) {
                num += memo[n, 2].Value;
            }
            else {
                var res = ClimbStairs(n - 2, memo); // num of steps    
                memo[n, 2] = res;
                num += res;
            }

            return num;
        }
    }
}
