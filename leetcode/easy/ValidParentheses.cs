// https://leetcode.com/problems/valid-parentheses/description/

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(') stack.Push(')');
            else if (c == '{') stack.Push('}');
            else if (c == '[') stack.Push(']');
            else
            {
                if (stack.Count == 0 || stack.Pop() != c)
                    return false;
            }
        }

        return stack.Count == 0;
    }
}

// Another solution using Dictionary

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> brackets = new Stack<char>();
        Dictionary<char, char> pairs = new Dictionary<char, char>()
        {
            {')','('},
            {'}','{'},
            {']','['}
        };

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                brackets.Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (brackets.Count == 0 || brackets.Peek() != pairs[c]) return false;

                brackets.Pop();
            }
        }

        return brackets.Count == 0;
    }
}
