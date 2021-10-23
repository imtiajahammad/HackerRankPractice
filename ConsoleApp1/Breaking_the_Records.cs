using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolvings
{
    public class Breaking_the_Records
    {
        public Breaking_the_Records()
        {
            //List<int> lists = new List<int> { 12, 24, 10, 24 };
            //List<int> lists = new List<int> { 10, 5 ,20 ,20 ,4 ,5 ,2, 25, 1 };
            List<int> lists = new List<int> { 3 ,4, 21 ,36 ,10 ,28 ,35 ,5 ,24, 42 };

            var result = breakingRecords(lists);
            foreach(int iterate in result)
            {
                Console.WriteLine(iterate+"-||   ");

            }
        }
        public List<int> breakingRecords(List<int> scores)
        {
            if (scores.Count == 0) { return new List<int> { 0, 0 }; }
            int index = 0; int max = 0;int min = 0;int maxCount = 0;int minCount = 0;
            foreach(int a in scores)
            {
                if (index == 0)
                {
                    max = a;min = a;index++;
                }
                else
                {
                    if (a > max)
                    {
                        maxCount++;
                        max = a;
                    }
                    else if (a < min)
                    {
                        minCount++;
                        min = a;
                    }
                }
            }
            return new List<int> { maxCount, minCount };
        }

    }
}
