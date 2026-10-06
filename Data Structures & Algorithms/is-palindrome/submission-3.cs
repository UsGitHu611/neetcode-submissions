public class Solution {
    public bool IsPalindrome(string s) {
        string result = String.Empty;
        foreach (char ch in s) {
            if (char.IsLetterOrDigit(ch)) {
                result += char.ToLower(ch);
            }
        }
        return result == new string(result.Reverse().ToArray());
    }
}   
