using System;
namespace FirstOccourence
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string haystack = "hello";
            string needle = "ll";

            Solution solution = new Solution();
            int index = solution.StrStr(haystack, needle);

            Console.WriteLine(index);
        }
    }
}


