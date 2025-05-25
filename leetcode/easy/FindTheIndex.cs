// https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/description/

public class Solution
{
    public int StrStr(string haystack, string needle)
    {
        int n = haystack.Length;
        int m = needle.Length;

        for (int i = 0; i <= n - m; i++)
        {
            string sub = haystack.Substring(i, m);
            if (sub == needle)
            {
                return i;
            }
        }
        return -1;
    }
}

// Another approach using built-in method
public class Solution {
    public int StrStr(string haystack, string needle) {
        return haystack.IndexOf(needle);
    }
}