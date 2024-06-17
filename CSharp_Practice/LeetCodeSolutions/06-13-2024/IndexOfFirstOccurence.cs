/*
 
Find the Index of the First Occurrence in a String

Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

Example 1:
Input: haystack = "sadbutsad", needle = "sad"
Output: 0
Explanation: "sad" occurs at index 0 and 6.
The first occurrence is at index 0, so we return 0.

Example 2:
Input: haystack = "leetcode", needle = "leeto"
Output: -1
Explanation: "leeto" did not occur in "leetcode", so we return -1.
 
 */


using System;

namespace CSharp_Practice.LeetCodeSolutions._06_13_2024
{
    public class IndexOfFirstOccurence
    {
        public static int FirstOccurence(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            if (needle.Length > haystack.Length)
            {
                return -1;
            }

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    int tempIndex = i;
                    int j;
                    for (j = 0; j < needle.Length; j++)
                    {
                        if (haystack[tempIndex] == needle[j])
                        {
                            tempIndex++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (j == needle.Length)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        public static void Main(string[] args)
        {
            string haystack = "sadbutsad";
            string needle = "sad";

            int output = FirstOccurence(haystack, needle);
            Console.WriteLine(output);
        }
    }
}
