/*
 
Relative Sort Array

Given two arrays arr1 and arr2, the elements of arr2 are distinct, and all elements in arr2 are also in arr1.

Sort the elements of arr1 such that the relative ordering of items in arr1 are the same as in arr2. Elements that do not appear in arr2 should be placed at the end of arr1 in ascending order.
 

Example 1:
Input: arr1 = [2,3,1,3,2,4,6,7,9,2,19], arr2 = [2,1,4,3,9,6]
Output: [2,2,2,1,4,3,3,9,6,7,19]

Example 2:
Input: arr1 = [28,6,22,8,44,17], arr2 = [22,28,8,6]
Output: [22,28,8,6,17,44]

My Approach - 
1) First I sorted values based on relative position and then I sorted remaining values in
the array 1
2) In relative sorting, if array 2 value matches with array 1 then it will swap the founded value
with the relativeSortPosition index value
3) In normal sorting I am basically using bubble sort approach
 
 */


using System;

namespace CSharp_Practice.LeetCodeSolutions._06_24_2024
{
    public class RelativeSortArray
    {
        public static int[] SortArray(int[] arr1, int[] arr2)
        {
            int relativeSortPosition = 0;

            for(int i = 0; i < arr2.Length; i++)
            {
                int relativeSortValue = arr2[i];

                for(int j = 0; j < arr1.Length; j++)
                {
                    if(arr1[j] == relativeSortValue)
                    {
                        int temp = arr1[relativeSortPosition];
                        arr1[relativeSortPosition] = arr1[j];
                        arr1[j] = temp;
                        relativeSortPosition++;
                    }
                }
            }

            if(arr1.Length > arr2.Length)
            {
                for(int i=relativeSortPosition; i<arr1.Length-1; i++)
                {
                    for(int j=relativeSortPosition; j<arr1.Length-1; j++)
                    {
                        if (arr1[j] > arr1[j+1])
                        {
                            int temp = arr1[j];
                            arr1[j] = arr1[j + 1];
                            arr1[j + 1] = temp;
                        }
                    }
                }
            }

            return arr1;
        }

        // [3,5,5,1,1,7,   2,9,4,6,2]

        public static void Main(string[] args)
        {
            int[] arr1 = { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 };
            int[] arr2 = { 2, 1, 4, 3, 9, 6 };

            int[] output = SortArray(arr1, arr2);

            for(int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
        }
    }
}
