using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolvings
{
    public class Subarray_Division
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/the-birthday-bar/problem
        /// Two children, Lily and Ron, want to share a chocolate bar. Each of the squares has an integer on it.
        /// Lily decides to share a contiguous segment of the bar selected such that:
        /// The length of the segment matches Ron's birth month, and,
        /// The sum of the integers on the squares is equal to his birth day.
        /// Determine how many ways she can divide the chocolate.
        /// </summary>
        public Subarray_Division()
        {
            //int res = birthday(new List<int> { 2, 2, 1, 3, 2 },4,2);/*=>result is 2*/
            //int res = birthday(new List<int> { 1,2,1,3,2 }, 3, 2);/*=>result is 2*/
            //int res = birthday(new List<int> { 1,1,1,1,1,1 }, 3, 2);/*=>result is 0*/
            int res = birthday(new List<int> { 4 }, 4,1);/*=>result is 1*/
            Console.WriteLine(res);
        }
        public int birthday(List<int> s, int d, int m)
        {
            int sum = 0;
            int ways = 0;
            int[] toarray = s.ToArray();
            for(int i = 0; i < toarray.Length-(m-1); i++)
            {
                Console.WriteLine("for first index is {0} and value is {1}", i, s[i]);
                int rotation = 1;
                int rotationSum = 0;
                int index = i;
                while (rotation <= m)
                {
                    
                    int temp = toarray[index];
                    rotationSum = rotationSum + temp;
                    Console.WriteLine("for first while rotation is {0}, temp is {1} and sum is {2}", rotation, temp, rotationSum);
                    rotation++;index++;
                }
                if (rotationSum == d)
                {
                    ways++;
                }
            }
            return ways;
        }
    }
}
