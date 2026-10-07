public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> dict = new Dictionary<char, char>() {
            {')', '('},
            {'}', '{'},
            {']', '['},
        };
        for (int i = 0; i < s.Length; i++) {
            if (dict.ContainsKey(s[i])) {
                if (stack.Count > 0 && stack.Peek() == dict[s[i]]) {
                    stack.Pop();
                } else {
                    return false;
                } 
            } else {
                stack.Push(s[i]);
            }
        }
        return stack.Count == 0;
    }
}
