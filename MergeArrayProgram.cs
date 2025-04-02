using System;

namespace MergeSortedArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums1 = new int[6] { 1, 3, 5, 0, 0, 0 };
            int m = 3;
            int[] nums2 = new int[3] { 2, 4, 6 };
            int n = 3;

            Solution solution = new Solution();
            solution.Merge(nums1, m, nums2, n);

            Console.WriteLine("Merged and Sorted Array:");
            foreach (int num in nums1)
            {
                Console.Write(num + " ");
            }
        }
    }
}
