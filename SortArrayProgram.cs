using System;
namespace SortArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = { 3, 1, 2, 4 };

            Solution solution = new Solution();
            int[] sorted = solution.SortArrayByParity(nums);

            foreach (int num in sorted)
            {
                Console.Write(num + " ");
            }
        }
    }
}


