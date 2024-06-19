/*
 
 Find the Difference of Two Arrays

Given two 0-indexed integer arrays nums1 and nums2, return a list answer of size 2 where:

answer[0] is a list of all distinct integers in nums1 which are not present in nums2.
answer[1] is a list of all distinct integers in nums2 which are not present in nums1.
Note that the integers in the lists may be returned in any order.

 

Example 1:
Input: nums1 = [1,2,3], nums2 = [2,4,6]
Output: [[1,3],[4,6]]
Explanation:
For nums1, nums1[1] = 2 is present at index 0 of nums2, whereas nums1[0] = 1 and nums1[2] = 3 are not present in nums2. Therefore, answer[0] = [1,3].
For nums2, nums2[0] = 2 is present at index 1 of nums1, whereas nums2[1] = 4 and nums2[2] = 6 are not present in nums2. Therefore, answer[1] = [4,6].

Example 2:
Input: nums1 = [1,2,3,3], nums2 = [1,1,2,2]
Output: [[3],[]]
Explanation:
For nums1, nums1[2] and nums1[3] are not present in nums2. Since nums1[2] == nums1[3], their value is only included once and answer[0] = [3].
Every integer in nums2 is present in nums1. Therefore, answer[1] = [].
 

My Approach - 
1) created two lists
2) used two nested for loops to check values that doesn't exist in between them
3) for each value in first array go until last element in second array and if it doesn't exist
then also check that is not already present in the list if these satisfied then add to the list,
also if values matches then it will break the check.
4) finally created main array that has these two arrays and returned it
 */


using System;

namespace CSharp_Practice.LeetCodeSolutions._06_19_2024
{
    public class DifferenceOfTwoArrays
    {
        public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            IList<int> answer0 = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        break;
                    }

                    if(j == nums2.Length-1 && !answer0.Contains(nums1[i]))
                    {
                        answer0.Add(nums1[i]);
                    }
                }
            }

            IList<int> answer1 = new List<int>();

            for (int i = 0; i < nums2.Length; i++)
            {
                for (int j = 0; j < nums1.Length; j++)
                {
                    if (nums2[i] == nums1[j])
                    {
                        break;
                    }

                    if (j == nums1.Length - 1 && !answer1.Contains(nums2[i]))
                    {
                        answer1.Add(nums2[i]);
                    }
                }
            }

            IList<IList<int>> answer = [answer0, answer1];

            return answer;
        }


        public static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { 2, 4, 6 };

            IList<IList<int>> output = FindDifference(nums1, nums2);

            foreach (IList<int> i in output)
            {
                foreach (int j in i)
                {
                    Console.WriteLine(j);
                }

                Console.WriteLine("");
            }
        }
    }
    
}
