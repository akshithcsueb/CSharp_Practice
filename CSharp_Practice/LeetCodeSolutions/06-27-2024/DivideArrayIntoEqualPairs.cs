/*
 
 Divide Array Into Equal Pairs

You are given an integer array nums consisting of 2 * n integers.

You need to divide nums into n pairs such that:

Each element belongs to exactly one pair.
The elements present in a pair are equal.
Return true if nums can be divided into n pairs, otherwise return false.

Example 1:
Input: nums = [3,2,3,2,2,2]
Output: true
Explanation: 
There are 6 elements in nums, so they should be divided into 6 / 2 = 3 pairs.
If nums is divided into the pairs (2, 2), (3, 3), and (2, 2), it will satisfy all the conditions.

Example 2:
Input: nums = [1,2,3,4]
Output: false
Explanation: 
There is no way to divide nums into 4 / 2 = 2 pairs such that the pairs satisfy every condition.
 

My Approach - 
1) First I am checking whether I can divide the size of array by 2 or not
2) If I am able to divide then I am using dictionary and inserting all values of array
as keys and it's frequencies
3) Finally I am trying to divide the values of each dictionary key by 2 or not, if I get not 0
for modulo operation then I will return false else return true.


 */


using System;

namespace CSharp_Practice.LeetCodeSolutions._06_27_2024
{
    public class DivideArrayIntoEqualPairs
    {
        public static bool DivideArray(int[] nums)
        {
            Dictionary<int, int> values = new Dictionary<int, int>();

            if((nums.Length % 2) == 0)
            {
                for(int i = 0; i < nums.Length; i++)
                {
                    if (!values.ContainsKey(nums[i]))
                    {
                        values.Add(nums[i], 1);
                    }
                    else
                    {
                        values[nums[i]]++;
                    }
                }

                foreach(KeyValuePair<int, int> kvp in values)
                {
                    if((kvp.Value % 2) != 0)
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        public static void Main(string[] args)
        {
            int[] nums = { 3, 2, 3, 2, 2, 2 };

            bool output = DivideArray(nums);

            Console.WriteLine(output);
        }
    }
}
