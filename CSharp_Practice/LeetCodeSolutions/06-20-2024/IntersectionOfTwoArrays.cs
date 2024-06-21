/*
 
 Intersection of Two Arrays

Given two integer arrays nums1 and nums2, return an array of their 
intersection
. Each element in the result must be unique and you may return the result in any order.

 

Example 1:
Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2]

Example 2:
Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [9,4]
Explanation: [4,9] is also accepted.

My Approach -
1) I am using HashSet to not allow duplicates
2) Created two hashsets one for first array to remove duplicates and another for final result
3) Iterating over second array and checking whether each element is present in the set1 or not,
if present add to resultSet
4) finally the return type is array, so converting from hashset to array
 
 */


using System;

namespace CSharp_Practice.LeetCodeSolutions._06_20_2024
{
    public class IntersectionOfTwoArrays
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> set1 = new HashSet<int>(nums1);
            HashSet<int> resultSet = new HashSet<int>();

            foreach (int num in nums2)
            {
                if (set1.Contains(num))
                {
                    resultSet.Add(num);
                }
            }

            int[] result = new int[resultSet.Count];
            resultSet.CopyTo(result);            

            return result;
        }

        public static void Main(string[] args)
        {
            int[] nums1 = { 4, 9, 5 };
            int[] nums2 = { 9, 4, 9, 8, 4 };

            int[] output = Intersection(nums1, nums2);

            for(int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
