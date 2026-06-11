public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numbersByIndexes = new();

        for(int i = 0; i < nums.Length; i++) {
            int complimentaryNum = target - nums[i];
            if (numbersByIndexes.ContainsKey(complimentaryNum)) {
                return new int[] {numbersByIndexes[complimentaryNum], i};
            }
            numbersByIndexes[nums[i]] = i;
        }
        return new int[] {};
    }
}