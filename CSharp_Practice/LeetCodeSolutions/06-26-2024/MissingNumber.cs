/*
 
Missing Number

Given an array nums containing n distinct numbers in the range [0, n], return the only number in the range that is missing from the array.

Example 1:
Input: nums = [3,0,1]
Output: 2
Explanation: n = 3 since there are 3 numbers, so all numbers are in the range [0,3]. 2 is the missing number in the range since it does not appear in nums.

Example 2:
Input: nums = [0,1]
Output: 2
Explanation: n = 2 since there are 2 numbers, so all numbers are in the range [0,2]. 2 is the missing number in the range since it does not appear in nums.

Example 3:
Input: nums = [9,6,4,2,3,5,7,0,1]
Output: 8
Explanation: n = 9 since there are 9 numbers, so all numbers are in the range [0,9]. 8 is the missing number in the range since it does not appear in nums.

My Approach -
1) I just used for loop to iterate over the array length
2) Check each index is present in that or not as a value, if not present return that element
 
 */


using System;

namespace CSharp_Practice.LeetCodeSolutions._06_26_2024
{
    public class MissingNumber
    {
        public static int MissingNumberCalculation(int[] nums)
        {
            int output = 0;

            for(int i=0; i<=nums.Length; i++)
            {
                if(!nums.Contains(i))
                {
                    output = i;
                }
            }

            return output;
        }

        public static void Main(string[] args)
        {
            int[] nums = { 3, 0, 1 };

            int output = MissingNumberCalculation(nums);

            Console.WriteLine(output);
        }
    }
}
