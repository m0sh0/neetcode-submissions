public class Solution {
    public bool IsValid(string s) {
        if (string.IsNullOrEmpty(s) || s.Length % 2 != 0) return false;

        Stack<char> openBrackets = new();
        foreach(char bracket in s) {
            if (bracket == '(' || bracket == '{' || bracket == '[') {
                openBrackets.Push(bracket);
            }
            else if (openBrackets.Count > 0 && ((bracket == ')' && openBrackets.Peek() == '(') ||
                    (bracket == ']' && openBrackets.Peek() == '[') ||
                    (bracket == '}' && openBrackets.Peek() == '{'))) {
                openBrackets.Pop();
            }
            else {
                return false;
            }
        }
        return openBrackets.Count == 0;
    }
}
