// https://leetcode.com/problems/longest-substring-without-repeating-characters/description/

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> sub = new HashSet<char>();
        int max = 0;
        int start = 0;

        for (int end = 0; end < s.Length; end++)
        {

            while (sub.Contains(s[end]))
            {
                sub.Remove(s[start]);
                start++;
            }

            sub.Add(s[end]);
            max = Math.Max(max, end - start + 1);
        }

        return max;
    }
}
