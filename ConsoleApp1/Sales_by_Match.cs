using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolvings
{
    public class Sales_by_Match
    {
        public Sales_by_Match()
        {
            var value = sockMerchant(9, new List<int> { 10, 20 ,20 ,10, 10, 30 ,50 ,10 ,20 });
            Console.WriteLine(value);
        }
        public int sockMerchant(int n, List<int> ar)
        {
            Dictionary<int, int> dics = new Dictionary<int, int>();
            foreach(int a in ar)
            {
                if (!dics.ContainsKey(a))
                {
                    dics.Add(a, 1);
                }
                else
                {
                    dics[a] = dics[a] + 1;
                }
            }
            int count = 0;
            foreach(var a in dics)
            {
                if ((a.Value / 2)>0)
                {
                    count = count + (a.Value/2);
                }
            }
            return count;
        }
    }
}
