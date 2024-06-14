using System;

namespace CSharp_Practice.LeetCodeSolutions._06_14_2024
{
    public class ValidAnagram
    {
        public static bool ValidAnagramCheck(string s, string t)
        {
            Dictionary<char, int> anagramChars = new Dictionary<char, int>();

            for(int i = 0; i < s.Length; i++)
            {
                if(!anagramChars.ContainsKey(s[i]))
                {
                    anagramChars.Add(s[i], 1);
                }
                else
                {
                    anagramChars[s[i]]++;
                }
            }

            
            for(int i = 0; i < t.Length; i++)
            {
                if(anagramChars.ContainsKey(t[i]))
                {
                    anagramChars[t[i]]--;
                }
                else
                {
                    return false;
                }
            }

            foreach (KeyValuePair<char, int> kvp in anagramChars)
            {
                if(kvp.Value != 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Main()
        {
            string s = "anagram";
            string t = "nagaram";

            bool output = ValidAnagramCheck(s, t);

            Console.WriteLine(output);
        }
    }
}
