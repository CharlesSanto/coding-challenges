// https://leetcode.com/problems/longest-common-prefix/description/

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return "";

        string menor = strs[0];
        foreach (string s in strs)
        {
            if (s.Length < menor.Length)
                menor = s;
        }

        for (int i = 0; i < menor.Length; i++)
        {
            char c = menor[i];

            foreach (string s in strs)
            {
                if (s[i] != c)
                    return menor.Substring(0, i);
            }
        }

        return menor;
    }
}
