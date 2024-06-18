/*
 
Count Common Words With One Occurrence

Given two string arrays words1 and words2, return the number of strings that appear exactly once in each of the two arrays.

Example 1:
Input: words1 = ["leetcode","is","amazing","as","is"], words2 = ["amazing","leetcode","is"]
Output: 2
Explanation:
- "leetcode" appears exactly once in each of the two arrays. We count this string.
- "amazing" appears exactly once in each of the two arrays. We count this string.
- "is" appears in each of the two arrays, but there are 2 occurrences of it in words1. We do not count this string.
- "as" appears once in words1, but does not appear in words2. We do not count this string.
Thus, there are 2 strings that appear exactly once in each of the two arrays.

Example 2:
Input: words1 = ["b","bb","bbb"], words2 = ["a","aa","aaa"]
Output: 0
Explanation: There are no strings that appear in each of the two arrays.

Example 3:
Input: words1 = ["a","ab"], words2 = ["a","a","a","ab"]
Output: 1
Explanation: The only string that appears exactly once in each of the two arrays is "ab".

My Approach - 
1) created Dictionary
2) added first array words into it, if exist just put -1 as value, if not 1 as value
3) decrement values of words that match in first and second array
4) iterate over the dictionary and i am just looking for values that have 0 and counting them
 
 */


using System;

namespace CSharp_Practice.LeetCodeSolutions._06_18_2024
{
    public class CommonWords
    {
        public static int CountCommonWords(string[] words1, string[] words2)
        {
            int count = 0;

            Dictionary<string, int> words = new Dictionary<string, int>();

            for (int i = 0; i < words1.Length; i++)
            {
                if (words.ContainsKey(words1[i]))
                {
                    words[words1[i]] = -1;
                }
                else
                {
                    words.Add(words1[i], 1);
                }
            }

            for (int i = 0; i < words2.Length; i++)
            {
                if (words.ContainsKey(words2[i]))
                {
                    words[words2[i]]--;
                }
            }

            foreach (KeyValuePair<string, int> kvp in words)
            {
                if(kvp.Value == 0)
                {
                    count++;
                }
            }

            return count;
        }

        public static void Main(string[] args)
        {
            string[] words1 = { "", "" };
            string[] words2 = { "" };

            int output = CountCommonWords(words1, words2);
            Console.WriteLine(output);
        }
    }
}
