namespace Leetcode._27._Remove_Element;

public class Solution
{
    // https://leetcode.com/problems/remove-element/description/
    public static int RemoveElement(int[] nums, int val)
    {
        var i = 0;
        var j = nums.Length - 1;

        while (i <= j)
        {
            if (nums[j]== val)
            {
                j--;
            }
            else if (nums[i] == val)
            {
                nums[i++] = nums[j--];
            }
            else
            {
                i++;
            }
        }

        return j + 1;
    }
}