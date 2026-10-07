public class Solution {
    public int Search(int[] nums, int target) {
        int i = 0, j = nums.Length - 1;
        while (i <= j) {
            int middle = i + (j - i) / 2;
            if (nums[middle] > target) {
                j = middle - 1;
            } else if (nums[middle] < target) {
                i = middle + 1;
            } else {
                return middle;
            }
        }
        return -1;
    }
}   
