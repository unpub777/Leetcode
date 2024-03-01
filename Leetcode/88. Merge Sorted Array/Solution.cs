namespace Leetcode._88._Merge_Sorted_Array;

public class Solution
{
    // https://leetcode.com/problems/merge-sorted-array/description/
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (m == 0)
        {
            for (var i = 0; i < n; i++)
            {
                nums1[i] = nums2[i];
            }
        }
        else if (n != 0)
        {
            var i = m - 1;
            var j = n - 1;
            var k = m + n - 1;

            while (j >= 0)
            {
                nums1[k--] = i >= 0 && nums1[i] >= nums2[j] ? nums1[i--] : nums2[j--];
            }
        }
    }
}