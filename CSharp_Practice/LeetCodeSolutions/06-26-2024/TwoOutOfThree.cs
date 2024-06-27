/*
 
 Two Out of Three

Given three integer arrays nums1, nums2, and nums3, return a distinct array containing all the values that are present in at least two out of the three arrays. You may return the values in any order.

Example 1:
Input: nums1 = [1,1,3,2], nums2 = [2,3], nums3 = [3]
Output: [3,2]
Explanation: The values that are present in at least two arrays are:
- 3, in all three arrays.
- 2, in nums1 and nums2.

Example 2:
Input: nums1 = [3,1], nums2 = [2,3], nums3 = [1,2]
Output: [2,3,1]
Explanation: The values that are present in at least two arrays are:
- 2, in nums2 and nums3.
- 3, in nums1 and nums2.
- 1, in nums1 and nums3.

Example 3:
Input: nums1 = [1,2,2], nums2 = [4,3,3], nums3 = [5]
Output: []
Explanation: No value is present in at least two arrays.
 
My Approach - 
1) Created a dictionary to store frequency of each unique elements in the array
2) Used Hashset to get the unique elements in each array
3) Passed these hashset values of each array to the dictionary and check if not present
add new one with value as 1 and if present just increment value
4) Finally iterating over dictionary and adding values to IList which are greater or eqaul to 2
 */


using System;

namespace CSharp_Practice.LeetCodeSolutions._06_26_2024
{
    public class TwoOutOfThree
    {
        public static IList<int> TwoOutOfThreeCalculation(int[] nums1, int[] nums2, int[] nums3)
        {
            IList<int> result = new List<int>();

            Dictionary<int, int> values = new Dictionary<int, int>();

            HashSet<int> nums1HS = new HashSet<int>(nums1);

            foreach(int val in nums1HS)
            {
                if(!values.ContainsKey(val))
                {
                    values.Add(val, 1);
                }
                else
                {
                    values[val]++; 
                }
            }

            HashSet<int> nums2HS = new HashSet<int>(nums2);

            foreach (int val in nums2HS)
            {
                if (!values.ContainsKey(val))
                {
                    values.Add(val, 1);
                }
                else
                {
                    values[val]++;
                }
            }

            HashSet<int> nums3HS = new HashSet<int>(nums3);

            foreach (int val in nums3HS)
            {
                if (!values.ContainsKey(val))
                {
                    values.Add(val, 1);
                }
                else
                {
                    values[val]++;
                }
            }

            foreach(KeyValuePair<int, int> kvp in values)
            {
                if(kvp.Value >= 2)
                {
                    result.Add(kvp.Key);
                }
            }

            return result;
        }

        public static void Main(string[] args)
        {
            int[] nums1 = { 1, 1, 3, 2 };
            int[] nums2 = { 2, 3 };
            int[] nums3 = { 3 };

            IList<int> list = TwoOutOfThreeCalculation(nums1, nums2, nums3);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
