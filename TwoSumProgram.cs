using System;
namespace TwoSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            Solution solution = new Solution();
            try
            {
                int[] result = solution.TwoSum(nums, target);
                Console.WriteLine($"{target}: {result[0]}, {result[1]}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
