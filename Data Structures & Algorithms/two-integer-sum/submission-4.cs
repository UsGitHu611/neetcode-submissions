public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int difference = target - nums[i];
            if (dict.ContainsKey(difference)) {
                return [dict[difference], i];
            }
            dict[nums[i]] = i;
        }
        return [0];
    }
}
