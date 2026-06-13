public class Solution {
    public bool IsValid(string s) {
        if (string.IsNullOrEmpty(s) || s.Length % 2 != 0) {
            return false;
        }

        Stack<char> openBrackets = new();
        bool isValid = true;

        foreach(char bracket in s) {
            if (bracket == '(' || bracket == '[' || bracket == '{') {
                openBrackets.Push(bracket);
            } 
            else if (openBrackets.Count > 0 && ((bracket == ')' && openBrackets.Peek() == '(') ||
            (bracket == ']' && openBrackets.Peek() == '[') ||
            (bracket == '}' && openBrackets.Peek() == '{'))) {
               openBrackets.Pop();
            } 
            else {
                isValid = false;
                return isValid;
            }
        }
        return openBrackets.Count == 0;
    }
}