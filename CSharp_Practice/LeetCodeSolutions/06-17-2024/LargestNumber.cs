/*
 
Largest Number

Given a list of non-negative integers nums, arrange them such that they form the largest number and return it.

Since the result may be very large, so you need to return a string instead of an integer.


Example 1:
Input: nums = [10,2]
Output: "210"

Example 2:
Input: nums = [3,30,34,5,9]
Output: "9534330"
 
 */


using System;

namespace CSharp_Practice.LeetCodeSolutions._06_17_2024
{
    public class LargestNumber
    {
        public static string LargestNumberMaker(int[] nums)
        {
            var numStrings = nums.Select(n => n.ToString()).ToList();

            for (int i = 0; i < numStrings.Count - 1; i++)
            {
                for (int j = 0; j < numStrings.Count - i - 1; j++)
                {
                    if (ShouldSwap(numStrings[j], numStrings[j + 1]))
                    {
                        var temp = numStrings[j];
                        numStrings[j] = numStrings[j + 1];
                        numStrings[j + 1] = temp;
                    }
                }
            }

            for(int i = 0; i < numStrings.Count; i++)
            {
                Console.WriteLine(numStrings[i]);
            }

            if (numStrings[0] == "0")
            {
                return "0";
            }

            return string.Join("", numStrings);
        }

        private static bool ShouldSwap(string x, string y)
        {
            return (x + y).CompareTo(y + x) < 0;
        }

        public static void Main(string[] args)
        {
            int[] nums = { 3, 30, 34, 5, 9 }; // 34 30 9 5 3

            string output = LargestNumberMaker(nums);

            Console.WriteLine(output);
        }
    }
}
