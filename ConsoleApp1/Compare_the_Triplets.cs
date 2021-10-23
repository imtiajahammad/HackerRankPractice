using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolvings
{
    public class Compare_the_Triplets
    {
        public Compare_the_Triplets()
        {
            //List<int> result = compareTriplets(new List<int> { 1, 2, 3 }, new List<int> { 3, 2, 1 });
            List<int> result = compareTriplets(new List<int> { 5,6,7 }, new List<int> { 3,6,10 });
            foreach (var a in result)
            {
                Console.Write(a + " ");
            }
        }
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int[] aarray = a.ToArray();
            int[] barray = b.ToArray();
            int alice = 0;
            int bob = 0;
            for(int i = 0; i < a.Count; i++)
            {
                if (aarray[i] > barray[i])
                {
                    alice++;
                }
                else if (barray[i] > aarray[i])
                {
                    bob++;
                }
            }
            return new List<int> { alice, bob };

        }
    }
}
