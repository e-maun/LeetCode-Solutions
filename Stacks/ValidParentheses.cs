public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

foreach (char c in s)
{
    //enter the opening brackets into the stack
    if (c == '(' || c == '[' || c == '{')
    {
        stack.Push(c);
    }
    //check if the closing brackets match the opening brackets in the stack
    if (c == ')' || c == ']' || c == '}')
    {
        if (stack.Count != 0)
        {
            if (c == ')' && stack.Peek() == '(')
            {
                stack.Pop();
            }
            else if (c == ']' && stack.Peek() == '[')
            {
                stack.Pop();
            }
            else if (c == '}' && stack.Peek() == '{')
            {
                stack.Pop();
            }
            else         
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}
    return stack.Count == 0;
        
    }
}
