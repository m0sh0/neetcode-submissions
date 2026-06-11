public class Solution {
    public int MaxArea(int[] heights) {
        if (heights == null || heights.Length == 0) {
            return 0;
        }

        int result = 0;
        int left = 0, right = heights.Length - 1;

        while (left < right) {
            int area = (right - left) * Math.Min(heights[left], heights[right]);
            result = Math.Max(result, area);

            if (heights[left] < heights[right]) {
                left++;
            }
            else {
                right--;
            }
        }
        return result;
    }
}
