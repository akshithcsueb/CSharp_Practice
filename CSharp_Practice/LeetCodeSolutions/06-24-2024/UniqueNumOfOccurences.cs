/*
 
 Unique Number of Occurrences

Given an array of integers arr, return true if the number of occurrences of each value in the array is unique or false otherwise.

 

Example 1:

Input: arr = [1,2,2,1,1,3]
Output: true
Explanation: The value 1 has 3 occurrences, 2 has 2 and 3 has 1. No two values have the same number of occurrences.
Example 2:

Input: arr = [1,2]
Output: false
Example 3:
Input: arr = [-3,0,1,-3,1,1,1,-3,10,0]
Output: true

My Approach -
1) Created a dictionary to store each value in the array as a key and it's no of times in
the array as value
2) next iterating over the the dictionary values to check count of each value, and if 
greater than 1 then return false otherwise i will return true.
 
 */


using System;

namespace CSharp_Practice.LeetCodeSolutions._06_24_2024
{
    public class UniqueNumOfOccurences
    {
        public static bool UniqueOccurences(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for(int i = 0; i < arr.Length; i++)
            {
                if(dic.ContainsKey(arr[i]))
                {
                    dic[arr[i]]++;
                }
                else
                {
                    dic.Add(arr[i], 1);
                }
            }

            foreach(KeyValuePair<int, int> kvp in dic)
            {
                int count = 0;
                int value = kvp.Value;

                foreach(KeyValuePair<int, int> kvpValue in dic)
                {
                    if(value == kvpValue.Value)
                    {
                        count++;
                    }
                }

                if(count > 1)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Main(string[] args)
        {
            int[] arr = { 1, 2 };

            bool output = UniqueOccurences(arr);

            Console.WriteLine(output);
        }
    }
}
