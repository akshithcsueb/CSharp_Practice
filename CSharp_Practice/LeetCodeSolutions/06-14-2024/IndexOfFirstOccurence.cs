using System;

namespace CSharp_Practice.LeetCodeSolutions._06_14_2024
{
    public class IndexOfFirstOccurence
    {
        public static int FirstOccurence(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }

            if (needle.Length > haystack.Length)
            {
                return -1;
            }

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    int tempIndex = i;
                    int j;
                    for (j = 0; j < needle.Length; j++)
                    {
                        if (haystack[tempIndex] == needle[j])
                        {
                            tempIndex++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (j == needle.Length)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        public static void Main()
        {
            string haystack = "sadbutsad";
            string needle = "sad";

            int output = FirstOccurence(haystack, needle);
            Console.WriteLine(output);
        }
    }
}
