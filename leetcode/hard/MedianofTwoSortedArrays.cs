// https://leetcode.com/problems/median-of-two-sorted-arrays/description/?source=submission-noac

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {

        int[] merge = nums1.Concat(nums2).ToArray();
        Array.Sort(merge);

        int mid = merge.Length / 2;

        if (merge.Length % 2 != 0)
        {
            return merge[mid];
        } else 
        {
            return (merge[mid - 1] + merge[mid]) / 2.0;
        }

    }
}