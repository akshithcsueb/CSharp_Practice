/*
 
Count Prefixes of a Given String

You are given a string array words and a string s, where words[i] and s comprise only of lowercase English letters.

Return the number of strings in words that are a prefix of s.

A prefix of a string is a substring that occurs at the beginning of the string. A substring is a contiguous sequence of characters within a string.

 

Example 1:
Input: words = ["a","b","c","ab","bc","abc"], s = "abc"
Output: 3
Explanation:
The strings in words which are a prefix of s = "abc" are:
"a", "ab", and "abc".
Thus the number of strings in words which are a prefix of s is 3.

Example 2:
Input: words = ["a","a"], s = "aa"
Output: 2
Explanation:
Both of the strings are a prefix of s. 
Note that the same string can occur multiple times in words, and it should be counted each time.
 

My Approach - 
1) Iterating over words arrays and in that iterating over each word
2) comparing each letter in the word array to the s string
3) break the checking if word letters and s letters doesn't match
4) if u reach end letter of word and if it is same then update count
 */


using System;

namespace CSharp_Practice.LeetCodeSolutions._06_18_2024
{
    public class PrefixOfGivenString
    {
        public static int CountPrefixes(string[] words, string s)
        {
            int count = 0;

            for(int i = 0; i < words.Length; i++)
            {
                for(int j = 0; j < words[i].Length; j++)
                {
                    if(j < s.Length)
                    {
                        if (words[i][j] != s[j])
                        {
                            break;
                        }
                        else
                        {
                            if (words[i].Length - 1 == j)
                            {
                                count++;
                            }
                        }
                    }
                }
            }

            return count;
        }

        public static void Main(string[] args)
        {
            string[] words = { "e", "pplp", "rt", "xyz", "l", "brn", "l", "l", "l", "l", "l", "l", "tw", "l", "zjyd", "lj", "yfy", "za", "l", "l", "l", "l", "l", "l", "lfnb", "l", "sc", "l", "vu", "o", "l" };
            string s = "l";

            int output = CountPrefixes(words, s);

            Console.WriteLine(output);
        }
    }
}
