public class Solution {
    public int EvalRPN(string[] tokens) {
        if (tokens == null || tokens.Length == 0) return 0;

        Stack<int> stack = new();
        foreach (string token in tokens) {
            bool isNumber = int.TryParse(token, out int number);

            if (isNumber) {
                stack.Push(number);
            } 
            else {
                // check operator
                if (token == "+") {
                    stack.Push(stack.Pop() + stack.Pop());
                } 
                else if (token == "-") {
                    int a = stack.Pop(), b = stack.Pop();
                    stack.Push(b - a);
                }
                else if (token == "*") {
                    stack.Push(stack.Pop() * stack.Pop());
                }
                else if (token == "/") {
                    int a = stack.Pop(), b = stack.Pop();
                    stack.Push(b / a);
                }
            }
        }
        return stack.Peek();
    }
}
