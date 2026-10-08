public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (!dict.ContainsKey(num)) {
                dict.Add(num, 1);
            } else {
                dict[num]++;
            }
        }
        return dict
            .OrderByDescending(kvp => kvp.Value)
            .Take(k)
            .Select(kvp => kvp.Key)
            .ToArray();
    }
}
