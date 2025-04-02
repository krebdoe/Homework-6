using System;

namespace RemoveElement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = { 3, 2, 2, 3, 4, 2 };
            int valToRemove = 2;

            Solution solution = new Solution();
            int newLength = solution.RemoveElement(nums, valToRemove);

            Console.WriteLine($"New length: {newLength}");
            Console.Write("Modified array: ");
            for (int i = 0; i < newLength; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
