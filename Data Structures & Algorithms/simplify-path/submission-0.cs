public class Solution {
    public string SimplifyPath(string path) {
        Stack<string> stack = new Stack<string>();
        string tempPath = string.Empty;
        path += "/";
        for (int i = 1; i < path.Length; i++) {
            if (path[i] == '/') {
                if (tempPath == "..") {
                    if (stack.Count > 0) stack.Pop();
                } else if (tempPath != "" && tempPath != ".") {
                    stack.Push(tempPath);
                }
                tempPath = "";
            } else {
                tempPath += path[i];
            }
        }
        List<string> result = new List<string>(stack);
        result.Reverse();
        return "/" + string.Join("/", result);
    }
}