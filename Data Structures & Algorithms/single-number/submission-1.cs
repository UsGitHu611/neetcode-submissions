public class Solution {
    public int SingleNumber(int[] nums) {
        HashSet<int> hashSet = new HashSet<int>();
        foreach (int num in nums) {
            if (!hashSet.Remove(num)) {
                hashSet.Add(num);
            }
        }
        foreach (int item in hashSet) {
            return item;
        }
        return -1;
    }
}
