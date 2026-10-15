public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> pairsS = new Dictionary<char, char>();
        Dictionary<char, char> pairsT = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++) {
            if (pairsS.ContainsKey(s[i]) && pairsS[s[i]] != t[i] 
                || pairsT.ContainsKey(t[i]) && pairsT[t[i]] != s[i]) {
                return false;
            }
            pairsS[s[i]] = t[i];
            pairsT[t[i]] = s[i];
        }
        return true;
    }
}