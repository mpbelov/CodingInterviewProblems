namespace RotateArray {
    public class Solution {
        public int[] GetRotated(int[] nums, int k) {
            Rotate(nums, k);
            return nums;
        }

        public void Rotate(int[] nums, int k) {
            k %= nums.Length;
            if (k == 0) {
                return;
            }

            for (int i = 0; i < nums.Length / 2; i++) {
                var temp = nums[i];
                nums[i] = nums[nums.Length - 1 - i];
                nums[nums.Length - 1 - i] = temp;
            }

            for (int i = 0; i < k / 2; i++) {
                var temp = nums[i];
                nums[i] = nums[k - 1 - i];
                nums[k - 1 - i] = temp;
            }

            for (int i = k; i < k + (nums.Length - k) / 2; i++) {
                var temp = nums[i];
                nums[i] = nums[nums.Length - 1 - (i - k)];
                nums[nums.Length - 1 - (i - k)] = temp;
            }
        }
    }
}