public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            dict[nums[i]] = i;
        }

        for (int i = 0; i < nums.Length; i++) {
            int difference = target - nums[i];
            if (dict.ContainsKey(difference) && dict[difference] != i) {
                return [i, dict[difference]];
            }
        }
        return [0];
    }
}
