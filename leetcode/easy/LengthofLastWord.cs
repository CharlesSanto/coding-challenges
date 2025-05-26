// https://leetcode.com/problems/length-of-last-word/description/

public class Solution {
    public int LengthOfLastWord(string s) {

        string[] words = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        return words[^1].Length;
    }
}