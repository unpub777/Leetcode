using System;

namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums1 = new[] { 1, 2, 3, 0, 0, 0 };
            var m = 3;
            var nums2 = new[] { 2, 5, 6 };
            var n = 3;

            Leetcode._88._Merge_Sorted_Array.Solution.Merge(nums1, m, nums2, n);

            Console.ReadLine();
        }
    }
}
