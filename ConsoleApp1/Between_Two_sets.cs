using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolvings
{
    public class Between_Two_sets
    {
        public Between_Two_sets()
        {
            /*
            
            List<int> multipleProcessor = new List<int> { 2, 6 };
            List<int> factorProcessor = new List<int> { 24, 36 };
            result=>2

            List<int> multipleProcessor = new List<int> { 2,4 };
            List<int> factorProcessor = new List<int> { 16,32,96 };
            result=>3

            List<int> multipleProcessor = new List<int> { 100, 99, 98, 97, 96, 95, 94, 93, 92, 91 };
            List<int> factorProcessor = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            result=>0

            List<int> multipleProcessor = new List<int> { 3, 4 };
            List<int> factorProcessor = new List<int> { 24, 48 };
            result=>2
            
            
            List<int> multipleProcessor = new List<int> { 1 };
            List<int> factorProcessor = new List<int> { 100 };
            result=>9

            */


            List<int> multipleProcessor = new List<int> { 1 };
            List<int> factorProcessor = new List<int> { 100 };


            int res = getTotalX(multipleProcessor, factorProcessor);
            Console.WriteLine(res);
        }
        public static int getTotalX(List<int> a, List<int> b)
        {
            if (a.Count == 0 || b.Count == 0) { return 0; }
            Dictionary<int, int> dict = new Dictionary<int, int>();
            //dict.Clear();
            #region getting the common factors of the B
            foreach (int p in b)
            {
                for (int i = 1; i <= p; i++)
                {
                    if (p % i == 0)
                    {
                        if (dict.ContainsKey(i))
                        {
                            dict[i] = dict[i] + 1;
                        }
                        else
                        {
                            dict.Add(i, 1);
                        }
                    }
                }
            }
            List<int> commonFactors = new List<int>();
            foreach (var q in dict)
            {
                if (q.Value == b.Count)
                {
                    commonFactors.Add(q.Key);
                }
            }
            commonFactors.Sort();
            if (commonFactors.Count == 0) { return 0; }
            int limit = commonFactors[commonFactors.Count-1];
            #endregion  getting the common factors of the B
            dict.Clear();
            foreach (int m in a)
            {
                int index = 1;
                int result = 1;
                while ((index*m) <= limit)
                {
                    result = index * m;
                    index = index + 1;
                    if (dict.ContainsKey(result))
                    {
                        dict[result] = dict[result] + 1;
                    }
                    else
                    {
                        dict.Add(result, 1);
                    }
                }
            }
            List<int> commonMultiples = new List<int>();
            foreach (var n in dict)
            {
                if (n.Value == a.Count)
                {
                    commonMultiples.Add(n.Key);
                }
            }
            if (commonMultiples.Count == 0) { return 0; }
            int count = 0;
            foreach(int k in commonMultiples)
            {
                if (commonFactors.Contains(k))
                {
                    count++;
                }
            }
            return count;
        }
        

    }
}
