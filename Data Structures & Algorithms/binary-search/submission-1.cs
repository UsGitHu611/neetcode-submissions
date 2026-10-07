public class Solution {
    public int BinarySearch(int[] nums, int target, int i, int j) {
        if (i > j)
            return -1;
        int middle = i + (j - i) / 2;
        if (nums[middle] == target)
            return middle;
        if (nums[middle] < target)
            return BinarySearch(nums, target, middle + 1, j);
        else
            return BinarySearch(nums, target, i, middle - 1);
    }
    public int Search(int[] nums, int target) {
        return BinarySearch(nums, target, 0, nums.Length - 1);
    }
}
