/*
 
 Majority Element

Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

Example 1:
Input: nums = [3,2,3]
Output: 3

Example 2:
Input: nums = [2,2,1,1,1,2,2]
Output: 2

My Approach -
1) Created dictionary to store each element and it's count
2) While iterating over the array, if the element is new will create one and add 1 as value to it,
otherwise I will increment it's value
3) Finally Iterating over the dictionary to check Major element by checking with (n/2) condition,
and the current value should be greater than previous ones then it will store as result as key.
 
 */

using System;

namespace CSharp_Practice.LeetCodeSolutions._06_20_2024
{
    public class MajorityElement
    {
        public static int CheckMajorityElement(int[] nums)
        {
            Dictionary<int, int> elements = new Dictionary<int, int>();
            int result = 0;
            int check = nums.Length/2;

            for(int i = 0; i < nums.Length; i++)
            {
                if(!elements.ContainsKey(nums[i]))
                {
                    elements.Add(nums[i], 1);
                }
                else
                {
                    elements[nums[i]]++;
                }
            }

            foreach(KeyValuePair <int, int> kvp in elements)
            {
                if(kvp.Value > check && kvp.Value > result)
                {
                    result = kvp.Key;
                }
            }

            return result;
        }

        public static void Main(string[] args)
        {
            int[] nums = { 2, 2, 1, 1, 1, 2, 2 };

            int output = CheckMajorityElement(nums);

            Console.WriteLine(output);
        }
    }
}
