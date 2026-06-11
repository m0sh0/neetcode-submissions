public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if (numbers == null || numbers.Length == 0) {
            return new int[] {};
        }

        int left = 0, right = numbers.Length - 1, sum = 0;

        while(left < right) {
            sum = numbers[left] + numbers[right];

            if (sum == target) {
                return new int[] { left + 1, right + 1 };
            }
            else if (sum > target) {
                right--;
            }
            else {
                left++;
            }

        }

        return new int[] {};
    }
}
