// https://leetcode.com/problems/roman-to-integer/description/

public class Solution {
    public int RomanToInt(string s) {

        int total = 0;

        Dictionary<char, int> romanMap = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        for (int i = 0; i < s.Length; i++) {
            int current = romanMap[s[i]];
            int next = (i + 1 < s.Length) ? romanMap[s[i + 1]] : 0;

            if (current < next) {
                total -= current;
            } else {
                total += current;
            }
        }

        return total;
    }
}