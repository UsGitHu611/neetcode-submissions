public class Solution {
    public int LengthOfLastWord(string s) {
        int resultLength = 0, k = s.Length - 1;
        while (k >= 0 && char.IsWhiteSpace(s[k])) k--;
        while (k >= 0 && char.IsLetter(s[k])) {
            resultLength++;
            k--;
        }
        return resultLength;
    }
}