public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if (numbers == null || numbers.Length == 0) {
            return new int[] {};
        }

        int left = 0, right = numbers.Length - 1, sum = 0;

        while(left < right) {
            sum = numbers[left] + numbers[right];

            if (sum > target) {
                right --;
            } 
            else if (sum < target) {
                left ++;
            }
            else {
                return new int[] { left + 1, right + 1 };
            }
        }

        return new int[] {};
    }
}
