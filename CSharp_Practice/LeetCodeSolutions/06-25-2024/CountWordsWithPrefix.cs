/*
 
Counting Words With a Given Prefix

You are given an array of strings words and a string pref.

Return the number of strings in words that contain pref as a prefix.

A prefix of a string s is any leading contiguous substring of s.

Example 1:
Input: words = ["pay","attention","practice","attend"], pref = "at"
Output: 2
Explanation: The 2 strings that contain "at" as a prefix are: "attention" and "attend".

Example 2:
Input: words = ["leetcode","win","loops","success"], pref = "code"
Output: 0
Explanation: There are no strings that contain "code" as a prefix.
 
My Approach - 
1) Using for loop going over the words in array and just checking if the prefix contains or not in the string starting
using string method.
 */


using System;

namespace CSharp_Practice.LeetCodeSolutions._06_25_2024
{
    public class CountWordsWithPrefix
    {
        public static int CountWords(string[] words, string pref)
        {
            int count = 0;

            for(int i = 0; i < words.Length; i++)
            {
                if (words[i].StartsWith(pref))
                {
                    count++;
                }
            }

            return count;
        }

        public static void Main(string[] args)
        {
            string[] words = { "pay", "attention", "practice", "attend" };
            string prefix = "at";

            int output = CountWords(words, prefix);

            Console.WriteLine(output);
        }
    }
}
