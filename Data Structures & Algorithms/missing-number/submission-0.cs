public class Solution {
    public int MissingNumber(int[] nums) {
        int l = nums.Length;
        int s = ((1 + l) * l) / 2;
        for (int i = 0; i < nums.Length; i++) {
            s -= nums[i];
        }
        return s;
    }
}
