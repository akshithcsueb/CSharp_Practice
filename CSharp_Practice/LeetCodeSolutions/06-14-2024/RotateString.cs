/*
 
 Rotate String

Given two strings s and goal, return true if and only if s can become goal after some number of shifts on s.

A shift on s consists of moving the leftmost character of s to the rightmost position.

For example, if s = "abcde", then it will be "bcdea" after one shift.

Example 1:
Input: s = "abcde", goal = "cdeab"
Output: true

Example 2:
Input: s = "abcde", goal = "abced"
Output: false
 
 */


using System;

namespace CSharp_Practice.LeetCodeSolutions._06_14_2024
{
    public class RotateString
    {
        public static bool RotateStringValue(string s, string goal)
        {
            if((s.Length == 0 && goal.Length != 0) || (s.Length != 0 && goal.Length == 0))
            {
                return false;
            }

            string firstSubWord;
            int firstSubWordindex;

            string secondSubWord;
            string fullGoalWord;

            if(s.Length != 0)
            {
                if (s.Contains(goal[0]))
                {
                    List<int> goalIndexes = new List<int>();

                    for (int i=0; i<s.Length; i++)
                    {
                        if(s[i] == goal[0])
                        {
                            goalIndexes.Add(i);
                        }
                    }

                    for (int i=0; i<goalIndexes.Count; i++)
                    {
                        firstSubWordindex = goalIndexes[i];
                        firstSubWord = s.Substring(firstSubWordindex);

                        secondSubWord = s.Substring(0, firstSubWordindex);

                        fullGoalWord = firstSubWord + secondSubWord;

                        if (goal == fullGoalWord)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;

        }

        public static void Main(string[] args)
        {
            string s = "bbbacddceeb";
            string goal = "ceebbbbacdd";

            bool output = RotateStringValue(s, goal);

            Console.WriteLine(output);
        }
    }
}
