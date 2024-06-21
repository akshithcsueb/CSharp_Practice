/*
 
Move Zeroes

Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

Example 1:
Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]

Example 2:
Input: nums = [0]
Output: [0]

My Approach -
1) Used two for loops, one for 0 pointer and another for not 0 pointer
2) if 0 is found then it will check for not 0 value and swap them and break the loop

 */


using System;

namespace CSharp_Practice.LeetCodeSolutions._06_21_2024
{
    public class MoveZeroes
    {
        public static void MoveZeroesOperation(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    for(int j = i;  j < nums.Length; j++)
                    {
                        if(nums[j] != 0)
                        {
                            int temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                            break;
                        }
                    }
                }
            }

            for(int i = 0;i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }

        public static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };

            MoveZeroesOperation(nums);
        }
    }
}
