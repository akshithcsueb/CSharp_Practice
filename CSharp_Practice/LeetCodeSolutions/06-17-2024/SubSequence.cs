/*
 
Is Subsequence

Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).


Example 1:
Input: s = "abc", t = "ahbgdc"
Output: true

Example 2:
Input: s = "axc", t = "ahbgdc"
Output: false
 
 */

using System;

namespace CSharp_Practice.LeetCodeSolutions._06_17_2024
{
    public class SubSequence
    {
        public static bool IsSubSequence(string s, string t)
        {
            if(s.Length == 0 && t.Length != 0)
            {
                return true;
            }

            if (s.Length != 0 && t.Length == 0)
            {
                return false;
            }

            int temp = 0;

            for (int i = 0; i < s.Length; i++)
            {
                for(int j = temp; j < t.Length; j++)
                {
                    if(s[i] == t[j])
                    {
                        if (j == t.Length - 1 && i < s.Length-1)
                        {
                            return false;
                        }

                        if (j == t.Length-1)
                        {
                            break;
                        }

                        temp = j + 1;
                        break;
                    }
                    else
                    {
                        if((i == s.Length-1 && j == t.Length-1) || (i < s.Length-1 && j == t.Length-1))
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        public static void Main(string[] args)
        {
            string s = "axc";
            string t = "ahbgdc";

            bool output = IsSubSequence(s, t);

            Console.WriteLine(output);
        }
    }
}