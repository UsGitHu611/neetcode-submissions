public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

        foreach (string str in strs) {
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            string sortedS = new string(charArray);

            if (!words.ContainsKey(sortedS)) {
                words[sortedS] = new List<string>();
            }
            words[sortedS].Add(str);
        }
        return words.Values.ToList();
    }
}
