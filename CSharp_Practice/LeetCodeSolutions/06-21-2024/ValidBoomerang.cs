/*
 
Valid Boomerang

Given an array points where points[i] = [xi, yi] represents a point on the X-Y plane, return true if these points are a boomerang.

A boomerang is a set of three points that are all distinct and not in a straight line.

Example 1:
Input: points = [[1,1],[2,3],[3,2]]
Output: true

Example 2:
Input: points = [[1,1],[2,2],[3,3]]
Output: false

My Approach -
1) Initalized variables from the array
2) Just used formula to find whether valid boomerang or not

 */


using System;

namespace CSharp_Practice.LeetCodeSolutions._06_21_2024
{
    public class ValidBoomerang
    {
        public static bool IsBoomerang(int[][] points)
        {
            int x1 = points[0][0];
            int y1 = points[0][1];
            int x2 = points[1][0];
            int y2 = points[1][1];
            int x3 = points[2][0];
            int y3 = points[2][1];

            int area = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);

            return area != 0;
        }

        public static void Main(string[] args)
        {
            int[][] points = [[0, 0], [2, 1], [2, 1]];

            bool output = IsBoomerang(points);

            Console.WriteLine(output);
        }
    }
}
