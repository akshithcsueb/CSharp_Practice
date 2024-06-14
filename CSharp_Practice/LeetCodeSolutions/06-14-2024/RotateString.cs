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

        public static void Main()
        {
            string s = "bbbacddceeb";
            string goal = "ceebbbbacdd";

            bool output = RotateStringValue(s, goal);

            Console.WriteLine(output);
        }
    }
}
