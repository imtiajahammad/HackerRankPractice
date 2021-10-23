using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolvings
{
    public class Apple_and_Orange
    {
        public Apple_and_Orange()
        {
            CountApplesAndOranges(7, 10, 4, 12, new List<int> { 3, -2, -4  }, new List<int> { 2, 3, -4 });
        }
        public static void CountApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int applesCount = 0; int orangesCount = 0;
            List<int> newApples=new List<int>(); List<int> newOranges=new List<int>();
            foreach (int i in apples)
            {
                newApples.Add(i + a);
            }
            foreach (int j in oranges)
            {
                newOranges.Add(j + b);
            }
            foreach (int m in newApples)
            {
                if (s <= m && m <= t)
                {
                    applesCount++;
                }
            }
            Console.WriteLine(applesCount);
            foreach (int m in newOranges)
            {
                if (s <= m && m <= t)
                {
                    orangesCount++;
                }
            }
            Console.WriteLine(orangesCount);

        }
    }
}
