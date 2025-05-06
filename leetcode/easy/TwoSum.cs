// https://leetcode.com/problems/two-sum/description/

public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (i != j && nums[i]  + nums[j] == target)  
                {
                    return new int[] {i, j};
                }
            }
        }
        throw new ArgumentException("No two sum solution found");
    }
}

// Efficient solution using a dictionary to store the indices of the numbers

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complemento = target - nums[i];

            if (seen.ContainsKey(complemento)) {
                return new int[] { seen[complemento], i };
            }
            seen[nums[i]] = i;
        }

        throw new ArgumentException("No two sum solution found");
    }
}