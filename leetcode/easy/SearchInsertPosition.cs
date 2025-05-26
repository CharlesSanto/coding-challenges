// https://leetcode.com/problems/search-insert-position/description/

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {

        int inicio = 0;
        int fim = nums.Length - 1;

        while (inicio <= fim)
        {
            int meio = (inicio + fim) / 2;

            if (nums[meio] == target)
            {
                return meio;
            }
            else if (nums[meio] < target)
            {
                inicio = meio + 1;
            }
            else
            {
                fim = meio - 1;
            }
        }

        return inicio;
    }
}