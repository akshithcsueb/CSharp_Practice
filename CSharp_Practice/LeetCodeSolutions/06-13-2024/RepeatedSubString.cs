/*
 
Repeated Substring Pattern

Given a string s, check if it can be constructed by taking a substring of it and appending multiple copies of the substring together. 

Example 1:
Input: s = "abab"
Output: true
Explanation: It is the substring "ab" twice.

Example 2:
Input: s = "aba"
Output: false

Example 3:
Input: s = "abcabcabcabc"
Output: true
Explanation: It is the substring "abc" four times or the substring "abcabc" twice.
 
 */


using System;

namespace CSharp_Practice.LeetCodeSolutions._06_13_2024
{
    public class RepeatedSubString
    {
        public static bool RepeatedSubStringCheck(string s)
        {
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s.Length % (i + 1) == 0)
                {
                    string substring = s.Substring(0, i + 1);
                    bool isMatch = true;

                    for (int j = i + 1; j < s.Length; j += substring.Length)
                    {
                        if (substring != s.Substring(j, substring.Length))
                        {
                            isMatch = false;
                            break;
                        }
                    }

                    if (isMatch)
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        public static void Main(string[] args)
        {
            string s = "abcabcabc";

            bool output = RepeatedSubStringCheck(s);

            Console.WriteLine(output);
        }
    }
}
