using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    public class Solution
    {
        public int[] SortArrayByParity(int[] nums)
        {
            int[] result = new int[nums.Length];
            int start = 0;
            int end = nums.Length - 1;

            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    result[start++] = num;
                }
                else
                {
                    result[end--] = num;
                }
            }

            return result;
        }
    }
}