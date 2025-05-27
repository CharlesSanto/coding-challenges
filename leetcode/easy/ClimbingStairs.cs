// https://leetcode.com/problems/climbing-stairs/description/

public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n <= 2) return n;

        int a = 1;
        int b = 2;
        int steps = 0;

        for (int i = 3; i <= n; i++)
        {
            steps = a + b;
            a = b;
            b = steps;
        }

        return steps;
    }
}