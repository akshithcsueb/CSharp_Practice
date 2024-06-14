using System;

namespace CSharp_Practice.LeetCodeSolutions._06_14_2024
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
