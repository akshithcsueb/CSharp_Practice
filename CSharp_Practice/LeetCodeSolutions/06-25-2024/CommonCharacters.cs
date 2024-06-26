/*
 
 Find Common Characters

Given a string array words, return an array of all characters that show up in all strings within the words (including duplicates). You may return the answer in any order.

Example 1:
Input: words = ["bella","label","roller"]
Output: ["e","l","l"]

Example 2:
Input: words = ["cool","lock","cook"]
Output: ["c","o"]

My Approach - 
1) Took a dictionary and added all letters and it's count to it for just first word in
the array alone
2) From the second word I added all it's letters and it's count to the new dictionary, 
and for each next word this dictionary will be overwriten
3) From the second word after adding to dictionary, we will compare these two dictionaries,
I iterated over first dictionary and check the values of this key in both dictionaries,
If tempValues dictionary value is lesser than charValues dictionary value then I will
replace the tempValues dictionary value of that key to the charValues dictionary value of that key
4) Finally I will iterate over the charValues dictionary and push those letters to the list
 */


using System;

namespace CSharp_Practice.LeetCodeSolutions._06_25_2024
{
    public class CommonCharacters
    {
        public static IList<string> FindCommonChars(string[] words)
        {
            Dictionary<char, int> charValues = new Dictionary<char, int>();

            for(int i = 0; i < words.Length; i++)
            {
                Dictionary<char, int> tempValues = new Dictionary<char, int>();

                for(int j = 0; j < words[i].Length; j++)
                {
                    if(i == 0)
                    {
                        if (!charValues.ContainsKey(words[i][j]))
                        {
                            charValues.Add(words[i][j], 1);
                        }
                        else
                        {
                            charValues[words[i][j]]++;
                        }
                    }
                    else
                    {
                        if (!tempValues.ContainsKey(words[i][j]))
                        {
                            tempValues.Add(words[i][j], 1);
                        }
                        else
                        {
                            tempValues[words[i][j]]++;
                        }
                    }
                }

                if(i != 0)
                {
                    foreach (KeyValuePair<char, int> kvp in charValues)
                    {
                        if (tempValues.ContainsKey(kvp.Key))
                        {
                            if (tempValues.TryGetValue(kvp.Key, out int value))
                            {
                                if (value < kvp.Value)
                                {
                                    charValues[kvp.Key] = value;
                                }
                            }
                        }
                        else
                        {
                            charValues.Remove(kvp.Key);
                        }
                    }
                }
            }

            IList<string> result = new List<string>();

            foreach(KeyValuePair<char, int> kvp in charValues)
            {
                for(int i=0; i < kvp.Value; i++)
                {
                    result.Add(kvp.Key.ToString());
                }
            }

            return result;
        }

        public static void Main(string[] args)
        {
            string[] words = { "bella", "label", "roller" };

            IList<string> output = FindCommonChars(words);

            for(int i = 0;i < output.Count;i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
