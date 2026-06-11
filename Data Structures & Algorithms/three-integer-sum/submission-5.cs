public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> res = new();
        Array.Sort(nums);
        // loop for anchor
        for (int a = 0; a < nums.Length; a++) {
            // check if anchor is 0: break
            if (nums[a] > 0) break;
            // check for duplicate number: continue
            if (a > 0 && nums[a] == nums[a - 1]) continue;

            // while loop for left and right pointers
            int left = a + 1, right = nums.Length - 1;
            while(left < right) {
                int sum = nums[a] + nums[left] + nums[right];

                if (sum > 0) {
                    right--;
                }
                else if (sum < 0) {
                    left++;
                }
                else{
                    res.Add(new List<int> {nums[a], nums[left], nums[right]});

                    left++;
                    right--;

                    // move left pointer if there is duplicate next to it
                    while(left < right && nums[left] == nums[left - 1]){
                        left++;
                    }
                }
            }
        }
        return res;
    }
}
