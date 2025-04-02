using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSortedArray
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }
            int total = m + n;

            for (int i = 0; i < total - 1; i++)
            {
                for (int j = 0; j < total - i - 1; j++)
                {
                    if (nums1[j] > nums1[j + 1])
                    {
                        int tempnum = nums1[j];
                        nums1[j] = nums1[j + 1];
                        nums1[j + 1] = tempnum;
                    }
                }
            }
        }
    }
}