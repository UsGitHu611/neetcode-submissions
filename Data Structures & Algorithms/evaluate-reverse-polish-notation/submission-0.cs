public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < tokens.Length; i++) {
            if (tokens[i] == "+") {
                stack.Push(stack.Pop() + stack.Pop());
            } else if (tokens[i] == "-") {
                int less = stack.Pop();
                int large = stack.Pop();
                stack.Push(large - less);
            } else if (tokens[i] == "*") {
                stack.Push(stack.Pop() * stack.Pop());
            } else if (tokens[i] == "/") {
                int f = stack.Pop();
                int s = stack.Pop();
                stack.Push((int)((double)s / f));
            } else {
                stack.Push(int.Parse(tokens[i]));
            }
        }
        return stack.Pop();
    }
}
