public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Key: array value, Value: original index
        var seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int needed = target - nums[i];

            if (seen.ContainsKey(needed)) {
                return new int[] { seen[needed], i };
            }

            // Store current number and its index (handles duplicates correctly)
            seen[nums[i]] = i;
        }

        return new int[0];
    }
}