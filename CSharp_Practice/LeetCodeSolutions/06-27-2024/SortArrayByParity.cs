/*
 
 Sort Array By Parity

Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.

Return any array that satisfies this condition.

Example 1:
Input: nums = [3,1,2,4]
Output: [2,4,3,1]
Explanation: The outputs [4,2,3,1], [2,4,1,3], and [4,2,1,3] would also be accepted.

Example 2:
Input: nums = [0]
Output: [0]
 

My Approach - 
1) I took two index, one at 0 for even numbers and the another at array length - 1 for
odd numbers
2) created a new array to insert these values
3) Iterated over array and if value is even then insert at even index and increment it,
if it's odd then insert at odd index and decrement it.
 */


using System;

namespace CSharp_Practice.LeetCodeSolutions._06_27_2024
{
    public class SortArrayByParity
    {
        public static int[] SortArray(int[] nums)
        {
            int[] result = new int[nums.Length];

            int evenIndex = 0;
            int oddIndex = nums.Length - 1;

            for(int i = 0; i < nums.Length; i++)
            {
                if ((nums[i] % 2) == 0)
                {
                    result[evenIndex] = nums[i];
                    evenIndex++;
                }
                else
                {
                    result[oddIndex] = nums[i];
                    oddIndex--;
                }
            }

            return result;
        }

        public static void Main(string[] args)
        {
            int[] nums = { 3, 1, 2, 4 };

            int[] output = SortArray(nums);

            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
